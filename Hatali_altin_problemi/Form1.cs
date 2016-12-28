using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatali_altin_problemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btn_bul_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_altin_sayisi.Text == "")
                {
                    MessageBox.Show("Boş değer girmeyiniz!");
                }

                else
                {
                    int altinsayisi = 0;
                    altinsayisi = Convert.ToInt32(txt_altin_sayisi.Text);
                    lst_altin.Items.Clear();

                    int[] altinlar = new int[altinsayisi];
                    Random rdm = new Random();

                    int hatali_altin = rdm.Next(0, 1000);
                    if (hatali_altin == 100)
                    {
                        hatali_altin = rdm.Next(0, 1000);
                    }

                    int hatali_index = rdm.Next(altinsayisi - 1);

                    for (int i = 0; i < altinsayisi; i++)
                    {
                        if (i == hatali_index)
                        {
                            altinlar[i] = hatali_altin;
                        }
                        else
                        {
                            altinlar[i] = 100;
                        }
                    }
                    int index = 1;
                    foreach (int item in altinlar)
                    {
                        lst_altin.Items.Add(index + "->" + item);
                        index++;
                    }

                    BinaryS binaryS = new BinaryS();

                    int sayac = 0;

                    int bulunanhatali = binaryS.Search(altinlar, altinsayisi, 0, hatali_index, sayac);


                    label2.Text = (1 + bulunanhatali).ToString();

                    lbl_tarti.Text = binaryS.sayacyolla().ToString();
                    lbl_süre.Text = binaryS.sureyolla().ToString();
                    txt_altin_sayisi.Text = "";
                }  
            }
            catch (Exception hata)
            {
                MessageBox.Show("Terazinin tartabileceğinden daha fazla altın girildi!", hata.Message);
                
                
            }
           
        }
        private void txt_altin_sayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                txt_altin_sayisi.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

     
    }
}
