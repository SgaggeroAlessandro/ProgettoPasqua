
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoPasqua
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApri1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void btnApri2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void btnApri3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            player.SoundLocation = "17a30494.wav";
            player.PlayLooping();

           
           
        }
    }
}
