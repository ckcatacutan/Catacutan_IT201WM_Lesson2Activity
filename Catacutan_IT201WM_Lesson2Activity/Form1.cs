using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catacutan_IT201WM_Lesson2Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("BS Aeronautical Engineering");
            comboBox1.Items.Add("BS Civil Engineering");
            comboBox1.Items.Add("BS Computer Engineering");
            comboBox1.Items.Add("BS Electrical Engineering");
            comboBox1.Items.Add("BS Electronics Engineering");
            comboBox1.Items.Add("BS Industrial Engineering");
            comboBox1.Items.Add("BS Mechanical Engineering");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lecUnits = 0, labUnits = 0;
            double.TryParse(textBox4.Text, out lecUnits); 
            double.TryParse(textBox5.Text, out labUnits); 

            double totalUnits = lecUnits + labUnits;
            textBox14.Text = totalUnits.ToString(); 

            int rowId = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowId];

            row.Cells[0].Value = textBox2.Text;  
            row.Cells[1].Value = textBox5.Text;  
            row.Cells[2].Value = textBox7.Text;  
            row.Cells[3].Value = textBox8.Text;  
            row.Cells[4].Value = textBox9.Text; 
            row.Cells[5].Value = totalUnits.ToString();
            row.Cells[6].Value = textBox10.Text;  
            row.Cells[7].Value = textBox11.Text;  

            MessageBox.Show("Data successfully transferred to the list!", "Success");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
               
                if (ctrl is ComboBox) ((ComboBox)ctrl).SelectedIndex = -1;
                if (ctrl is PictureBox) ((PictureBox)ctrl).Image = null;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
