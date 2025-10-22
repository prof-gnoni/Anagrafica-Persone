using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Anagrafica_Persone
{
    public partial class Form1 : Form
    {
        private List<Persona> anagrafica = new List<Persona>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            anagrafica.Add(new Persona("Mario", "Rossi", new DateTime(1990, 5, 15)));
            anagrafica.Add(new Persona("Luca", "Bianchi", new DateTime(1985, 11, 22)));
            anagrafica.Add(new Persona("Anna", "Verdi", new DateTime(2001, 1, 30)));

            AggiornaListBox(anagrafica);
            txtCognome.Focus();
        }

        #region Metodi Helper

        private void AggiornaListBox(List<Persona> lista)
        {
            lstPersone.DataSource = null;
            lstPersone.DataSource = lista;
        }

        private void PulisciCampi()
        {
            txtNome.Text = "";
            txtCognome.Text = "";
            dtpDataNascita.Value = DateTime.Now;
            txtRicerca.Text = "";
            lstPersone.SelectedIndex = -1;
        }

        #endregion

        #region Eventi Controlli UI

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtCognome.Text))
            {
                MessageBox.Show("Nome e Cognome sono obbligatori.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime dataSelezionata = dtpDataNascita.Value;
            var nuovaPersona = new Persona(txtNome.Text, txtCognome.Text, dataSelezionata);

            anagrafica.Add(nuovaPersona);
            AggiornaListBox(anagrafica);
            PulisciCampi();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Persona pSelezionata = lstPersone.SelectedItem as Persona;

            if (pSelezionata == null)
            {
                MessageBox.Show("Seleziona una persona da modificare.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtCognome.Text))
            {
                MessageBox.Show("Nome e Cognome non possono essere vuoti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pSelezionata.Nome = txtNome.Text;
            pSelezionata.Cognome = txtCognome.Text;
            pSelezionata.DataNascita = dtpDataNascita.Value;

            AggiornaListBox(anagrafica);
            PulisciCampi();
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
            Persona pSelezionata = lstPersone.SelectedItem as Persona;

            if (pSelezionata == null)
            {
                MessageBox.Show("Seleziona una persona da cancellare.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var conferma = MessageBox.Show($"Sei sicuro di voler eliminare {pSelezionata}?",
                                           "Conferma Eliminazione",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

            if (conferma == DialogResult.Yes)
            {
                anagrafica.Remove(pSelezionata);
                AggiornaListBox(anagrafica);
                PulisciCampi();
            }
        }

        private void btnPulisciCampi_Click(object sender, EventArgs e)
        {
            AggiornaListBox(anagrafica);
            PulisciCampi();
            txtCognome.Focus();

        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            string termineRicerca = txtRicerca.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(termineRicerca))
            {
                AggiornaListBox(anagrafica);
                return;
            }

            List<Persona> risultati = anagrafica
                .Where(p => p.Nome.ToLower().Contains(termineRicerca) ||
                            p.Cognome.ToLower().Contains(termineRicerca))
                .ToList();

            AggiornaListBox(risultati);
        }

        private void lstPersone_SelectedIndexChanged(object sender, EventArgs e)
        {
            Persona pSelezionata = lstPersone.SelectedItem as Persona;

            if (pSelezionata != null)
            {
                txtNome.Text = pSelezionata.Nome;
                txtCognome.Text = pSelezionata.Cognome;
                dtpDataNascita.Value = pSelezionata.DataNascita;
            }
        }

        #endregion
    }
}
