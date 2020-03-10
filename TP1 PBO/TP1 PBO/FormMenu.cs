using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_PBO
{
    public partial class FormMenu : Form
    {
        Barang[] bar = new Barang[5];
        public FormMenu()
        {
            InitializeComponent();
            comboBoxJenis.Items.Add("Elektronik");
            comboBoxJenis.Items.Add("Baju");
            comboBoxJenis.Items.Add("Makanan");

            comboBoxHarga.Items.Add("100rb - 200rb");
            comboBoxHarga.Items.Add("200rb - 500rb");
            comboBoxHarga.Items.Add("500rb - 1jt");

            bar[0] = new Barang("Jaket Tactical", 350000, "Baju");
            bar[1] = new Barang("ASUS ROG Zepyhrus", 1000000, "Elektronik");
            bar[2] = new Barang("French Fries Baygon", 100000, "Makanan");
            bar[3] = new Barang("Money Duplicator Machine", 1000000, "Elektronik");
            bar[4] = new Barang("USB Killer", 900000, "Elektronik");

            showAllBarang();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void buttonBeli_Click(object sender, EventArgs e)
        {
            comboBoxHarga.Show();
            comboBoxJenis.Show();
            buttonCari.Show();
            labelSemua.Show();
            labelHasil.Hide();
            buttonBack.Hide();
            showAllBarang();
        }

        private void buttonKatalog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tokopedia.com");
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxHarga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelNama_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxJenis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            string jenis = comboBoxJenis.Text;
            string harga = comboBoxHarga.Text;

            haidu();
            flowLayoutPanelBarang.Controls.Clear();
            hasilcari(jenis, harga);
        }

        private void panelHasil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
           
        }

        private void labelHasil_Click(object sender, EventArgs e)
        {

        }

        public void haidu()
        {
            comboBoxHarga.Hide();
            comboBoxJenis.Hide();
            buttonCari.Hide();
            labelSemua.Hide();
            labelHasil.Show();
            buttonBack.Show();
        }

        private void flowLayoutPanelBarang_Paint(object sender, PaintEventArgs e)
        {

        }

        public void showAllBarang()
        {
            int i = 0;
            buttonBack.Hide();
            labelHasil.Hide();
            flowLayoutPanelBarang.Controls.Clear();
            foreach (var item in bar)
            {
                flowLayoutPanelBarang.FlowDirection = FlowDirection.TopDown;
                PictureBox p = addNewPicture(i);
                Label n = addNewLabel(item.barang);
                Label h = addNewLabel(Convert.ToString(item.harga));
                Button butt = addNewButton();
                flowLayoutPanelBarang.Controls.Add(p);
                flowLayoutPanelBarang.Controls.Add(n);
                flowLayoutPanelBarang.Controls.Add(h);
                flowLayoutPanelBarang.Controls.Add(butt);
                i++;
            }
        }

        PictureBox addNewPicture(int something)
        {
            PictureBox p = new PictureBox();
            p.ImageLocation = "../../assets/" + something + ".jpg";
            p.Size = new Size(50, 50);

            return p;
        }

        Label addNewLabel(string something)
        {
            Label l = new Label();
            l.Name = "Item"+something;
            l.Text = something;
            l.ForeColor = Color.Black;
            l.Font = new Font("Agency FB", 12, FontStyle.Bold);
            l.TextAlign = ContentAlignment.BottomCenter;
            l.Margin = new Padding(5);

            return l;
        }

        Button addNewButton()
        {
            Button butt = new Button();
            butt.Text = "Beli";
            return butt;
        }

        public void hasilcari(string jenis, string harga)
        {
            int i = 0;
            foreach (var item in bar)
            {
                if(item.jenis == jenis)
                {
                    if(harga == "100rb - 200rb")
                    {
                        if(item.harga >= 100000 && item.harga <= 200000)
                        {
                            flowLayoutPanelBarang.FlowDirection = FlowDirection.TopDown;
                            PictureBox p = addNewPicture(i);
                            Label n = addNewLabel(item.barang);
                            Label h = addNewLabel(Convert.ToString(item.harga));
                            Button butt = addNewButton();
                            flowLayoutPanelBarang.Controls.Add(p);
                            flowLayoutPanelBarang.Controls.Add(n);
                            flowLayoutPanelBarang.Controls.Add(h);
                            flowLayoutPanelBarang.Controls.Add(butt);
                            i++;
                        }
                    }else if(harga == "200rb - 500rb")
                    {
                        if(item.harga >= 200000 && item.harga <= 500000)
                        {
                            flowLayoutPanelBarang.FlowDirection = FlowDirection.TopDown;
                            PictureBox p = addNewPicture(i);
                            Label n = addNewLabel(item.barang);
                            Label h = addNewLabel(Convert.ToString(item.harga));
                            Button butt = addNewButton();
                            flowLayoutPanelBarang.Controls.Add(p);
                            flowLayoutPanelBarang.Controls.Add(n);
                            flowLayoutPanelBarang.Controls.Add(h);
                            flowLayoutPanelBarang.Controls.Add(butt);
                            i++;
                        }
                    }
                    else if (harga == "500rb - 1jt")
                    {
                        if(item.harga >= 500000 && item.harga <= 1000000)
                        {
                            flowLayoutPanelBarang.FlowDirection = FlowDirection.TopDown;
                            PictureBox p = addNewPicture(i);
                            Label n = addNewLabel(item.barang);
                            Label h = addNewLabel(Convert.ToString(item.harga));
                            Button butt = addNewButton();
                            flowLayoutPanelBarang.Controls.Add(p);
                            flowLayoutPanelBarang.Controls.Add(n);
                            flowLayoutPanelBarang.Controls.Add(h);
                            flowLayoutPanelBarang.Controls.Add(butt);
                            i++;
                        }
                    }
                }
            }
        }

        private void labelBarangBarang_Click(object sender, EventArgs e)
        {

        }

        private void labelSemua_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            comboBoxHarga.Show();
            comboBoxJenis.Show();
            buttonCari.Show();
            labelSemua.Show();
            labelHasil.Hide();
            buttonBack.Hide();
            showAllBarang();
        }
    }
}