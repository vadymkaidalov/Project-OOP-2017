using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseProject2017.BLL;

namespace CourseProject2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shop shop = new Shop();
            bindingSource1.DataSource = shop.productList;
            dataGridView1.DataSource = shop.productList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
