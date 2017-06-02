using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CourseProject.PL
{
    public partial class DeleteForm : Form
    {
        private double amount;

        public DeleteForm(double amount, string measure)
        {
            InitializeComponent();
            this.amount = amount;
            measureLabel.Text = measure;
            Quantity = 0;
        }

        public double Quantity { get; private set; }
        
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Quantity = Double.Parse(quantityTextBox.Text);
            Close();
        }

        private void quantityTextBox_Validating(object sender, 
                                                CancelEventArgs e)
        {
            double testNumber = -1;
            string textError = StringConstant.IncorrectInput;

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
                textError = StringConstant.OutOfBounds;
                if (testNumber < 0 || testNumber > amount)
                {
                    e.Cancel = true;
                }   
            }
            if (!e.Cancel)
            {
                textError = StringConstant.NotInteger;
                int n;
                bool notInteger = !int.TryParse(quantityTextBox.Text, out n);

                if (measureLabel.Text == StringConstant.Item && notInteger)
                {
                    e.Cancel = true;
                }
            }
            if (e.Cancel)
            {
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(quantityTextBox, textError);
            }   
        }
    }
}
