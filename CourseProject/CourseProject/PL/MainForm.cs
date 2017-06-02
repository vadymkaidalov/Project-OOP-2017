using CourseProject.BLL;
using CourseProject.PL;
using System;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class MainForm : Form
    {
        private Shop shop;

        public MainForm()
        {
            InitializeComponent();
        }

        private void updateSearchBindingSource()
        {
            if (shop == null)
            {
                searchBindingSource.DataSource = null;
            }
            else
            {
                searchBindingSource.DataSource = null;
                searchBindingSource.DataSource = shop.SearchResult;
            }
            searchDataGridView.ClearSelection();
            searchDataGridView.Refresh();
        }

        private void updateBasketBindingSource()
        {
            if (shop == null)
            {
                basketBindingSource.DataSource = null;
            }
            else
            {
                basketBindingSource.DataSource = null;
                basketBindingSource.DataSource = shop.ProductBasket;
            }
            basketDataGridView.DataSource = basketBindingSource;
            

            basketDataGridView.ClearSelection();
            basketDataGridView.Refresh();
        }

        private void closeWarning()
        {
            if (shop != null && !shop.IsSaved)
            {
                DialogResult dialogResult = MessageBox.Show("Сохранить текущий файл перед выходом из программы?",
                    "Внимание!", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.OK)
                {
                    shop.SaveChanges();
                    Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void openFileStripMenuItem_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (shop != null)
            {
                MessageBox.Show("Закройте текущий файл, чтобы открыть другой.");
            }
            else if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    shop = new Shop(openFileDialog.FileName);
                    updateSearchBindingSource();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (shop != null)
            {
                MessageBox.Show("Закройте текущий файл, чтобы создать новый.");
            }
            else if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.Delete(saveFileDialog.FileName);
                try
                {
                    shop = new Shop(saveFileDialog.FileName);
                    updateSearchBindingSource();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shop == null)
            {
                MessageBox.Show("В данный момент ни одного файла не открыто и поэтому не будет сохранено.");
            }
            else
            {
                shop.SaveChanges();
                updateSearchBindingSource();
                MessageBox.Show("Файл сохранен.");
            }
        }

        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shop != null && !shop.IsSaved)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Сохранить текущий файл перед закрытием файла?", 
                    "Внимание!", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.OK)
                {
                    shop.SaveChanges();
                    shop = null;
                    updateSearchBindingSource();
                }
                else if (dialogResult == DialogResult.No)
                {
                    shop = null;
                    updateSearchBindingSource();
                }
            }
            else
            {
                shop = null;
                updateSearchBindingSource();
                MessageBox.Show("Все файлы закрыты.");
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (shop != null && !shop.IsSaved)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Сохранить текущий файл перед выходом из программы?", "Внимание!",
                    MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    shop.SaveChanges();
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shop == null)
            {
                MessageBox.Show("Ни один файл не открыт.");
                return;
            }
            if (!shop.IsBasketEmpty)
            {
                MessageBox.Show("Корзина покупок должна быть пуста!");
                return;
            }
            int index = searchDataGridView.CurrentRow.Index;
            if (index == -1)
            {
                MessageBox.Show("Сначала выберите мышкой продукт, количество которого желаете удалить.");
            }
            else
            {
                
                DeleteForm deleteForm = new DeleteForm(shop.SearchResult[index].Amount, 
                    shop.SearchResult[index].Measure);
                deleteForm.ShowDialog();
                searchBindingSource.DataSource = null;
                string name = shop.SearchResult[index].Name;
                shop.DeleteFromStorage(name, deleteForm.Quantity);
                updateSearchBindingSource();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (shop == null)
            {
                MessageBox.Show("Откройте, пожалуйста, файл в котором собираетесь искать.", "Внимание");
            }
            else if (shop.Search(searchTextBox.Text))
            {
                updateSearchBindingSource();
            }
            else
            {
                MessageBox.Show("Совпадений не найдено.");
                updateSearchBindingSource();
            }
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton.PerformClick();
            }
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shop == null)
            {
                MessageBox.Show("Ни один файл не открыт.");
                return;
            }
            if (!shop.IsBasketEmpty)
            {
                MessageBox.Show("Корзина покупок должна быть пуста!");
                return;
            }
            if (shop == null)
            {
                MessageBox.Show("Откройте файл, в который хотите добавить продукт.",
                    "Внимание");
            }
            else
            {
                EditForm editForm = new EditForm();
                editForm.ShowDialog();
                if (editForm.InpName != "")
                {
                    shop.AddToStorage(editForm.InpName, editForm.InpPrice, editForm.InpAmount, editForm.InpMeasure, editForm.InpDeliveryDate);
                }
            }
            updateSearchBindingSource();
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shop == null)
            {
                MessageBox.Show("Ни один файл не открыт.");
                return;
            }
            if (!shop.IsBasketEmpty)
            {
                MessageBox.Show("Корзина покупок должна быть пуста!");
                return;
            }
            int index = searchDataGridView.CurrentRow.Index;
            if (index == -1)
            {
                MessageBox.Show("Сначала выберите мышкой продукт, который хотите редактировать.");
            }
            else
            {
                string name = shop.SearchResult[index].Name;
                string amountString = shop.SearchResult[index].FormattedAmount;
                double amount = shop.SearchResult[index].Amount;
                string price = shop.SearchResult[index].FormattedPrice;
                string measure = shop.SearchResult[index].Measure;
                string deliveryDate = shop.SearchResult[index].DeliveryDate;
                EditForm editForm = new EditForm(name, amountString, price, measure, deliveryDate);
                editForm.ShowDialog();
                searchBindingSource.DataSource = null;
                shop.DeleteFromStorage(name, amount);
                shop.AddToStorage(editForm.InpName, editForm.InpPrice, editForm.InpAmount, editForm.InpMeasure, editForm.InpDeliveryDate);
                updateSearchBindingSource();
            }
        }

        private void addToBasketButton_Click(object sender, EventArgs e)
        {
            if (shop == null)
            {
                MessageBox.Show("Ни один файл не открыт.");
                return;
            }
            int index = searchDataGridView.CurrentRow.Index;
            if (index == -1)
            {
                MessageBox.Show("Сначала выберите мышкой продукт, который хотите добавить в корзину.");
            }
            else if (quantityTextBox.Text == "")
            {
                MessageBox.Show("Поле для ввода выбранного количества должно быть заполнено.");
            }
            else
            {
                string name = shop.SearchResult[index].Name;
                Product productReference = null;

                foreach (Product prod in shop.ProductFileStorage)
                {
                    if (prod.Name == name)
                    {
                        productReference = prod;
                        break;
                    }
                }

                double quantity = double.Parse(quantityTextBox.Text);
                shop.AddToBasket(productReference, quantity);

                updateSearchBindingSource();
                updateBasketBindingSource();
            }
        }

        private void searchDataGridView_Click(object sender, EventArgs e)
        {
            quantityTextBox.Text = "";
        }

        private void anullmentButton_Click(object sender, EventArgs e)
        {
            if (shop == null)
            {
                MessageBox.Show("Откройте файл и пополните корзину, чтобы ее очистить.");
            }
            else if (shop.ProductBasket == null || shop.ProductBasket.Count == 0)
            {
                MessageBox.Show("Корзина уже пуста!");
            }
            else
            {
                shop.Annulment();
                updateBasketBindingSource();
            }
        }

        private void createCheckButton_Click(object sender, EventArgs e)
        {
            if (shop == null)
            {
                MessageBox.Show("Откройте файл и добавьте продукты в корзину.");
            }
            else if (shop.ProductBasket == null || shop.ProductBasket.Count == 0)
            {
                MessageBox.Show("Ваша корзина пуста");
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    shop.CreateCheck(saveFileDialog.FileName);
                    updateSearchBindingSource();
                    updateBasketBindingSource();
                }
            }   
        }

        private void quantityTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (shop == null)
            {
                MessageBox.Show("Ни один файл не открыт.");
                return;
            }
            int index = searchDataGridView.CurrentRow.Index;
            double testAmount = -1;
            string textError = "Введите число цифрами и, при надобности, точкой.";
            try
            {
                testAmount = double.Parse(quantityTextBox.Text);
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
                else if (testAmount > shop.SearchResult[index].Amount)
                {
                    e.Cancel = true;
                    textError = "Введенное число больше количества доступных товаров.";
                }
            }
            if (!e.Cancel)
            {
                textError = "Введите целое число.";
                int n;
                if (shop.SearchResult[index].Measure == "шт" && !int.TryParse(quantityTextBox.Text, out n))
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
