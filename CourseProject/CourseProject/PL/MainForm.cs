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
            searchBindingSource.DataSource = null;
            if (shop != null)
            {
                searchBindingSource.DataSource = shop.SearchResult;
            }
            searchDataGridView.DataSource = searchBindingSource;
            searchDataGridView.ClearSelection();
            searchDataGridView.Refresh();
        }

        private void updateBasketBindingSource()
        {
            basketBindingSource.DataSource = null;
            if (shop != null)
            {
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
                DialogResult dialogResult = MessageBox.Show(
                    StringConstant.DoSaveQuestion,
                    StringConstant.Warning, 
                    MessageBoxButtons.YesNoCancel);

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

        private void openFileStripMenuItem_Click(object sender, 
            System.EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (shop != null)
            {
                MessageBox.Show(StringConstant.CloseFileAsk);
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
                MessageBox.Show(StringConstant.CloseFileAsk);
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
                MessageBox.Show(StringConstant.AnyFileOpened);
            }
            else
            {
                shop.SaveChanges();
                updateSearchBindingSource();
                MessageBox.Show(StringConstant.FileSaved);
            }
        }

        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shop != null && !shop.IsSaved)
            {
                DialogResult dialogResult = MessageBox.Show(
                    StringConstant.DoSaveQuestion, 
                    StringConstant.Warning, 
                    MessageBoxButtons.YesNoCancel);

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
                MessageBox.Show(StringConstant.AnyFileOpened);
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
                    StringConstant.DoSaveQuestion, 
                    StringConstant.Warning,
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
                MessageBox.Show(StringConstant.AnyFileOpened);
                return;
            }
            if (!shop.IsBasketEmpty)
            {
                MessageBox.Show(StringConstant.BasketMustBeEmpty);
                return;
            }
            int index = searchDataGridView.CurrentRow.Index;
            if (index == -1)
            {
                MessageBox.Show(StringConstant.NoProductSelected);
            }
            else
            {
                string name = shop.SearchResult[index].Name;
                DeleteForm deleteForm = new DeleteForm(
                    shop.SearchResult[index].Amount, 
                    shop.SearchResult[index].Measure);

                deleteForm.ShowDialog();
                shop.DeleteFromStorage(name, deleteForm.Quantity);
                updateSearchBindingSource();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (shop == null)
            {
                MessageBox.Show(
                    StringConstant.AnyFileOpened, 
                    StringConstant.Warning);
            }
            else if (shop.Search(searchTextBox.Text))
            {
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
                MessageBox.Show(StringConstant.AnyFileOpened);
                return;
            }
            if (!shop.IsBasketEmpty)
            {
                MessageBox.Show(StringConstant.BasketMustBeEmpty);
                return;
            }
            if (shop == null)
            {
                MessageBox.Show(
                    StringConstant.AnyFileOpened,
                    StringConstant.Warning);
            }
            else
            {
                EditForm editForm = new EditForm();

                editForm.ShowDialog();
                if ((editForm.InpName) != String.Empty)
                {
                    shop.AddToStorage(
                        editForm.InpName, 
                        editForm.InpPrice, 
                        editForm.InpAmount, 
                        editForm.InpMeasure, 
                        editForm.InpDeliveryDate);
                }
            }
            updateSearchBindingSource();
        }

        private void editProductToolStripMenuItem_Click(object sender, 
            EventArgs e)
        {
            if (shop == null)
            {
                MessageBox.Show(StringConstant.AnyFileOpened);
                return;
            }
            if (!shop.IsBasketEmpty)
            {
                MessageBox.Show(StringConstant.BasketMustBeEmpty);
                return;
            }
            int index = searchDataGridView.CurrentRow.Index;
            if (index == -1)
            {
                MessageBox.Show(StringConstant.NoProductSelected);
            }
            else
            {
                string name = shop.SearchResult[index].Name;
                string amountString = shop.SearchResult[index].FormattedAmount;
                double amount = shop.SearchResult[index].Amount;
                string price = shop.SearchResult[index].FormattedPrice;
                string measure = shop.SearchResult[index].Measure;
                string deliveryDate = shop.SearchResult[index].DeliveryDate;
                EditForm editForm = new EditForm(
                    name,
                    amountString,
                    price,
                    measure,
                    deliveryDate);

                editForm.ShowDialog();
                shop.DeleteFromStorage(name, amount);
                shop.AddToStorage(
                    editForm.InpName, 
                    editForm.InpPrice, 
                    editForm.InpAmount, 
                    editForm.InpMeasure, 
                    editForm.InpDeliveryDate);
                updateSearchBindingSource();
            }
        }

        private void addToBasketButton_Click(object sender, EventArgs e)
        {
            if (shop == null)
            {
                MessageBox.Show(StringConstant.AnyFileOpened);
                return;
            }
            int index = searchDataGridView.CurrentRow.Index;
            if (index == -1)
            {
                MessageBox.Show(StringConstant.NoProductSelected);
            }
            else if (quantityTextBox.Text == String.Empty)
            {
                MessageBox.Show(StringConstant.NotAllFields);
            }
            else
            {
                string name = shop.SearchResult[index].Name;
                Product productReference = shop.SearchForName(name);
                double quantity = double.Parse(quantityTextBox.Text);

                shop.AddToBasket(productReference, quantity);
                updateSearchBindingSource();
                updateBasketBindingSource();
            }
        }

        private void searchDataGridView_Click(object sender, EventArgs e)
        {
            quantityTextBox.Text = String.Empty;
        }

        private void anullmentButton_Click(object sender, EventArgs e)
        {
            if (shop == null)
            {
                MessageBox.Show(StringConstant.AnyFileOpened);
            }
            else if (shop.IsBasketEmpty)
            {
                MessageBox.Show(StringConstant.NoProductSelected);
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
                MessageBox.Show(StringConstant.AnyFileOpened);
            }
            else if (shop.IsBasketEmpty)
            {
                MessageBox.Show(StringConstant.NoProductSelected);
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

        private void quantityTextBox_Validating(object sender, 
            System.ComponentModel.CancelEventArgs e)
        {
            if (shop == null)
            {
                MessageBox.Show(StringConstant.AnyFileOpened);
                return;
            }
            int index = searchDataGridView.CurrentRow.Index;
            double testAmount = -1;
            string textError = StringConstant.IncorrectInput;
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
                if (testAmount < 0
                    || testAmount > shop.SearchResult[index].Amount)
                {
                    e.Cancel = true;
                    textError = StringConstant.OutOfBounds;
                }
            }
            if (!e.Cancel)
            {
                textError = StringConstant.NotInteger;
                int n;
                bool notInteger = !int.TryParse(quantityTextBox.Text, out n);
                if (shop.SearchResult[index].Measure == StringConstant.Item  && notInteger)
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
