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
            toolStripMenuItem1 = new ToolStripSeparator();
            menuCarica = new ToolStripMenuItem();
            menuCaricaJSON = new ToolStripMenuItem();
            menuCaricaCSV = new ToolStripMenuItem();
            menuSalva = new ToolStripMenuItem();
            menuSalvaJSON = new ToolStripMenuItem();
            menuSalvaCSV = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            menuEsci = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(22, 158);
            txtCognome.Margin = new Padding(4, 2, 4, 2);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(400, 42);
            txtCognome.TabIndex = 2;
            // 
            // lstPersone
            // 
            lstPersone.FormattingEnabled = true;
            lstPersone.ItemHeight = 36;
            lstPersone.Location = new Point(872, 120);
            lstPersone.Margin = new Padding(4, 2, 4, 2);
            lstPersone.Name = "lstPersone";
            lstPersone.Size = new Size(608, 796);
            lstPersone.TabIndex = 14;
            lstPersone.SelectedIndexChanged += lstPersone_SelectedIndexChanged;
            // 
            // lblCognome
            // 
            lblCognome.AutoSize = true;
            lblCognome.Location = new Point(22, 120);
            lblCognome.Margin = new Padding(4, 0, 4, 0);
            lblCognome.Name = "lblCognome";
            lblCognome.Size = new Size(127, 36);
            lblCognome.TabIndex = 1;
            lblCognome.Text = "&Cognome";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(22, 221);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(85, 36);
            lblNome.TabIndex = 3;
            lblNome.Text = "&Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(22, 259);
            txtNome.Margin = new Padding(4, 2, 4, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(400, 42);
            txtNome.TabIndex = 4;
            // 
            // dtpDataNascita
            // 
            dtpDataNascita.Location = new Point(22, 365);
            dtpDataNascita.Margin = new Padding(4, 2, 4, 2);
            dtpDataNascita.Name = "dtpDataNascita";
            dtpDataNascita.Size = new Size(400, 42);
            dtpDataNascita.TabIndex = 6;
            // 
            // lblDataNascita
            // 
            lblDataNascita.AutoSize = true;
            lblDataNascita.Location = new Point(22, 326);
            lblDataNascita.Margin = new Padding(4, 0, 4, 0);
            lblDataNascita.Name = "lblDataNascita";
            lblDataNascita.Size = new Size(182, 36);
            lblDataNascita.TabIndex = 5;
            lblDataNascita.Text = "Data di nascita";
            // 
            // txtRicerca
            // 
            txtRicerca.Location = new Point(22, 480);
            txtRicerca.Margin = new Padding(4, 2, 4, 2);
            txtRicerca.Name = "txtRicerca";
            txtRicerca.Size = new Size(400, 42);
            txtRicerca.TabIndex = 8;
            // 
            // lblRicerca
            // 
            lblRicerca.AutoSize = true;
            lblRicerca.Location = new Point(22, 442);
            lblRicerca.Margin = new Padding(4, 0, 4, 0);
            lblRicerca.Name = "lblRicerca";
            lblRicerca.Size = new Size(97, 36);
            lblRicerca.TabIndex = 7;
            lblRicerca.Text = "Ricerca";
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(22, 598);
            btnAggiungi.Margin = new Padding(4, 2, 4, 2);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(150, 55);
            btnAggiungi.TabIndex = 10;
            btnAggiungi.Text = "Aggiungi";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(178, 598);
            btnModifica.Margin = new Padding(4, 2, 4, 2);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(150, 55);
            btnModifica.TabIndex = 11;
            btnModifica.Text = "Modifica";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // btnCancella
            // 
            btnCancella.Location = new Point(334, 598);
            btnCancella.Margin = new Padding(4, 2, 4, 2);
            btnCancella.Name = "btnCancella";
            btnCancella.Size = new Size(150, 55);
            btnCancella.TabIndex = 12;
            btnCancella.Text = "Cancella";
            btnCancella.UseVisualStyleBackColor = true;
            btnCancella.Click += btnCancella_Click;
            // 
            // btnPulisciCampi
            // 
            btnPulisciCampi.Location = new Point(490, 598);
            btnPulisciCampi.Margin = new Padding(4, 2, 4, 2);
            btnPulisciCampi.Name = "btnPulisciCampi";
            btnPulisciCampi.Size = new Size(176, 55);
            btnPulisciCampi.TabIndex = 13;
            btnPulisciCampi.Text = "Pulisci Campi";
            btnPulisciCampi.UseVisualStyleBackColor = true;
            btnPulisciCampi.Click += btnPulisciCampi_Click;
            // 
            // btnRicerca
            // 
            btnRicerca.Location = new Point(438, 480);
            btnRicerca.Margin = new Padding(4, 2, 4, 2);
            btnRicerca.Name = "btnRicerca";
            btnRicerca.Size = new Size(150, 55);
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
            menuStrip1.Size = new Size(1492, 44);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // filToolStripMenuItem
            // 
            filToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, menuCarica, menuSalva, toolStripMenuItem2, menuEsci });
            filToolStripMenuItem.Name = "filToolStripMenuItem";
            filToolStripMenuItem.Size = new Size(74, 40);
            filToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(356, 6);
            // 
            // menuCarica
            // 
            menuCarica.DropDownItems.AddRange(new ToolStripItem[] { menuCaricaJSON, menuCaricaCSV });
            menuCarica.Name = "menuCarica";
            menuCarica.Size = new Size(359, 44);
            menuCarica.Text = "Carica";
            // 
            // menuCaricaJSON
            // 
            menuCaricaJSON.Name = "menuCaricaJSON";
            menuCaricaJSON.Size = new Size(340, 44);
            menuCaricaJSON.Text = "Carica da JSON...";
            menuCaricaJSON.Click += menuCaricaJSON_Click;
            // 
            // menuCaricaCSV
            // 
            menuCaricaCSV.Name = "menuCaricaCSV";
            menuCaricaCSV.Size = new Size(340, 44);
            menuCaricaCSV.Text = "Carica da CSV...";
            menuCaricaCSV.Click += menuCaricaCSV_Click;
            // 
            // menuSalva
            // 
            menuSalva.DropDownItems.AddRange(new ToolStripItem[] { menuSalvaJSON, menuSalvaCSV });
            menuSalva.Name = "menuSalva";
            menuSalva.Size = new Size(359, 44);
            menuSalva.Text = "Salva";
            // 
            // menuSalvaJSON
            // 
            menuSalvaJSON.Name = "menuSalvaJSON";
            menuSalvaJSON.Size = new Size(364, 44);
            menuSalvaJSON.Text = "Salva come JSON...";
            menuSalvaJSON.Click += menuSalvaJSON_Click;
            // 
            // menuSalvaCSV
            // 
            menuSalvaCSV.Name = "menuSalvaCSV";
            menuSalvaCSV.Size = new Size(364, 44);
            menuSalvaCSV.Text = "Salva come CSV...";
            menuSalvaCSV.Click += menuSalvaCSV_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(356, 6);
            // 
            // menuEsci
            // 
            menuEsci.Name = "menuEsci";
            menuEsci.Size = new Size(359, 44);
            menuEsci.Text = "Esci";
            menuEsci.Click += menuEsci_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 934);
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
            Margin = new Padding(4, 2, 4, 2);
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
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem menuCarica;
        private ToolStripMenuItem menuSalva;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem menuEsci;
        private ToolStripMenuItem menuSalvaJSON;
        private ToolStripMenuItem menuSalvaCSV;
        private ToolStripMenuItem menuCaricaJSON;
        private ToolStripMenuItem menuCaricaCSV;
    }
}
