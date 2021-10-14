using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEmytity
{
    public partial class Form2 : Form
    {
        public Button but1; // эта переменная будет содержать ссылку на кнопку button1 из формы Form1
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            ad.login = textBox1.Text;
            ad.pass = textBox2.Text;
            ad.name = textBox3.Text;
            ad.lastname = textBox4.Text;
            ad.tel = textBox5.Text;
            using (DBEntities DB = new DBEntities())
            {
                DB.admin.Add(ad);
                DB.SaveChanges();
                List<admin> adminlist = new List<admin>();
                adminlist = DB.admin.ToList();
            }
        }
    }
}
