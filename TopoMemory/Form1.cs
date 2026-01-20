using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TopoMemory
{
    public partial class TopoMemory : Form
    {
        PictureBox[] Carte;
        int Round = 1;
        string Nome;
        int ncoppiecarte;
        Random rnd = new Random();
        Random RND = new Random();
        int[] SlotCarte;
        int[] RoundCoppieCarte = {8, 18, 32,}; //LEVEL IMPOSSIBLE= 98
        bool Selezione = false;
        bool SelezioneDue = false;
        int P = -1; //Prima scelta
        int S = -1; //Seconda scelta
        int Errori = 0;
        int Indovinate = 0;
        int Tempo;
        int TempoS;//secondi
        int TempoM;//Minuti
        int TempoO;//Ore
        int Kit;
        public TopoMemory()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool l = true;
            string p;
            StreamReader sr = new StreamReader("Classifica.txt");
            while(l==true)
            {
                p=sr.ReadLine();
                if (p != null)
                {
                    Classifica.Items.Add(p);
                }
                else
                {
                    l = false;
                }
            }
            sr.Close();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Round = 0;
            Errori = 0;
            pictureBoxTitolo.Hide();
            Classifica.Hide();
            button_start.Hide();
            label1.Hide();
            label_errori.Show();
            label2.Show();
            TempoTrascorso.Show();
            label3.Show();
            label4.Hide();
            label_round.Show();
            labelinseriscinome.Hide();
            pictureBoxvittoria.Hide();
            textBoxNome.Hide();
            buttonNome.Hide();
            ragequitbutton.Show();
            label_preparazione.Show();
            pictureBoxattesa.Show();
            timer_caricamento.Start();
            label_round.Text = "1/3";
            Tempo = 0;
            TempoS = 0;
            TempoM = 0;
            TempoO = 0;
            this.cards_create();
        }
        private void cards_create()
        {
            Kit = rnd.Next(0, 100 - RoundCoppieCarte[Round]);
            ncoppiecarte = RoundCoppieCarte[Round];
            Indovinate = 0;
            bool c = true;
            int a;
            bool[] SlotUsati = new bool[ncoppiecarte*2];
            SlotCarte = new int[ncoppiecarte*2];
            for(int k = 0; k < SlotCarte.Length; k++)
            {
                SlotCarte[k] = -1;
                SlotUsati[k] = false;
            }
            for(int i = 0; i < ncoppiecarte; i++)
            {
                c = true;
                while (c == true)
                {
                    a = rnd.Next(0, (ncoppiecarte * 2));
                    if (SlotUsati[a] == false)
                    {
                        SlotCarte[a] = i;
                        SlotUsati[a] = true;
                        c = false;
                    }
                }
                c = true;
                while (c == true)
                {
                    a = rnd.Next(0, (ncoppiecarte * 2));
                    if (SlotUsati[a] == false)
                    {
                        SlotCarte[a] = i;
                        SlotUsati[a] = true;
                        c = false;
                    }
                }
            }
            int calc = ncoppiecarte * 2;
            calc=Convert.ToInt32(Math.Sqrt(calc));
            int g = 500 / calc;
            Carte = new PictureBox[ncoppiecarte*2];
            int x = 0;
            int y = 0;
            int u = 0;
            for (int i = 0; i < calc; i++)
            {
                for(int o = 0; o < calc; o++)
                {
                    Carte[u] = new PictureBox();
                    Carte[u].Name = "Carta";
                    Carte[u].Size = new Size(g, g);
                    Carte[u].Location = new Point(x, y);
                    Carte[u].Image = Image.FromFile("background.png");
                    Carte[u].SizeMode = PictureBoxSizeMode.StretchImage;
                    Carte[u].Click += new EventHandler(Carta_Click);
                    this.Controls.Add(Carte[u]);
                    x = x + g;
                    u++;
                }
                x = 0;
                y = y + g;
            }
            int T;
            int RU;
            int RD;
            bool co = true;
            for(int i = 0; i < 100*(Round+1); i++)
            {
                for (int j = 0; j < SlotCarte.Length; j++)
                {
                    RU = rnd.Next(0, SlotCarte.Length);
                    T = SlotCarte[RU];
                    co = true;
                    while (co == true)
                    {
                        RD = RND.Next(0, SlotCarte.Length);
                        if (RD != RU)
                        {
                            if (SlotCarte[RU] != SlotCarte[RD])
                            {
                                co = false;
                                SlotCarte[RU] = SlotCarte[RD];
                                SlotCarte[RD] = T;
                            }
                        }
                    }
                }
            }
        }
        private void Carta_Click(object sender, EventArgs e)
        {
            if (timer_indovinato.Enabled == false)
            {
                int Index = Array.IndexOf(Carte, sender);
                if (SelezioneDue == true)
                {
                    timer_lasciacarte.Stop();
                    Carte[P].Image = Image.FromFile("background.png");
                    Carte[S].Image = Image.FromFile("background.png");
                    Selezione = false;
                    SelezioneDue = false;
                    P = -1;
                    S = -1;
                }
                if (Index != P && Index != S)
                {
                    if (Selezione == false)
                    {
                        Selezione = true;
                        P = Index;
                        Carte[P].Image = Image.FromFile("" + (SlotCarte[P]+Kit).ToString() + ".png");
                    }
                    else
                    {
                        S = Index;
                        Carte[S].Image = Image.FromFile("" + (SlotCarte[S] + Kit).ToString() + ".png");
                        if (SlotCarte[P] == SlotCarte[S])
                        {
                            timer_indovinato.Start();
                        }
                        else
                        {
                            SelezioneDue = true;
                            timer_lasciacarte.Start();
                            Errori++;
                            label_errori.Text = Errori.ToString();
                        }
                    }
                }
            }
        }
        private void checkroundover()
        {
            if(Indovinate >= ncoppiecarte)
            {
                this.roundover();
            }
        }
        private void roundover()
        {
            for (int i = 0; i < Carte.Length; i++)
            {
                this.Controls.Remove(Carte[i]);
            }
            if (Round >= RoundCoppieCarte.Length-1)
            {
                label_round.Text ="3/3";
                this.gameover();
            }
            else
            {
                timer_tempo.Stop();
                Round++;
                label_round.Text = (Round + 1).ToString() + "/3";
                label_preparazione.Show();
                pictureBoxattesa.Show();
                timer_caricamento.Interval = 1000 * Round + 1;
                label_preparazione.Show();
                timer_caricamento.Start();
                this.cards_create();
            }
        }
        private void gameover()
        {
            timer_tempo.Stop();
            labelinseriscinome.Show();
            textBoxNome.Show();
            pictureBoxvittoria.Show();
            buttonNome.Show();
        }
        private void ClassificaAdd()
        {
            string[] temp = new string[Classifica.Items.Count+1];
            if (Classifica.Items.Count != 0)
            {
                StreamWriter sw = new StreamWriter("Classifica.txt");
                string s;
                int valore = 0;
                int valore2 = (Tempo) + (TempoS * 10) + (TempoM * 600) + (TempoO * 36000);
                int i;
                for (i = 0; i < Classifica.Items.Count; i++)
                {
                    valore = 0;
                    s = Classifica.Items[i].ToString();
                    s = s.Remove(0, s.LastIndexOf("/") + 1);
                    if(int.Parse(s.Substring(0, s.IndexOf(":"))) != 0)
                    {
                        valore = int.Parse(s.Substring(0, s.IndexOf(":"))) * 36000;
                    }
                    s = s.Substring(s.IndexOf(":") + 1);
                    if (int.Parse(s.Substring(0, s.IndexOf(":"))) != 0)
                    {
                        valore = valore + int.Parse(s.Substring(0, s.IndexOf(":"))) * 600;
                    }
                    s = s.Substring(s.IndexOf(":") + 1);
                    if (int.Parse(s.Substring(0, s.IndexOf(","))) != 0)
                    {
                        valore = valore + int.Parse(s.Substring(0, s.IndexOf(","))) * 10;
                    }
                    s = s.Substring(s.IndexOf(",") + 1);
                    valore = valore + int.Parse(s);
                    int u = 0;
                    if (valore2 <= valore)
                    {
                        if (valore == valore2)
                        {
                            s = Classifica.Items[i].ToString();
                            s = s.Remove(0, s.IndexOf("/") + 1);
                            s = s.Remove(s.IndexOf("/"));
                            if (Errori == int.Parse(s))
                            {
                                for (u = 0; u < i+1; u++)
                                {
                                    temp[u] = Classifica.Items[u].ToString();
                                }
                                temp[u] = (Nome + "/" + Errori.ToString() + "/" + TempoO.ToString() + ":" + TempoM.ToString() + ":" + TempoS.ToString() + "," + Tempo.ToString());
                                u++;
                                for (int d = u; d < temp.Length; d++)
                                {
                                    temp[d] = Classifica.Items[d - 1].ToString();
                                }
                                i = Classifica.Items.Count + 1;
                                //dopo s
                            }
                            else
                            {
                                if (Errori < int.Parse(s))
                                {
                                    for (u = 0; u < i; u++)
                                    {
                                        temp[u] = Classifica.Items[u].ToString();
                                    }
                                    temp[u] = (Nome + "/" + Errori.ToString() + "/" + TempoO.ToString() + ":" + TempoM.ToString() + ":" + TempoS.ToString() + "," + Tempo.ToString());
                                    u++;
                                    for (int d = u; d < temp.Length; d++)
                                    {
                                        temp[d] = Classifica.Items[d - 1].ToString();
                                    }
                                    i = Classifica.Items.Count + 1;
                                    //prima di s
                                }
                                else
                                {
                                    for (u = 0; u < i+1; u++)
                                    {
                                        temp[u] = Classifica.Items[u].ToString();
                                    }
                                    temp[u] = (Nome + "/" + Errori.ToString() + "/" + TempoO.ToString() + ":" + TempoM.ToString() + ":" + TempoS.ToString() + "," + Tempo.ToString());
                                    u++;
                                    for (int d = u; d < temp.Length; d++)
                                    {
                                        temp[d] = Classifica.Items[d - 1].ToString();
                                    }
                                    i = Classifica.Items.Count + 1;
                                    //dopo s
                                }
                            }
                        }
                        else
                        {
                            for (u = 0; u < i; u++)
                            {
                                temp[u] = Classifica.Items[u].ToString();
                            }
                            temp[u] = (Nome + "/" + Errori.ToString() + "/" + TempoO.ToString() + ":" + TempoM.ToString() + ":" + TempoS.ToString() + "," + Tempo.ToString());
                            u++;
                            for (int d=u; d < temp.Length; d++)
                            {
                                temp[d] = Classifica.Items[d-1].ToString();
                            }
                            i = Classifica.Items.Count + 1;
                            //prima s
                        }
                    }
                }
                if (i == Classifica.Items.Count)
                {
                    for (i = 0; i < Classifica.Items.Count; i++)
                    {
                        temp[i] = Classifica.Items[i].ToString();
                    }
                    temp[i]= (Nome + "/" + Errori.ToString() + "/" + TempoO.ToString() + ":" + TempoM.ToString() + ":" + TempoS.ToString() + "," + Tempo.ToString());
                }
                Classifica.Items.Clear();
                for(i = 0; i < temp.Length; i++)
                {
                    Classifica.Items.Add(temp[i]);
                    sw.WriteLineAsync(temp[i]);
                }
                sw.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter("Classifica.txt");
                sw.WriteLineAsync(Nome + "/" + Errori.ToString() + "/" + TempoO.ToString() + ":" + TempoM.ToString() + ":" + TempoS.ToString() + "," + Tempo.ToString());
                sw.Close();
                Classifica.Items.Add((Nome + "/" + Errori.ToString() + "/" + TempoO.ToString() + ":" + TempoM.ToString() + ":" + TempoS.ToString() + "," + Tempo.ToString()));
            }
            this.stopgame();
        }
        private void stopgame()
        {
            textBoxNome.Text = "";
            timer_tempo.Stop();
            pictureBoxTitolo.Show();
            Classifica.Show();
            button_start.Show();
            label1.Show();
            label_errori.Hide();
            label_errori.Text = Errori.ToString();
            label2.Hide();
            TempoTrascorso.Hide();
            TempoTrascorso.Text = "0:0:0,0";
            label3.Hide();
            label4.Show();
            pictureBoxvittoria.Hide();
            labelinseriscinome.Hide();
            textBoxNome.Hide();
            buttonNome.Hide();
            label_round.Hide();
            ragequitbutton.Hide();
            label_preparazione.Hide();
            pictureBoxattesa.Hide();
            for (int i = 0; i < Carte.Length; i++)
            {
                this.Controls.Remove(Carte[i]);
            }
        }

        private void timer_lasciacarte_Tick(object sender, EventArgs e)
        {
            Carte[P].Image = Image.FromFile("background.png");
            Carte[S].Image = Image.FromFile("background.png");
            Selezione = false;
            SelezioneDue = false;
            P = -1;
            S = -1;
            timer_lasciacarte.Stop();
        }
        private void timer_indovinato_Tick(object sender, EventArgs e)
        {
            Carte[P].Hide();
            Carte[S].Hide();
            Selezione = false;
            SelezioneDue = false;
            P = -1;
            S = -1;
            Indovinate++;
            this.checkroundover();
            timer_indovinato.Stop();
        }

        private void ragequitbutton_Click(object sender, EventArgs e)
        {
            this.stopgame();
        }

        private void timer_caricamento_Tick(object sender, EventArgs e)
        {
                timer_caricamento.Stop();
                label_preparazione.Hide();
                pictureBoxattesa.Hide();
                timer_caricamento.Interval = 1000 * Round+1;
                timer_tempo.Start();
        }

        private void timer_tempo_Tick(object sender, EventArgs e)
        {
            Tempo++;
            if (Tempo >= 10)
            {
                Tempo = 0;
                TempoS++;
            }
            if (TempoS >= 60)
            {
                TempoS = 0;
                TempoM++;
            }
            if (TempoM >= 60)
            {
                TempoM = 0;
                TempoO++;
            }
            TempoTrascorso.Text = TempoO.ToString() + ":" + TempoM.ToString() + ":" + TempoS.ToString() + "," + Tempo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Carte.Length; i++)
            {
                Carte[i].Image = Image.FromFile("" + (SlotCarte[i] + Kit).ToString() + ".png");
            }
        }

        private void buttonNome_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text != "")
            {
                if (textBoxNome.Text.Length >= 3)
                {
                    if (textBoxNome.Text.Contains("/")== false && textBoxNome.Text.Contains(":") == false && textBoxNome.Text.Contains(",") == false)
                    {
                        Nome = textBoxNome.Text;
                        this.ClassificaAdd();
                        this.stopgame();
                    }
                    else
                    {
                        MessageBox.Show("Caratteri inseriti non validi");
                    }
                }
                else
                {
                    MessageBox.Show("Minimo 3 caratteri");
                }
            }
            else
            {
                MessageBox.Show("Impossibile impostare nome vuoto");
            }
        }
    }
}
