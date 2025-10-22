namespace Anagrafica_Persone
{
    partial class Form1
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
            label1 = new Label();
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
            SuspendLayout();
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(12, 129);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(400, 42);
            txtCognome.TabIndex = 0;
            // 
            // lstPersone
            // 
            lstPersone.FormattingEnabled = true;
            lstPersone.ItemHeight = 36;
            lstPersone.Location = new Point(872, 12);
            lstPersone.Name = "lstPersone";
            lstPersone.Size = new Size(607, 904);
            lstPersone.TabIndex = 9;
            lstPersone.SelectedIndexChanged += lstPersone_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 90);
            label1.Name = "label1";
            label1.Size = new Size(127, 36);
            label1.TabIndex = 2;
            label1.Text = "Cognome";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 191);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(85, 36);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 230);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(400, 42);
            txtNome.TabIndex = 1;
            // 
            // dtpDataNascita
            // 
            dtpDataNascita.Location = new Point(12, 336);
            dtpDataNascita.Name = "dtpDataNascita";
            dtpDataNascita.Size = new Size(400, 42);
            dtpDataNascita.TabIndex = 2;
            // 
            // lblDataNascita
            // 
            lblDataNascita.AutoSize = true;
            lblDataNascita.Location = new Point(12, 297);
            lblDataNascita.Name = "lblDataNascita";
            lblDataNascita.Size = new Size(182, 36);
            lblDataNascita.TabIndex = 6;
            lblDataNascita.Text = "Data di nascita";
            // 
            // txtRicerca
            // 
            txtRicerca.Location = new Point(12, 452);
            txtRicerca.Name = "txtRicerca";
            txtRicerca.Size = new Size(400, 42);
            txtRicerca.TabIndex = 3;
            // 
            // lblRicerca
            // 
            lblRicerca.AutoSize = true;
            lblRicerca.Location = new Point(12, 413);
            lblRicerca.Name = "lblRicerca";
            lblRicerca.Size = new Size(97, 36);
            lblRicerca.TabIndex = 8;
            lblRicerca.Text = "Ricerca";
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(12, 569);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(150, 46);
            btnAggiungi.TabIndex = 5;
            btnAggiungi.Text = "Aggiungi";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(168, 569);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(150, 46);
            btnModifica.TabIndex = 6;
            btnModifica.Text = "Modifica";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // btnCancella
            // 
            btnCancella.Location = new Point(324, 569);
            btnCancella.Name = "btnCancella";
            btnCancella.Size = new Size(150, 46);
            btnCancella.TabIndex = 7;
            btnCancella.Text = "Cancella";
            btnCancella.UseVisualStyleBackColor = true;
            btnCancella.Click += btnCancella_Click;
            // 
            // btnPulisciCampi
            // 
            btnPulisciCampi.Location = new Point(480, 569);
            btnPulisciCampi.Name = "btnPulisciCampi";
            btnPulisciCampi.Size = new Size(175, 46);
            btnPulisciCampi.TabIndex = 8;
            btnPulisciCampi.Text = "Pulisci Campi";
            btnPulisciCampi.UseVisualStyleBackColor = true;
            btnPulisciCampi.Click += btnPulisciCampi_Click;
            // 
            // btnRicerca
            // 
            btnRicerca.Location = new Point(427, 450);
            btnRicerca.Name = "btnRicerca";
            btnRicerca.Size = new Size(150, 46);
            btnRicerca.TabIndex = 4;
            btnRicerca.Text = "Ricerca";
            btnRicerca.UseVisualStyleBackColor = true;
            btnRicerca.Click += btnRicerca_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1491, 934);
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
            Controls.Add(label1);
            Controls.Add(lstPersone);
            Controls.Add(txtCognome);
            Name = "Form1";
            Text = "Anagrafica";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCognome;
        private ListBox lstPersone;
        private Label label1;
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
    }
}
