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

namespace Alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string gercekSaat;
        string kurulanSaat;
        DateTime geciciAyarlananTarih;
        string gercekTarih;
        string ayarlananTarih;
        private void Form1_Load(object sender, EventArgs e)
        {
            timerSaat.Start();
            this.maskedTextBox1.Text = DateTime.Now.ToShortTimeString();           
           
        }

        private void timerSaat_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToLongTimeString();
            gercekSaat = DateTime.Now.ToShortTimeString();
            gercekTarih= DateTime.Now.ToString("dd/M/yyyy");

        }

        private void btnAlrmKur_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;  // formu göstermemek için aşağıya atıyor.         
            notifyIconAlarm.Visible = true;
            kurulanSaat = maskedTextBox1.Text;
            geciciAyarlananTarih = dTpTarih.Value;
            ayarlananTarih= geciciAyarlananTarih.ToString("dd/M/yyyy");
            label1.Text = geciciAyarlananTarih.ToString("dd/M/yyyy"); //sadece doğru olup olmadığını kontrol etmek için.
            timerAlarm.Start();
            
            MessageBox.Show("Alarm Saati " + kurulanSaat + " 'e kuruldu");
          
        }

        private void timerAlarm_Tick(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "C:\\Windows\\Media\\Alarm09.wav";

                
                if (kurulanSaat == gercekSaat && ayarlananTarih.ToString()==gercekTarih)
                {
                this.Opacity = 1;
                //timerAlarm.Stop();
                
               sp.Play();
               // sp.PlayLooping();  şarkı bitene kadar devam eder
                for (int i = 0; i < 500; i++)
                {
                    
                    pictureBox1.Left -= 5;
                    pictureBox1.Left += 5;
                    pictureBox1.Top -= 5;
                    pictureBox1.Top += 5;
                    this.Top -= 5;
                    this.Top += 5;
                    this.Height -= 5;
                    this.Height += 5;
                    
                    //vakit geldimi
                }
               

            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formhakkında frm = new Formhakkında();
            frm.Show();
        }

        private void btnAlarmDur_Click(object sender, EventArgs e)
        {
            timerAlarm.Stop();
        }
    }
}
