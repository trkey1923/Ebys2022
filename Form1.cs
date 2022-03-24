using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace Ebys2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("kernel32.dll")]
        public static extern uint SetThreadExecutionState(uint flag);//Uyku moduna Geçmesini engellemeyi tanımladık.

        string KullanıcıAdı = System.Windows.Forms.SystemInformation.UserName;
        bool Devam = true;
        int TekrarSayısı = 10;
        int Hız = 100;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.GreenYellow;
            this.BackColor = Color.GreenYellow;
            SetThreadExecutionState(0x80000043);///Bilgisayarın uyku moduna geçmesini engelliyoruz. Eğer tekrar izin vermek istersek SetThreadExecutionState(0x80000000); proğramın farklı yerinde bu komutu çağırın.

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
           
            Devam = true;
            btnDurdur.Focus();
            Metod metod = new Metod();
            for (int i = 0; i < TekrarSayısı; i++)
            {
                if (Devam)
                {
                    metod.islemYap(Hız);
                    WIN32.SagMouseClick(this.Location.X + 205, this.Location.Y + 75);
                    Text = "Çalışıyor :" + i.ToString() + "/" + TekrarSayısı.ToString();
                }
                else
                {
                    Text = "İptal Edildi";
                    break;
                }

                //WIN32.SagMouseClick(55, 420);
                //btnDurdur.Focus();               
                Application.DoEvents();
                System.Threading.Thread.Sleep(1500);
            }








        }

        private void btnTempSil_Click(object sender, EventArgs e)
        {
            string[] klasorler = Directory.GetDirectories(@"C:\Users\" + KullanıcıAdı + @"\AppData\Local\Temp\");
            //klasörler dizisinin uzunluğuna kadar git
            for (int j = 0; j < klasorler.Length; j++)
            {
                try
                {
                    Directory.Delete(klasorler[j], true);
                }
                catch (Exception)
                {


                }

            }
            string[] dosyalar = System.IO.Directory.GetFiles(@"C:\Users\" + KullanıcıAdı + @"\AppData\Local\Temp\");
            for (int j = 0; j < dosyalar.Length; j++)
            {
                try
                {
                    File.Delete(dosyalar[j]);
                }
                catch (Exception)
                {


                }

            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            Devam = false;
            Text = "Durduruldu";
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devam = false;
            Text = "Durduruldu.";
        }

        private void fareninKonumunuBulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);

            MessageBox.Show("Farenin konumu" + WIN32.GetCursorPosition());
        }

        private void ebysAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Process.Start("explorer.exe", System.IO.Path.GetDirectoryName(@"C:\Users\" + KullanıcıAdı + @"\AppData\Local\Temp\"));
                Process p = Process.Start(@"C:\Users\" + KullanıcıAdı + @"\Desktop\EBYS.appref-ms");

            }
            catch (Exception)
            {

                MessageBox.Show("Sisteminizde EBYS Yüklü değil yada sistem belirtilen yolu bulamıyor!", "Sistem belirtilen yolu bulamıyor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tempSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] klasorler = Directory.GetDirectories(@"C:\Users\" + KullanıcıAdı + @"\AppData\Local\Temp\");
            //klasörler dizisinin uzunluğuna kadar git
            for (int j = 0; j < klasorler.Length; j++)
            {
                try
                {
                    Directory.Delete(klasorler[j], true);
                }
                catch (Exception)
                {


                }

            }
            string[] dosyalar = System.IO.Directory.GetFiles(@"C:\Users\" + KullanıcıAdı + @"\AppData\Local\Temp\");
            for (int j = 0; j < dosyalar.Length; j++)
            {
                try
                {
                    File.Delete(dosyalar[j]);
                }
                catch (Exception)
                {


                }
            }
        }

        private void tempAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", System.IO.Path.GetDirectoryName(@"C:\Users\" + KullanıcıAdı + @"\AppData\Local\Temp\"));
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TekrarSayısı = 100;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TekrarSayısı = 1000;
        }

        private void sonsuzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekrarSayısı = 10000;
        }

        private void milisaniyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hız = 20;
        }

        private void milisaniyeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hız = 50;
        }

        private void milisaniyeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Hız = 100;
        }

        private void saniyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hız = 1000;
        }
    }

    }
