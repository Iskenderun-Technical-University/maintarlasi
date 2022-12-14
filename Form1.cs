using System.Collections;
using System.Runtime.CompilerServices;

namespace MayinTarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ArrayList mayinlar = new ArrayList();
        private void kolayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayinlar.Clear();
            tableLayoutPanel1.Controls.Clear();
            gpuan = 0;
            int OMayin = 15;
            int OTarla = 81;
            tableLayoutPanel1.ColumnCount = 9;
            label2.Text = "Mayýn: " + OMayin;
            label3.Text = "Boyut: " + tableLayoutPanel1.ColumnCount + "x" + tableLayoutPanel1.ColumnCount;
            label4.Text = "kare: " + tableLayoutPanel1.ColumnCount * tableLayoutPanel1.ColumnCount;
            Random rast = new Random();
            int sayi = 0;
            for (int i = 0; i < OMayin; i++)
            {
            uret:
                sayi = rast.Next(0, OTarla);
                if (mayinlar.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    mayinlar.Add(sayi);
                }
            }
            for (int i = 0; i < OTarla; i++)
            {
                Button button = new Button();
                button.Size = new Size(50, 50);
                if (mayinlar.Contains(i))
                {
                    button.Tag = -1;
                }
                else
                {
                    button.Tag = rast.Next(1, 20);
                }
                button.Click += Button_Click;
                tableLayoutPanel1.Controls.Add(button);

            }
            this.Size= new Size(tableLayoutPanel1.ColumnCount *50+25,tableLayoutPanel1.ColumnCount*50+110);
        }
        int gpuan = 0;
        private void Button_Click(object? sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            if (tiklanan.Text == "")
            {
                if (int.Parse(tiklanan.Tag.ToString()) == -1)
                {
                    tiklanan.BackgroundImage = Image.FromFile("mayin.jpg");
                    tiklanan.BackColor = Color.Red;
                    for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                    {

                        if (int.Parse(tableLayoutPanel1.Controls[i].Tag.ToString()) == -1)
                        {
                            tableLayoutPanel1.Controls[i].BackgroundImage = Image.FromFile("mayin.jpg");
                            tableLayoutPanel1.Controls[i].Enabled = false;
                        }
                        else
                        {
                            tableLayoutPanel1.Controls[i].Text = tableLayoutPanel1.Controls[i].Tag.ToString();
                        }
                    }
                }
                else
                {


                    gpuan += int.Parse(tiklanan.Tag.ToString());
                    tiklanan.Text = tiklanan.Tag.ToString();
                    label1.Text = "puan: " + gpuan;
                    tiklanan.Enabled = false;

                }
            }
        }

        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayinlar.Clear();
            tableLayoutPanel1.Controls.Clear();
            gpuan = 0;
            int OMayin = 35;
            int OTarla =100;
            tableLayoutPanel1.ColumnCount = 10;
            label2.Text = "Mayýn: " + OMayin;
            label3.Text = "Boyut: " + tableLayoutPanel1.ColumnCount + "x" + tableLayoutPanel1.ColumnCount;
            label4.Text = "kare: " + tableLayoutPanel1.ColumnCount * tableLayoutPanel1.ColumnCount;
            Random rast = new Random();
            int sayi = 0;
            for (int i = 0; i < OMayin; i++)
            {
            uret:
                sayi = rast.Next(0, OTarla);
                if (mayinlar.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    mayinlar.Add(sayi);
                }
            }
            for (int i = 0; i < OTarla; i++)
            {
                Button button = new Button();
                button.Size = new Size(50, 50);
                if (mayinlar.Contains(i))
                {
                    button.Tag = -1;
                }
                else
                {
                    button.Tag = rast.Next(1, 20);
                }
                button.Click += Button_Click;
                tableLayoutPanel1.Controls.Add(button);

            }
            this.Size = new Size(tableLayoutPanel1.ColumnCount * 50 + 25, tableLayoutPanel1.ColumnCount * 50 + 110);
        }

        private void zorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayinlar.Clear();
            tableLayoutPanel1.Controls.Clear();
            gpuan = 0;
            int OMayin = 55;
            int OTarla = 121;
            tableLayoutPanel1.ColumnCount = 11;
            label2.Text = "Mayýn: " + OMayin;
            label3.Text = "Boyut: " + tableLayoutPanel1.ColumnCount + "x" + tableLayoutPanel1.ColumnCount;
            label4.Text = "kare: " + tableLayoutPanel1.ColumnCount * tableLayoutPanel1.ColumnCount;
            Random rast = new Random();
            int sayi = 0;
            for (int i = 0; i < OMayin; i++)
            {
            uret:
                sayi = rast.Next(0, OTarla);
                if (mayinlar.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    mayinlar.Add(sayi);
                }
            }
            for (int i = 0; i < OTarla; i++)
            {
                Button button = new Button();
                button.Size = new Size(50, 50);
                if (mayinlar.Contains(i))
                {
                    button.Tag = -1;
                }
                else
                {
                    button.Tag = rast.Next(1, 20);
                }
                button.Click += Button_Click;
                tableLayoutPanel1.Controls.Add(button);

            }
            this.Size = new Size(tableLayoutPanel1.ColumnCount * 50 + 25, tableLayoutPanel1.ColumnCount * 50 + 110);
        }

        private void oyunToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}