using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TahminApp
{
    public partial class Form1 : Form
    {
        public int tahminEdilecekSayi;
        public int ustAralikDegeri;
        public int altAralikDegeri;
        public Form1()
        {
            InitializeComponent();
        }


        private void sayiBelirle_Click(object sender, EventArgs e)
        {
            string ustaralik = ustAralik.Text;
            string altaralik = altAralik.Text;

            ustAralikDegeri = Convert.ToInt32(ustaralik);
            altAralikDegeri = Convert.ToInt32(altaralik);
            
            Random rnd = new Random();
            tahminEdilecekSayi = rnd.Next(altAralikDegeri, ustAralikDegeri + 1);
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string tahminGirdisi = tahmin.Text;
            int tahminDegeri = Convert.ToInt32(tahminGirdisi);

            if (tahminEdilecekSayi == tahminDegeri)
            {
                tahminDestek.Text = "Doğru Tahmin";
                pnl.BackColor = Color.Chartreuse;
            }
            else if (tahminEdilecekSayi != tahminDegeri)
            {
                if (tahminDegeri > tahminEdilecekSayi)
                {
                    pnl.BackColor = Color.Orange;

                    if (tahminDegeri > ustAralikDegeri)
                    {
                        tahminDestek.Text = "";
                        Thread.Sleep(1000);
                        tahminDestek.Text = "Aralık Değerinizin Üstünde Değer Girdiniz";
                        pnl.BackColor = Color.Red;
                    }
                    else
                    {
                        tahminDestek.Text = "";
                        Thread.Sleep(1000);
                        tahminDestek.Text = "Aşağı";
                    }
                }
                else if (tahminDegeri < tahminEdilecekSayi)
                {
                    pnl.BackColor = Color.DarkOrange;

                    if (tahminDegeri < altAralikDegeri)
                    {
                        tahminDestek.Text = "";
                        Thread.Sleep(1000);
                        tahminDestek.Text = "Aralık Değerinizin Altında Değer Gridiniz";
                        pnl.BackColor = Color.Red;
                    }
                    else
                    {
                        tahminDestek.Text = "";
                        Thread.Sleep(1000);
                        tahminDestek.Text = "Yukarı";
                    }
                }
                
            }
        }
    }
}