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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.but1 = this.button1; // передаем ссылку на кнопку в форму Form2
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DBEntities DB = new DBEntities())
            {
      
                List<admin> adminlist = new List<admin>();
                adminlist = DB.admin.ToList();
                foreach (var item in adminlist) {
              
                if(item.login== textBox1.Text)
                    {
                        MessageBox.Show("УСПЕШНО");
                    }
                }

            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.admin". При необходимости она может быть перемещена или удалена.
            this.adminTableAdapter.Fill(this.dBDataSet.admin);

        }
    }
}
