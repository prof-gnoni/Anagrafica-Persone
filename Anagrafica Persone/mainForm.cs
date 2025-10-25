using System.IO; // Per leggere e scrivere file
using System.Text.Json; // Per la serializzazione JSON
using System.Text; // Serve per lo StringBuilder (costruire il file CSV)
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
    public partial class mainForm : Form
    {
        private List<Persona> anagrafica = new List<Persona>();

        public mainForm()
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
            txtCognome.Focus();
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

        // (Questo codice va incollato dentro la classe Form1)

        // --- EVENTO PER SALVARE ---
        private /*async*/ void menuSalvaJSON_Click(object sender, EventArgs e)
        {
            // 1. Apri una finestra di dialogo per "Salvare"
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "File JSON (*.json)|*.json|Tutti i file (*.*)|*.*";
            dialog.Title = "Salva anagrafica";

            // 2. Se l'utente clicca "OK"
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // 3. Prendi il percorso del file scelto
                string percorsoFile = dialog.FileName;

                try
                {
                    // 4. Converti la nostra lista 'anagrafica' in una stringa JSON
                    // (WriteIndented = true la formatta in modo leggibile)
                    var opzioniJson = new JsonSerializerOptions { WriteIndented = true };
                    string jsonString = JsonSerializer.Serialize(anagrafica, opzioniJson);

                    // 5. Salva la stringa sul file (in modo asincrono)
                    // await File.WriteAllTextAsync(percorsoFile, jsonString);
                    File.WriteAllText(percorsoFile, jsonString);

                    MessageBox.Show("Dati salvati con successo!", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Gestisci eventuali errori di salvataggio
                    MessageBox.Show($"Errore durante il salvataggio: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- EVENTO PER CARICARE ---
        private /*async*/ void menuCaricaJSON_Click(object sender, EventArgs e)
        {
            // 1. Apri una finestra di dialogo per "Aprire"
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "File JSON (*.json)|*.json|Tutti i file (*.*)|*.*";
            dialog.Title = "Carica anagrafica";

            // 2. Se l'utente clicca "OK"
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // 3. Prendi il percorso del file scelto
                string percorsoFile = dialog.FileName;

                // È FONDAMENTALE usare try...catch per il caricamento,
                // il file potrebbe essere corrotto o non esistere!
                try
                {
                    // 4. Leggi tutto il testo dal file (in modo asincrono)
                    //string jsonString = await File.ReadAllTextAsync(percorsoFile);
                    string jsonString = File.ReadAllText(percorsoFile);

                    // 5. Converti la stringa JSON di nuovo in una List<Persona>
                    List<Persona> listaCaricata = JsonSerializer.Deserialize<List<Persona>>(jsonString);

                    // 6. Sostituisci l'anagrafica attuale con quella caricata
                    anagrafica = listaCaricata;

                    // 7. Aggiorna la ListBox e pulisci i campi
                    AggiornaListBox(anagrafica);
                    PulisciCampi();

                    MessageBox.Show("Dati caricati con successo!", "Caricamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Gestisci errori di caricamento (file non trovato, JSON non valido, ecc.)
                    MessageBox.Show($"Errore durante il caricamento: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private /*async*/ void menuCaricaCSV_Click(object sender, EventArgs e)
        {
            // 1. Apri la finestra di dialogo per aprire
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "File CSV (*.csv)|*.csv|Tutti i file (*.*)|*.*";
            dialog.Title = "Carica anagrafica da CSV";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string percorsoFile = dialog.FileName;
                List<Persona> listaCaricata = new List<Persona>();

                try
                {
                    // 2. Leggi tutte le righe dal file
                    //string[] righe = await File.ReadAllLinesAsync(percorsoFile);
                    string[] righe = File.ReadAllLines(percorsoFile);

                    // 3. Itera sulle righe, *saltando la prima riga (header)*
                    // Partiamo da i = 1
                    for (int i = 1; i < righe.Length; i++)
                    {
                        string riga = righe[i];
                        if (string.IsNullOrWhiteSpace(riga)) continue; // Salta righe vuote

                        // 4. Dividi la riga usando il separatore ';'
                        string[] campi = riga.Split(';');

                        // 5. Controlla che la riga sia ben formata
                        if (campi.Length == 4)
                        {
                            try
                            {
                                // 6. Ricrea l'oggetto Persona
                                Guid id = Guid.Parse(campi[0]);
                                string nome = campi[1];
                                string cognome = campi[2];
                                DateTime dataNascita = DateTime.Parse(campi[3]); // Funziona grazie al formato "o"

                                // 7. Usa il NUOVO costruttore per preservare l'ID
                                listaCaricata.Add(new Persona(id, nome, cognome, dataNascita));
                            }
                            catch (Exception ex)
                            {
                                // Se una riga è malformata, la saltiamo e andiamo avanti
                                Console.WriteLine($"Errore nel parsing della riga CSV: {ex.Message}");
                            }
                        }
                    }

                    // 8. Sostituisci l'anagrafica
                    anagrafica = listaCaricata;
                    AggiornaListBox(anagrafica);
                    PulisciCampi();

                    MessageBox.Show($"Dati CSV caricati con successo. Trovate {anagrafica.Count} persone.", "Caricamento CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante il caricamento CSV: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private /*async*/ void menuSalvaCSV_Click(object sender, EventArgs e)
        {
            // 1. Apri la finestra di dialogo per salvare
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "File CSV (*.csv)|*.csv|Tutti i file (*.*)|*.*";
            dialog.Title = "Salva anagrafica in CSV";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string percorsoFile = dialog.FileName;
                try
                {
                    StringBuilder sb = new StringBuilder();
                    // 2. Scrivi l'header
                    sb.AppendLine("Id;Nome;Cognome;DataNascita");
                    // 3. Scrivi ogni persona in una riga
                    foreach (var persona in anagrafica)
                    {
                        // Usa il formato "o" per DataNascita per garantire la precisione
                        sb.AppendLine($"{persona.Id};{persona.Nome};{persona.Cognome};{persona.DataNascita.ToString("o")}");
                    }
                    // 4. Salva il contenuto nel file
                    //await File.WriteAllTextAsync(percorsoFile, sb.ToString());
                    File.WriteAllText(percorsoFile, sb.ToString());
                    MessageBox.Show("Dati salvati in CSV con successo!", "Salvataggio CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante il salvataggio CSV: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- EVENTO PER CARICARE DA CSV ---
        private /*async*/ void menuCaricaCsv_Click(object sender, EventArgs e)
        {
            // 1. Apri la finestra di dialogo per aprire
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "File CSV (*.csv)|*.csv|Tutti i file (*.*)|*.*";
            dialog.Title = "Carica anagrafica da CSV";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string percorsoFile = dialog.FileName;
                List<Persona> listaCaricata = new List<Persona>();

                try
                {
                    // 2. Leggi tutte le righe dal file
                    //string[] righe = await File.ReadAllLinesAsync(percorsoFile);
                    string[] righe = File.ReadAllLines(percorsoFile);

                    // 3. Itera sulle righe, *saltando la prima riga (header)*
                    // Partiamo da i = 1
                    for (int i = 1; i < righe.Length; i++)
                    {
                        string riga = righe[i];
                        if (string.IsNullOrWhiteSpace(riga)) continue; // Salta righe vuote

                        // 4. Dividi la riga usando il separatore ';'
                        string[] campi = riga.Split(';');

                        // 5. Controlla che la riga sia ben formata
                        if (campi.Length == 4)
                        {
                            try
                            {
                                // 6. Ricrea l'oggetto Persona
                                Guid id = Guid.Parse(campi[0]);
                                string nome = campi[1];
                                string cognome = campi[2];
                                DateTime dataNascita = DateTime.Parse(campi[3]); // Funziona grazie al formato "o"

                                // 7. Usa il NUOVO costruttore per preservare l'ID
                                listaCaricata.Add(new Persona(id, nome, cognome, dataNascita));
                            }
                            catch (Exception ex)
                            {
                                // Se una riga è malformata, la saltiamo e andiamo avanti
                                Console.WriteLine($"Errore nel parsing della riga CSV: {ex.Message}");
                            }
                        }
                    }

                    // 8. Sostituisci l'anagrafica
                    anagrafica = listaCaricata;
                    AggiornaListBox(anagrafica);
                    PulisciCampi();

                    MessageBox.Show($"Dati CSV caricati con successo. Trovate {anagrafica.Count} persone.", "Caricamento CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante il caricamento CSV: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- EVENTO PER USCIRE ---
        private void menuEsci_Click(object sender, EventArgs e)
        {
            // Chiude l'applicazione
            this.Close();
        }
    }
    #endregion
}
