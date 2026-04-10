using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.IO;
using System.Windows.Forms;
namespace ProgettoPasqua
{
    public enum TipoBiglietto
    {
        TIPO,
        Ridotto,
        Base,
        Famiglia,
        Premium
    }
    public struct Biglietto
    {
        public int numero;
        public string nome;
        public TipoBiglietto Tipo;
        public string data;

        public Biglietto(int nu, string no, TipoBiglietto tipo, string d)
        {
            numero = nu;
            nome = no;
            Tipo = tipo;
            data = d;
        }
    }
    public partial class Form2 : Form
    {
        int nBiglietto = 0001;
        List<Biglietto> biglietti = new List<Biglietto>();
       
        public Form2()
        {
            InitializeComponent();

            

        }
        private void btnSalva_Click(object sender, EventArgs e)
        {

            if (cmbTipo.SelectedIndex == 0)
            {
                MessageBox.Show("Seleziona un tipo di biglietto valido.");
                return;
            }
            TipoBiglietto tipo = (TipoBiglietto)cmbTipo.SelectedItem;
            string nome = txtNome.Text;
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Inserisci un nome valido.");
                return;
            }
            string data = txtData.Text;
            if (!DateTime.TryParse(data, out DateTime dataPrenotazione))
            {
                MessageBox.Show("Non hai scritto la data in modo corretto, deve essere scritta così: giorno/mese/anno (ad esempio 1 Gennaio 2027.");
                return;
            }
            if (dataPrenotazione.Date < DateTime.Today)
            {
                MessageBox.Show("La data inserita è già passata. Inserisci un'altra data.");
                return;
            }
            Biglietto biglietto = new Biglietto(nBiglietto, nome, (TipoBiglietto)cmbTipo.SelectedItem, data);
            biglietti.Add(biglietto);
            string n = "";
            if (nBiglietto < 10)
            {
                n = "000" + nBiglietto.ToString();
            }
            else if (nBiglietto < 100)
            {
                n = "00" + nBiglietto.ToString();
            }
            else if (nBiglietto < 1000)
            {
                n = "0" + nBiglietto.ToString();
                
            }else if(nBiglietto < 10000)
            {
                n = nBiglietto.ToString();
                if (nBiglietto == 9999)
                {
                    nBiglietto = 0;
                }
            }
            string bigliettoString = $"Numero biglietto: {n}, Nome visitatore: {nome}, Tipo biglietto: {tipo}, Data prenotazione: {data}";
            lbBiglietti.Items.Add(bigliettoString);
            nBiglietto++;
            txtNome.Clear();
            txtData.Clear();
            cmbTipo.SelectedIndex = 0;
            if (!File.Exists("biglietti.csv"))
            {
                File.AppendAllText("biglietti.csv", "Numero;Nome;Tipo;Data\r\n");
            }
            string rigaCSV = $"{biglietto.numero};{biglietto.nome};{biglietto.Tipo};{biglietto.data}";
            File.AppendAllText("biglietti.csv", rigaCSV + "\r\n");
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.KeyChar = (Char)0;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbTipo.DataSource = Enum.GetValues(typeof(TipoBiglietto));
            
            
                CaricaCSV();

            this.BackColor = Color.FromArgb(20, 18, 45);

            label2.ForeColor = Color.FromArgb(255, 234, 0);
            label2.Font = new Font("Impact", 24f, FontStyle.Bold);

            label1.ForeColor = Color.FromArgb(200, 200, 220);
            label1.Font = new Font("Segoe UI", 11f);
            label3.ForeColor = Color.FromArgb(200, 200, 220);
            label3.Font = new Font("Segoe UI", 11f);
            label4.ForeColor = Color.FromArgb(200, 200, 220);
            label4.Font = new Font("Segoe UI", 11f);

            btnCerca.BackColor = Color.FromArgb(255, 0, 102);
            btnCerca.ForeColor = Color.White;

            btnElimina.BackColor = Color.FromArgb(255, 0, 102);
            btnElimina.ForeColor = Color.White;

            btnSalva.BackColor = Color.FromArgb(255, 0, 102);
            btnSalva.ForeColor = Color.White;
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            string bigliettoCercato = Interaction.InputBox("Inserisci il numero del biglietto da cercare:", "Cerca biglietto", "");

            if (int.TryParse(bigliettoCercato, out int numeroCercato))
            {
                for (int i = 0; i < biglietti.Count; i++)
                {
                    if (biglietti[i].numero == numeroCercato)
                    {
                        MessageBox.Show($"Biglietto trovato: Numero biglietto: {biglietti[i].numero}, Nome visitatore: {biglietti[i].nome}, Tipo biglietto: {biglietti[i].Tipo}, Data prenotazione: {biglietti[i].data}");
                        return;
                    }
                }
                MessageBox.Show("Biglietto non trovato.");
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (lbBiglietti.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona un biglietto da eliminare.");
                return;
            }

            string bigliettoElim = lbBiglietti.SelectedItem.ToString();
            int selectedIndex = lbBiglietti.SelectedIndex;

            for (int i = 0; i < biglietti.Count; i++)
            {
                string n = "";
                if (biglietti[i].numero < 10)
                {
                    n = "000" + biglietti[i].numero.ToString();
                }
                else if (biglietti[i].numero < 100)
                {
                    n = "00" + biglietti[i].numero.ToString();
                }
                else 
                {
                    n = "0" + biglietti[i].numero.ToString();
                }
                string bigliettoString = $"Numero biglietto: {n}, Nome visitatore: {biglietti[i].nome}, Tipo biglietto: {biglietti[i].Tipo}, Data prenotazione: {biglietti[i].data}";

                if (bigliettoString == bigliettoElim)
                {
                    biglietti.RemoveAt(i);
                    lbBiglietti.Items.RemoveAt(selectedIndex);

                   
                    List<string> bAggiornati = new List<string>();
                    bAggiornati.Add("Numero;Nome;Tipo;Data");
                    for (int j = 0; j < biglietti.Count; j++)
                    {
                        bAggiornati.Add($"{biglietti[j].numero};{biglietti[j].nome};{biglietti[j].Tipo};{biglietti[j].data}");
                    }
                    File.WriteAllLines("biglietti.csv", bAggiornati);

                    MessageBox.Show("Biglietto eliminato.");
                    return;
                }
            }
        }

        private void CaricaCSV()
        {
            string percorso = "biglietti.csv";

            if (!File.Exists(percorso)){
                return;
            }
            string[] righe = File.ReadAllLines(percorso);

            if (righe.Length == 0 || righe[0] != "Numero;Nome;Tipo;Data")
            {
                List<string> righeAggiornate = new List<string>();
                righeAggiornate.Add("Numero;Nome;Tipo;Data");
                righeAggiornate.AddRange(righe);
                File.WriteAllLines(percorso, righeAggiornate);
                righe = File.ReadAllLines(percorso);
            }
            for (int i = 1; i < righe.Length; i++)
            {
                if(string.IsNullOrWhiteSpace(righe[i]))
                {
                    continue;
                }
                string[] campi = righe[i].Split(';');
                if (campi.Length == 4)
                {
                    if (int.TryParse(campi[0], out int numero) && Enum.TryParse(campi[2], out TipoBiglietto tipo))
                    {
                        Biglietto biglietto = new Biglietto(numero, campi[1], tipo, campi[3]);
                        biglietti.Add(biglietto);
                        string n = "";
                        if (biglietto.numero < 10)
                        {
                            n = "000" + biglietto.numero.ToString();
                        }
                        else if (biglietto.numero < 100)
                        {
                            n = "00" + biglietto.numero.ToString();
                        }
                        else
                        {
                            n = "0" + biglietto.numero.ToString();
                        }
                        string bigliettoString = $"Numero biglietto: {n}, Nome visitatore: {biglietto.nome}, Tipo biglietto: {biglietto.Tipo}, Data prenotazione: {biglietto.data}";
                        lbBiglietti.Items.Add(bigliettoString);
                    }
                }
                else
                {
                    continue;
                }
                
            }
            if (biglietti.Count > 0)
            {
                nBiglietto = biglietti[biglietti.Count - 1].numero + 1; //riparte dal numero successivo dell'ultimo biglietto salvato
            }
        }
    }
}