using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.FileOk += (sender, e) =>
                {
                    try
                    {
                        using (var sr = new StreamReader(openFileDialog1.FileName))
                        {
                            list.Items.Clear();
                            while (!sr.EndOfStream)
                            {
                                list.Items.Add(sr.ReadLine());
                            }
                        }
                    }
                    catch (IOException)
                    {

                        MessageBox.Show("Hiba! Nem sikerult a betoltes!");
                    }
                };
        }

        private void txt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt1.Text.Trim() !="")
            {
                    list.Items.Add(txt1.Text);
                    txt1.Text = "";
            }
        }

        private void Mentes_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                using (var sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine("Név: "+txtNev.Text);
                    sw.WriteLine("Születési dátum: " + txtSzulDatum.Text);
                    if (rbtnFerfi.Checked == true)
                    {
                         sw.WriteLine("Nem: Férfi");
                    }
                    else
                    {
                        sw.WriteLine("Nem: Nő");
                    }

                    sw.WriteLine("Az összes hobbi: ");
                    foreach (var item in list.Items)
                    {
                        sw.WriteLine(item);
                    }
                    
                    for (int i = 0; i < list.SelectedItems.Count; i++)
                      {
                        string text = list.GetItemText(list.SelectedItem);
                        sw.WriteLine("A kedvenc hobbi: "+text);
                      }
                }
            }
            catch (IOException)
            {

                MessageBox.Show("Hiba, sikertelen mentés!");
            }
        }

        private void Betoltes_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            if (list.Items.Count==0 && txt1.Text != "")
            {
                list.Items.Add(txt1.Text);
                txt1.Text = "";
            }
            else
            {
                    if (list.Items.Contains(txt1.Text) == false && txt1.Text != "")
                    {
                        list.Items.Add(txt1.Text);
                        txt1.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Hiba, ilyen nevű hobbit már megadott vagy üresen hagyta a mezőt!");
                    }          
            }
        }
    }
}
