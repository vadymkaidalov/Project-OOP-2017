using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CourseProject.PL
{
    public partial class EditForm : Form
    {
        public string InpName;
        public double InpAmount;
        public double InpPrice;
        public string InpMeasure;
        public string InpDeliveryDate;

        public EditForm()
        {
            InitializeComponent();
            measureComboBox.SelectedIndex = 0;
            deliveryDateTimePicker.Value = DateTime.Now;
            InpName = String.Empty;
            measureComboBox.SelectedValue = StringConstant.Item;
        }

        public EditForm(string name, string amount, string price, 
            string measure, string deliveryDate)
        {
            InitializeComponent();
            nameTextBox.Text = name;
            amountTextBox.Text = amount;
            priceTextBox.Text = price;
            if (measure == StringConstant.Item)
            {
                measureComboBox.SelectedIndex = 0;
            }
            else if (measure == StringConstant.Kilo)
            {
                measureComboBox.SelectedIndex = 1;
            }
            else
            {
                measureComboBox.SelectedIndex = 2;
            }
            deliveryDateTimePicker.Value = DateTime.ParseExact(
                deliveryDate, StringConstant.DateParseFormat,
                System.Globalization.CultureInfo.InvariantCulture);
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            string testName = nameTextBox.Text;
            string textError = StringConstant.ZeroStringLength;

            if (testName.Length < 1)
            {
                e.Cancel = true;
            }
            else if (testName.Length > 30)
            {
                e.Cancel = true;
                textError = StringConstant.TooLargeString;
            }

            if (e.Cancel)
            {
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(nameTextBox, textError);
            }
        }

        private void amountTextBox_Validating(object sender, CancelEventArgs e)
        {
            double testAmount = -1;
            string textError = StringConstant.IncorrectInput;
            try
            {
                testAmount = double.Parse(amountTextBox.Text);
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
            if (!e.Cancel)
            {
                if (testAmount < 0 || testAmount > 1000000)
                {
                    e.Cancel = true;
                    textError = StringConstant.OutOfBounds;
                }
            }
            if (!e.Cancel)
            {
                textError = StringConstant.NotInteger;
                int n;
                bool notInteger = !int.TryParse(amountTextBox.Text, out n);
                if (measureComboBox.SelectedIndex == 0 && notInteger)
                    e.Cancel = true;
            }
            if (e.Cancel)
            {
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(amountTextBox, textError);
            }
        }

        private void priceTextBox_Validating(object sender, CancelEventArgs e)
        {
            double testPrice = -1;
            string textError = StringConstant.IncorrectInput;

            try
            {
                testPrice = double.Parse(priceTextBox.Text);
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
            if (!e.Cancel)
            {
                int dotIndex = priceTextBox.Text.Length - 3;

                if (priceTextBox.Text.IndexOf('.') != dotIndex)
                {
                    e.Cancel = true;
                    textError = StringConstant.NotFinancialFormat;
                }
            }
            if (e.Cancel)
            {
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(priceTextBox, textError);
            }
        }

        private void measureComboBox_SelectedIndexChanged(object sender, 
            EventArgs e)
        {
            amountTextBox.Focus();
        }

        private void autoDateRadioButton_MouseClick(object sender, 
            MouseEventArgs e)
        {
            deliveryDateTimePicker.Value = DateTime.Now;
            deliveryDateTimePicker.Enabled = false;
            customDateRadioButton.Checked = false;
        }

        private void customDateRadioButton_MouseClick(object sender, 
            MouseEventArgs e)
        {
            deliveryDateTimePicker.Enabled = true;
            autoDateRadioButton.Checked = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string amountString = amountTextBox.Text;
            string priceString = priceTextBox.Text;

            if (name == String.Empty 
                || amountString == String.Empty 
                || priceString == String.Empty)
            {
                MessageBox.Show(StringConstant.NotAllFields);
                return;
            }
            InpName = name;
            InpPrice = double.Parse(priceString);
            InpAmount = double.Parse(amountString);
            InpMeasure = measureComboBox.Items[measureComboBox.SelectedIndex].ToString();
            InpDeliveryDate = deliveryDateTimePicker.Value.ToString(
                StringConstant.DateParseFormat);
            Close();
        }
    }
}
