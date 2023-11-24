using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSemaforo
{
    public partial class Form1 : Form
    {
        private Leds l;
        public Form1()
        {

            InitializeComponent();
            l = new Leds();
            atualizaInterface();
        }

        private void atualizaInterface()
        {
            label1.Text = l.getEstado().ToString();
            btnLed1.Text = (l.getEstado(1) ? "OFF" : "ON");
            btnLed2.Text = (l.getEstado(2) ? "OFF" : "ON");
            btnLed3.Text = (l.getEstado(3) ? "OFF" : "ON");
            btnLed4.Text = (l.getEstado(4) ? "OFF" : "ON");
            btnLed5.Text = (l.getEstado(5) ? "OFF" : "ON");
            btnLed6.Text = (l.getEstado(6) ? "OFF" : "ON");
            btnLed7.Text = (l.getEstado(7) ? "OFF" : "ON");
            btnLed8.Text = (l.getEstado(8) ? "OFF" : "ON");
            pictureBox3.Image = (l.getEstado(1)) ? ProjetoSemaforo.Properties.Resources.verd :
                  ProjetoSemaforo.Properties.Resources.verm1;
            pictureBox4.Image = (l.getEstado(2)) ? ProjetoSemaforo.Properties.Resources.verd :
                  ProjetoSemaforo.Properties.Resources.verm1;
            pictureBox5.Image = (l.getEstado(3)) ? ProjetoSemaforo.Properties.Resources.verd :
                  ProjetoSemaforo.Properties.Resources.verm1;
            pictureBox6.Image = (l.getEstado(4)) ? ProjetoSemaforo.Properties.Resources.verd :
                  ProjetoSemaforo.Properties.Resources.verm1;
            pictureBox7.Image = (l.getEstado(5)) ? ProjetoSemaforo.Properties.Resources.verd :
                  ProjetoSemaforo.Properties.Resources.verm1;
            pictureBox8.Image = (l.getEstado(6)) ? ProjetoSemaforo.Properties.Resources.verd :
                  ProjetoSemaforo.Properties.Resources.verm1;
            pictureBox9.Image = (l.getEstado(7)) ? ProjetoSemaforo.Properties.Resources.verd :
                  ProjetoSemaforo.Properties.Resources.verm1;
            pictureBox1.Image = (l.getEstado(8)) ? ProjetoSemaforo.Properties.Resources.verd :
                  ProjetoSemaforo.Properties.Resources.verm1;
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qualLed;

            qualLed = int.Parse(((Button)sender).Tag.ToString());

            if (l.getEstado(qualLed))
                l.apagar(qualLed);
            else
                l.acender(qualLed);
            atualizaInterface();


        }

        private void btnLed1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }
    }
}