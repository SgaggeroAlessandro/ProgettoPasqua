using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProgettoPasqua
{
    public enum Attrazioni
    {
        ATTRAZIONE,
        Specchi = 10,
        Illusioni = 12,
        Stelle = 15
    }
    public struct Attrazione
    {
        public string nome;
        public Attrazioni attrazione;
        public Attrazione(string no, Attrazioni a)
        {
            nome = no;
            attrazione = a;
        }
    }
    public partial class Form4 : Form
    {
        int persone = 0;
        int personeSpecchi = 0;
        int personeIllusioni = 0;
        int personeStelle = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cmbAttrazione.DataSource = Enum.GetValues(typeof(Attrazioni));
            CaricaCSV();
            lblPersone.Text = "Persone: " + persone.ToString();


            this.BackColor = Color.FromArgb(20, 18, 45);

            label1.ForeColor = Color.FromArgb(255, 234, 0);
            label1.Font = new Font("Impact", 24f, FontStyle.Bold);

            label2.ForeColor = Color.FromArgb(200, 200, 220);
            label2.Font = new Font("Segoe UI", 11f);

            label3.ForeColor = Color.FromArgb(200, 200, 220);
            label3.Font = new Font("Segoe UI", 11f);

            lblPersone.ForeColor = Color.FromArgb(200, 200, 220);
            lblPersone.Font = new Font("Segoe UI", 11f);

            btnAggiungi.BackColor = Color.FromArgb(255, 0, 102);
            btnAggiungi.ForeColor = Color.White;

            btnUscire.BackColor = Color.FromArgb(255, 0, 102);
            btnUscire.ForeColor = Color.White;
        }
        private void CaricaCSV()
        {
            if (File.Exists("attrazioni.csv"))
            {
                string[] righe = File.ReadAllLines("attrazioni.csv");
                for (int i = 1; i < righe.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(righe[i])) continue;

                    string[] campi = righe[i].Split(';');
                    if (campi.Length == 2)
                    {
                        if (Enum.TryParse(campi[1], out Attrazioni a))
                        {
                            if (a == Attrazioni.Specchi)
                            {
                                personeSpecchi++;
                            }
                            else if (a == Attrazioni.Illusioni)
                            {
                                personeIllusioni++;
                            }
                            else if (a == Attrazioni.Stelle)
                            {
                                personeStelle++;
                            }
                            persone++;
                        }
                    }
                }
                lblPersone.Text = "Persone: " + persone.ToString();
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.KeyChar = (Char)0;
            }
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Scrivi il nome della nuova persona da aggiungere");
                return;
            }
            if (cmbAttrazione.SelectedIndex == 0)
            {
                MessageBox.Show("Seleziona un'attrazione valida.");
                return;
            }

            Attrazioni attrazione = (Attrazioni)cmbAttrazione.SelectedItem;
            int capienza = (int)attrazione;
            int presenti = 0;

            if (attrazione == Attrazioni.Specchi)
            {
                presenti = personeSpecchi;
            }
            else if (attrazione == Attrazioni.Illusioni)
            {
                presenti = personeIllusioni;
            }
            else if (attrazione == Attrazioni.Stelle)
            {
                presenti = personeStelle;
            }
            if (presenti >= capienza)
            {
                MessageBox.Show("Capienza massima raggiunta per questa attrazione.");
                return;
            }


            if (attrazione == Attrazioni.Specchi)
            {
                personeSpecchi++;
            }
            else if (attrazione == Attrazioni.Illusioni)
            {
                personeIllusioni++;
            }
            else if (attrazione == Attrazioni.Stelle)
            {
                personeStelle++;

            }
            if (!File.Exists("attrazioni.csv"))
            {
                File.AppendAllText("attrazioni.csv", "Numero;Nome;Tipo;Data\r\n");
            }
            string rigaCSV = $"{nome};{attrazione}";
            File.AppendAllText("attrazioni.csv", rigaCSV + "\r\n");
            MessageBox.Show("Persona aggiunta");
            txtNome.Clear();
            cmbAttrazione.SelectedIndex = 0;
            persone++;
            lblPersone.Text = "Persone: " + persone.ToString();
        }

        private void btnUscire_Click(object sender, EventArgs e)
        {
            string attrazione = Interaction.InputBox("Inserisci il nome dell'attrazione tra specchi, illusioni o stelle", "Uscita Attrazione", "");
            string nString = Interaction.InputBox("Quante persone escono?", "Uscita", "1");
            if (!int.TryParse(nString, out int n) || n <= 0)
            {
                MessageBox.Show("Inserisci un numero valido.");
                return;
            }
            for (int i = 0; i < cmbAttrazione.Items.Count; i++)
            {
                if (cmbAttrazione.Items[i].ToString().ToLower() == attrazione.ToLower())
                {
                    string attrazioneCorretta = cmbAttrazione.Items[i].ToString();
                    Attrazioni a = (Attrazioni)Enum.Parse(typeof(Attrazioni), attrazioneCorretta);

                    if (a == Attrazioni.Specchi)
                    {
                        if (n > personeSpecchi)
                        {
                            MessageBox.Show("Non ci sono abbastanza persone.");
                            return;
                        }
                        personeSpecchi -= n;
                    }
                    else if (a == Attrazioni.Illusioni)
                    {
                        if (n > personeIllusioni)
                        {
                            MessageBox.Show("Non ci sono abbastanza persone.");
                            return;
                        }
                        personeIllusioni -= n;
                    }
                    else if (a == Attrazioni.Stelle)
                    {
                        if (n > personeStelle)
                        {
                            MessageBox.Show("Non ci sono abbastanza persone.");
                            return;
                        }
                        personeStelle -= n;
                    }
                    else
                    {
                        MessageBox.Show("Non ci sono persone in questa attrazione.");
                        return;
                    }

                    persone -= n;
                    if (File.Exists("attrazioni.csv"))
                    {
                        string[] righe = File.ReadAllLines("attrazioni.csv");
                        List<string> righeAggiornate = new List<string>();
                        righeAggiornate.Add(righe[0]); 
                        int rimossi = 0;
                        for (int j = 1; j < righe.Length; j++)
                        {
                            if (string.IsNullOrWhiteSpace(righe[j]))
                            {
                                continue;
                            }
                            string[] campi = righe[j].Split(';');
                            if (campi.Length == 2 && campi[1] == attrazioneCorretta && rimossi < n)
                            {
                                rimossi++; 
                            }
                            else
                            {
                                righeAggiornate.Add(righe[j]);
                            }
                        }
                        File.WriteAllLines("attrazioni.csv", righeAggiornate);
                        lblPersone.Text = "Persone: " + persone.ToString();
                        MessageBox.Show($"{n} persone sono uscite da {attrazioneCorretta}");
                        return;
                    }
                }
                MessageBox.Show("Attrazione non trovata.");
            }
        }
    }
}
