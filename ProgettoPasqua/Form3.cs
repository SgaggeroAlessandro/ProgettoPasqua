using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
namespace ProgettoPasqua
{
    public enum Giostre
    {
        GIOSTRA,
        Oblivion = 15,
        Apex = 20,
        Enigma = 30,
        Raptor = 10,
        Shock = 15,
        Hydra = 10
    }
    public struct Persona
    {
        public string nome;
        public Giostre giostra;
        public Persona(string no, Giostre g)
        {
            nome = no;
            giostra = g;
        }
    }
   
    public partial class Form3 : Form
    {
        List<Persona> persone = new List<Persona>();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbGiostre.DataSource = Enum.GetValues(typeof(Giostre));

            this.BackColor = Color.FromArgb(20, 18, 45);

            label1.ForeColor = Color.FromArgb(255, 234, 0);
            label1.Font = new Font("Impact", 24f, FontStyle.Bold);

            label2.ForeColor = Color.FromArgb(200, 200, 220);
            label2.Font = new Font("Segoe UI", 11f);
            
            label4.ForeColor = Color.FromArgb(200, 200, 220);
            label4.Font = new Font("Segoe UI", 11f);

            btnAggiungi.BackColor = Color.FromArgb(255, 0, 102);
            btnAggiungi.ForeColor = Color.White;

            btnStart.BackColor = Color.FromArgb(255, 0, 102);
            btnStart.ForeColor = Color.White;

            
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Scrivi il nome della nuova persona da aggiungere in coda");
                return;
            }
            if(cmbGiostre.SelectedIndex == 0)
            {
                MessageBox.Show("Seleziona una giostra valida.");
                return;
            }
            Giostre giostra = (Giostre)cmbGiostre.SelectedItem;
            Persona persona = new Persona(nome, giostra);
            persone.Add(persona);
            string personaString = $"Nome: {persona.nome}, Giostra: {persona.giostra}";
            lbPersone.Items.Add(personaString);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string giostra = Interaction.InputBox("Inserisci il nome della giostra da avviare", "Avvio Giostra", "");

            for(int i = 0; i < cmbGiostre.Items.Count; i++)
            {
                if (cmbGiostre.Items[i].ToString().ToLower() == giostra.ToLower())
                {
                    string giostraCorretta = cmbGiostre.Items[i].ToString();
                    bool avvio = AvvioGiostra(giostraCorretta);
                    if(avvio == true)
                    {
                        MessageBox.Show($"La giostra {giostraCorretta} è stata avviata");
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"Non ci sono persone in coda per {giostraCorretta}");
                        return;
                    }
                   
                }
            }
            MessageBox.Show("Giostra non trovata. Assicurati di inserire un nome valido.");
        }
        private bool AvvioGiostra(string giostra)
        {
            int c = 0;
           
            Giostre g = (Giostre)Enum.Parse(typeof(Giostre), giostra);
            int capienza = (int)g;

            for (int i = 0; i < persone.Count; i++)
            {
                if (persone[i].giostra.ToString() == giostra && c < capienza)
                {
                    persone.RemoveAt(i);
                    i--; // per non saltare la persona successiva dopo la rimozione
                    c++;
                }
            }
            if (c > 0)
            {
                lbPersone.Items.Clear();
                for (int i = 0; i < persone.Count; i++)
                {
                    string personaString = $"Nome: {persone[i].nome}, Giostra: {persone[i].giostra}";
                    lbPersone.Items.Add(personaString);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.KeyChar = (Char)0;
            }
        }
    }
}
