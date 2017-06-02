using CourseProject.BLL;
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
            InpName = "";
            measureComboBox.SelectedValue = "шт";
        }

        public EditForm(string name, string amount, string price, string measure, string deliveryDate)
        {
            InitializeComponent();
            nameTextBox.Text = name;
            amountTextBox.Text = amount;
            priceTextBox.Text = price;
            if (measure == "шт")
            {
                measureComboBox.SelectedIndex = 0;
            }
            else if (measure == "кг")
            {
                measureComboBox.SelectedIndex = 1;
            }
            else
            {
                measureComboBox.SelectedIndex = 2;
            }
            deliveryDateTimePicker.Value = DateTime.ParseExact(deliveryDate, "dd/MM/yyyy HH:mm:ss",
                            System.Globalization.CultureInfo.InvariantCulture);
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            string testName = nameTextBox.Text;
            string textError = "Длина строки должна быть не меньше одного символа.";

            if (testName.Length < 1)
            {
                e.Cancel = true;
            }
            else if (testName.Length > 30)
            {
                e.Cancel = true;
                textError = "Длина строки должна быть не больше 30 символов.";
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
            string textError = "Введите число цифрами и, при надобности, точкой.";
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
                if (testAmount < 0)
                {
                    e.Cancel = true;
                    textError = "Число должно быть не меньше нуля.";
                }
                else if (testAmount > 1000000)
                {
                    e.Cancel = true;
                    textError = "Введите число поменьше";
                }
            }
            if (!e.Cancel)
            {
                textError = "Введите целое число.";
                int n;
                if (measureComboBox.SelectedIndex == 0 && !int.TryParse(amountTextBox.Text, out n))
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
            string textError = "Введите число с плавающей точкой.";
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
                if (priceTextBox.Text.IndexOf('.') != priceTextBox.Text.Length - 3)
                {
                    e.Cancel = true;
                    textError = "Цена должна быть с двумя разрядами после плавающей точки.";
                }
            }
            if (e.Cancel)
            {
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(priceTextBox, textError);
            }
        }

        private void measureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            amountTextBox.Focus();
        }

        private void autoDateRadioButton_MouseClick(object sender, MouseEventArgs e)
        {
            deliveryDateTimePicker.Value = DateTime.Now;
            deliveryDateTimePicker.Enabled = false;
            customDateRadioButton.Checked = false;
        }

        private void customDateRadioButton_MouseClick(object sender, MouseEventArgs e)
        {
            deliveryDateTimePicker.Enabled = true;
            autoDateRadioButton.Checked = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string amountString = amountTextBox.Text;
            string priceString = priceTextBox.Text;
            if (name == "" || amountString == "" || priceString == "")
            {
                MessageBox.Show("Заполните все поля, пожалуйста.");
                return;
            }
            InpName = name;
            InpPrice = double.Parse(priceString);
            InpAmount = double.Parse(amountString);
            InpMeasure = measureComboBox.Items[measureComboBox.SelectedIndex].ToString();
            InpDeliveryDate = deliveryDateTimePicker.Value.ToString("dd/MM/yyyy HH:mm:ss");
            Close();
        }
    }
}
