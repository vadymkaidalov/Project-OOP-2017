using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.PL
{
    public partial class DeleteForm : Form
    {
        public double Quantity { get; private set; }

        private double amount;

        public DeleteForm(double amount, string measure)
        {
            InitializeComponent();
            this.amount = amount;
            measureLabel.Text = measure;
            Quantity = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Quantity = Double.Parse(quantityTextBox.Text);
            Close();
        }

        private void quantityTextBox_Validating(object sender, CancelEventArgs e)
        {
            
            double testNumber = -1;
            string textError = "Неправильный формат ввода.";
            try
            {
                testNumber = Double.Parse(quantityTextBox.Text);
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
            if (!e.Cancel)
            {
                textError = "Число должно быть не меньше нуля и не больше доступ. кол-ва.";
                if (testNumber < 0 || testNumber > amount) e.Cancel = true;
            }
            if (!e.Cancel)
            {
                textError = "Введите целое число.";
                int n;
                if (measureLabel.Text == "шт" && !int.TryParse(quantityTextBox.Text, out n))
                    e.Cancel = true;
            }
            if (e.Cancel)
            {
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(quantityTextBox, textError);
            }   
        }
    }
}
