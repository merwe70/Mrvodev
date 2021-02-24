using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _186206019_Merve_Dürül
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ahmet\OneDrive\Masaüstü\isYeri.accdb");
        OleDbDataAdapter calisan, bolum;
        DataSet yeni;
        OleDbCommand komut;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource=yeni.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut = new OleDbCommand("select*from market");
            // Form2.MdiParent - this;
            baglan.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            Form2 cocuk = new Form2();
            cocuk.Show();
            try
            {
               

            }
            catch (Exception)
            {

                throw;
            }
            
        }
        
    }
}
