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
                searchBindingSource.DataSource = shop.SearchResult;
            }
            searchDataGridView.ClearSelection();
            searchDataGridView.Refresh();
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
                shop = new Shop(saveFileDialog.FileName);
                updateSearchBindingSource();
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
                DialogResult dialogResult = MessageBox.Show("Внимание!",
                    "Сохранить текущий файл перед выходом из программы?",
                    MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.OK)
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
    }
}
