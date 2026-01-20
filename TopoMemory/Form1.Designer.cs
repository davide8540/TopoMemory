namespace TopoMemory
{
    partial class TopoMemory
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopoMemory));
            this.Classifica = new System.Windows.Forms.ListBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_lasciacarte = new System.Windows.Forms.Timer(this.components);
            this.timer_indovinato = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxTitolo = new System.Windows.Forms.PictureBox();
            this.TempoTrascorso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_errori = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_round = new System.Windows.Forms.Label();
            this.ragequitbutton = new System.Windows.Forms.Button();
            this.label_preparazione = new System.Windows.Forms.Label();
            this.pictureBoxattesa = new System.Windows.Forms.PictureBox();
            this.timer_caricamento = new System.Windows.Forms.Timer(this.components);
            this.timer_tempo = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelinseriscinome = new System.Windows.Forms.Label();
            this.buttonNome = new System.Windows.Forms.Button();
            this.pictureBoxvittoria = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitolo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxattesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxvittoria)).BeginInit();
            this.SuspendLayout();
            // 
            // Classifica
            // 
            this.Classifica.BackColor = System.Drawing.Color.White;
            this.Classifica.FormattingEnabled = true;
            this.Classifica.Location = new System.Drawing.Point(472, 39);
            this.Classifica.Name = "Classifica";
            this.Classifica.Size = new System.Drawing.Size(300, 381);
            this.Classifica.TabIndex = 0;
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.White;
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(12, 426);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(760, 63);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "INIZIA";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CLASSIFICA";
            // 
            // timer_lasciacarte
            // 
            this.timer_lasciacarte.Interval = 1000;
            this.timer_lasciacarte.Tick += new System.EventHandler(this.timer_lasciacarte_Tick);
            // 
            // timer_indovinato
            // 
            this.timer_indovinato.Interval = 10;
            this.timer_indovinato.Tick += new System.EventHandler(this.timer_indovinato_Tick);
            // 
            // pictureBoxTitolo
            // 
            this.pictureBoxTitolo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTitolo.BackgroundImage")));
            this.pictureBoxTitolo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxTitolo.Name = "pictureBoxTitolo";
            this.pictureBoxTitolo.Size = new System.Drawing.Size(450, 400);
            this.pictureBoxTitolo.TabIndex = 6;
            this.pictureBoxTitolo.TabStop = false;
            // 
            // TempoTrascorso
            // 
            this.TempoTrascorso.AutoSize = true;
            this.TempoTrascorso.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempoTrascorso.Location = new System.Drawing.Point(500, 250);
            this.TempoTrascorso.Name = "TempoTrascorso";
            this.TempoTrascorso.Size = new System.Drawing.Size(132, 42);
            this.TempoTrascorso.TabIndex = 7;
            this.TempoTrascorso.Text = "0:0:0,0";
            this.TempoTrascorso.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "ERRORI:";
            this.label2.Visible = false;
            // 
            // label_errori
            // 
            this.label_errori.AutoSize = true;
            this.label_errori.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_errori.Location = new System.Drawing.Point(665, 460);
            this.label_errori.Name = "label_errori";
            this.label_errori.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_errori.Size = new System.Drawing.Size(39, 42);
            this.label_errori.TabIndex = 9;
            this.label_errori.Text = "0";
            this.label_errori.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "ROUND:";
            this.label3.Visible = false;
            // 
            // label_round
            // 
            this.label_round.AutoSize = true;
            this.label_round.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_round.Location = new System.Drawing.Point(660, 350);
            this.label_round.Name = "label_round";
            this.label_round.Size = new System.Drawing.Size(70, 42);
            this.label_round.TabIndex = 11;
            this.label_round.Text = "0/7";
            this.label_round.Visible = false;
            // 
            // ragequitbutton
            // 
            this.ragequitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ragequitbutton.Location = new System.Drawing.Point(688, 10);
            this.ragequitbutton.Name = "ragequitbutton";
            this.ragequitbutton.Size = new System.Drawing.Size(84, 23);
            this.ragequitbutton.TabIndex = 12;
            this.ragequitbutton.Text = "RAGE QUIT";
            this.ragequitbutton.UseVisualStyleBackColor = true;
            this.ragequitbutton.Visible = false;
            this.ragequitbutton.Click += new System.EventHandler(this.ragequitbutton_Click);
            // 
            // label_preparazione
            // 
            this.label_preparazione.AutoSize = true;
            this.label_preparazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_preparazione.Location = new System.Drawing.Point(31, 140);
            this.label_preparazione.Name = "label_preparazione";
            this.label_preparazione.Size = new System.Drawing.Size(413, 110);
            this.label_preparazione.TabIndex = 13;
            this.label_preparazione.Text = "PREPARAZIONE \r\nDEL MAZZO...";
            this.label_preparazione.Visible = false;
            // 
            // pictureBoxattesa
            // 
            this.pictureBoxattesa.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxattesa.Name = "pictureBoxattesa";
            this.pictureBoxattesa.Size = new System.Drawing.Size(790, 510);
            this.pictureBoxattesa.TabIndex = 14;
            this.pictureBoxattesa.TabStop = false;
            this.pictureBoxattesa.Visible = false;
            // 
            // timer_caricamento
            // 
            this.timer_caricamento.Interval = 1000;
            this.timer_caricamento.Tick += new System.EventHandler(this.timer_caricamento_Tick);
            // 
            // timer_tempo
            // 
            this.timer_tempo.Tick += new System.EventHandler(this.timer_tempo_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(515, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 50);
            this.button1.TabIndex = 15;
            this.button1.Text = "HACK BUTTON";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "(NOME/ERRORI/TEMPO)";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(12, 222);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(450, 80);
            this.textBoxNome.TabIndex = 17;
            this.textBoxNome.Visible = false;
            // 
            // labelinseriscinome
            // 
            this.labelinseriscinome.AutoSize = true;
            this.labelinseriscinome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinseriscinome.Location = new System.Drawing.Point(56, 164);
            this.labelinseriscinome.Name = "labelinseriscinome";
            this.labelinseriscinome.Size = new System.Drawing.Size(377, 55);
            this.labelinseriscinome.TabIndex = 18;
            this.labelinseriscinome.Text = "Inserisci Il Nome";
            this.labelinseriscinome.Visible = false;
            // 
            // buttonNome
            // 
            this.buttonNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNome.Location = new System.Drawing.Point(55, 338);
            this.buttonNome.Name = "buttonNome";
            this.buttonNome.Size = new System.Drawing.Size(378, 84);
            this.buttonNome.TabIndex = 19;
            this.buttonNome.Text = "Invio";
            this.buttonNome.UseVisualStyleBackColor = true;
            this.buttonNome.Visible = false;
            this.buttonNome.Click += new System.EventHandler(this.buttonNome_Click);
            // 
            // pictureBoxvittoria
            // 
            this.pictureBoxvittoria.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxvittoria.Image")));
            this.pictureBoxvittoria.Location = new System.Drawing.Point(12, 10);
            this.pictureBoxvittoria.Name = "pictureBoxvittoria";
            this.pictureBoxvittoria.Size = new System.Drawing.Size(450, 127);
            this.pictureBoxvittoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxvittoria.TabIndex = 20;
            this.pictureBoxvittoria.TabStop = false;
            this.pictureBoxvittoria.Visible = false;
            // 
            // TopoMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.pictureBoxvittoria);
            this.Controls.Add(this.buttonNome);
            this.Controls.Add(this.labelinseriscinome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.Classifica);
            this.Controls.Add(this.TempoTrascorso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_preparazione);
            this.Controls.Add(this.pictureBoxTitolo);
            this.Controls.Add(this.pictureBoxattesa);
            this.Controls.Add(this.ragequitbutton);
            this.Controls.Add(this.label_round);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_errori);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TopoMemory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TopoMemory";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitolo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxattesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxvittoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Classifica;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_lasciacarte;
        private System.Windows.Forms.Timer timer_indovinato;
        private System.Windows.Forms.PictureBox pictureBoxTitolo;
        private System.Windows.Forms.Label TempoTrascorso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_errori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_round;
        private System.Windows.Forms.Button ragequitbutton;
        private System.Windows.Forms.Label label_preparazione;
        private System.Windows.Forms.PictureBox pictureBoxattesa;
        private System.Windows.Forms.Timer timer_caricamento;
        private System.Windows.Forms.Timer timer_tempo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelinseriscinome;
        private System.Windows.Forms.Button buttonNome;
        private System.Windows.Forms.PictureBox pictureBoxvittoria;
    }
}

