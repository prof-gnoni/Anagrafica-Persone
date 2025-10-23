namespace Anagrafica_Persone
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCognome = new TextBox();
            lstPersone = new ListBox();
            lblCognome = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            dtpDataNascita = new DateTimePicker();
            lblDataNascita = new Label();
            txtRicerca = new TextBox();
            lblRicerca = new Label();
            btnAggiungi = new Button();
            btnModifica = new Button();
            btnCancella = new Button();
            btnPulisciCampi = new Button();
            btnRicerca = new Button();
            menuStrip1 = new MenuStrip();
            filToolStripMenuItem = new ToolStripMenuItem();
            menuSalva = new ToolStripMenuItem();
            menuCarica = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            menuEsci = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(11, 66);
            txtCognome.Margin = new Padding(2, 1, 2, 1);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(202, 23);
            txtCognome.TabIndex = 2;
            // 
            // lstPersone
            // 
            lstPersone.FormattingEnabled = true;
            lstPersone.ItemHeight = 15;
            lstPersone.Location = new Point(436, 50);
            lstPersone.Margin = new Padding(2, 1, 2, 1);
            lstPersone.Name = "lstPersone";
            lstPersone.Size = new Size(306, 334);
            lstPersone.TabIndex = 14;
            lstPersone.SelectedIndexChanged += lstPersone_SelectedIndexChanged;
            // 
            // lblCognome
            // 
            lblCognome.AutoSize = true;
            lblCognome.Location = new Point(11, 50);
            lblCognome.Margin = new Padding(2, 0, 2, 0);
            lblCognome.Name = "lblCognome";
            lblCognome.Size = new Size(60, 15);
            lblCognome.TabIndex = 1;
            lblCognome.Text = "&Cognome";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(11, 92);
            lblNome.Margin = new Padding(2, 0, 2, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "&Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(11, 108);
            txtNome.Margin = new Padding(2, 1, 2, 1);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(202, 23);
            txtNome.TabIndex = 4;
            // 
            // dtpDataNascita
            // 
            dtpDataNascita.Location = new Point(11, 152);
            dtpDataNascita.Margin = new Padding(2, 1, 2, 1);
            dtpDataNascita.Name = "dtpDataNascita";
            dtpDataNascita.Size = new Size(202, 23);
            dtpDataNascita.TabIndex = 6;
            // 
            // lblDataNascita
            // 
            lblDataNascita.AutoSize = true;
            lblDataNascita.Location = new Point(11, 136);
            lblDataNascita.Margin = new Padding(2, 0, 2, 0);
            lblDataNascita.Name = "lblDataNascita";
            lblDataNascita.Size = new Size(84, 15);
            lblDataNascita.TabIndex = 5;
            lblDataNascita.Text = "Data di nascita";
            // 
            // txtRicerca
            // 
            txtRicerca.Location = new Point(11, 200);
            txtRicerca.Margin = new Padding(2, 1, 2, 1);
            txtRicerca.Name = "txtRicerca";
            txtRicerca.Size = new Size(202, 23);
            txtRicerca.TabIndex = 8;
            // 
            // lblRicerca
            // 
            lblRicerca.AutoSize = true;
            lblRicerca.Location = new Point(11, 184);
            lblRicerca.Margin = new Padding(2, 0, 2, 0);
            lblRicerca.Name = "lblRicerca";
            lblRicerca.Size = new Size(45, 15);
            lblRicerca.TabIndex = 7;
            lblRicerca.Text = "Ricerca";
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(11, 249);
            btnAggiungi.Margin = new Padding(2, 1, 2, 1);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(75, 23);
            btnAggiungi.TabIndex = 10;
            btnAggiungi.Text = "Aggiungi";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(89, 249);
            btnModifica.Margin = new Padding(2, 1, 2, 1);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(75, 23);
            btnModifica.TabIndex = 11;
            btnModifica.Text = "Modifica";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // btnCancella
            // 
            btnCancella.Location = new Point(167, 249);
            btnCancella.Margin = new Padding(2, 1, 2, 1);
            btnCancella.Name = "btnCancella";
            btnCancella.Size = new Size(75, 23);
            btnCancella.TabIndex = 12;
            btnCancella.Text = "Cancella";
            btnCancella.UseVisualStyleBackColor = true;
            btnCancella.Click += btnCancella_Click;
            // 
            // btnPulisciCampi
            // 
            btnPulisciCampi.Location = new Point(245, 249);
            btnPulisciCampi.Margin = new Padding(2, 1, 2, 1);
            btnPulisciCampi.Name = "btnPulisciCampi";
            btnPulisciCampi.Size = new Size(88, 23);
            btnPulisciCampi.TabIndex = 13;
            btnPulisciCampi.Text = "Pulisci Campi";
            btnPulisciCampi.UseVisualStyleBackColor = true;
            btnPulisciCampi.Click += btnPulisciCampi_Click;
            // 
            // btnRicerca
            // 
            btnRicerca.Location = new Point(219, 200);
            btnRicerca.Margin = new Padding(2, 1, 2, 1);
            btnRicerca.Name = "btnRicerca";
            btnRicerca.Size = new Size(75, 23);
            btnRicerca.TabIndex = 9;
            btnRicerca.Text = "Ricerca";
            btnRicerca.UseVisualStyleBackColor = true;
            btnRicerca.Click += btnRicerca_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { filToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(746, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // filToolStripMenuItem
            // 
            filToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuSalva, menuCarica, toolStripMenuItem1, menuEsci });
            filToolStripMenuItem.Name = "filToolStripMenuItem";
            filToolStripMenuItem.Size = new Size(37, 22);
            filToolStripMenuItem.Text = "File";
            // 
            // menuSalva
            // 
            menuSalva.Name = "menuSalva";
            menuSalva.Size = new Size(167, 22);
            menuSalva.Text = "Salva con nome...";
            menuSalva.Click += menuSalva_Click;
            // 
            // menuCarica
            // 
            menuCarica.Name = "menuCarica";
            menuCarica.Size = new Size(167, 22);
            menuCarica.Text = "Carica...";
            menuCarica.Click += menuCarica_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(164, 6);
            // 
            // menuEsci
            // 
            menuEsci.Name = "menuEsci";
            menuEsci.Size = new Size(167, 22);
            menuEsci.Text = "Esci";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 389);
            Controls.Add(btnRicerca);
            Controls.Add(btnPulisciCampi);
            Controls.Add(btnCancella);
            Controls.Add(btnModifica);
            Controls.Add(btnAggiungi);
            Controls.Add(lblRicerca);
            Controls.Add(txtRicerca);
            Controls.Add(lblDataNascita);
            Controls.Add(dtpDataNascita);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCognome);
            Controls.Add(lstPersone);
            Controls.Add(txtCognome);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 1, 2, 1);
            Name = "mainForm";
            Text = "Anagrafica";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCognome;
        private ListBox lstPersone;
        private Label lblCognome;
        private Label lblNome;
        private TextBox txtNome;
        private DateTimePicker dtpDataNascita;
        private Label lblDataNascita;
        private TextBox txtRicerca;
        private Label lblRicerca;
        private Button btnAggiungi;
        private Button btnModifica;
        private Button btnCancella;
        private Button btnPulisciCampi;
        private Button btnRicerca;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem filToolStripMenuItem;
        private ToolStripMenuItem menuSalva;
        private ToolStripMenuItem menuCarica;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem menuEsci;
    }
}
