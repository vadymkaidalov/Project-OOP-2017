namespace CourseProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.productsTabPage = new System.Windows.Forms.TabPage();
            this.addToBasketButton = new System.Windows.Forms.Button();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.basketTabPage = new System.Windows.Forms.TabPage();
            this.createCheckButton = new System.Windows.Forms.Button();
            this.basketDataGridView = new System.Windows.Forms.DataGridView();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.anullmentButton = new System.Windows.Forms.Button();
            this.FormattedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormattedTotalSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formattedAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenuStrip.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.productsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.basketTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basketDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(763, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.closeFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.newFileToolStripMenuItem.Text = "Новый файл";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openFileStripMenuItem
            // 
            this.openFileStripMenuItem.Name = "openFileStripMenuItem";
            this.openFileStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.openFileStripMenuItem.Text = "Открыть файл";
            this.openFileStripMenuItem.Click += new System.EventHandler(this.openFileStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveFileToolStripMenuItem.Text = "Сохранить файл";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // closeFileToolStripMenuItem
            // 
            this.closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
            this.closeFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.closeFileToolStripMenuItem.Text = "Закрыть файл";
            this.closeFileToolStripMenuItem.Click += new System.EventHandler(this.closeFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "Выйти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.editProductToolStripMenuItem,
            this.deleteProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.editToolStripMenuItem.Text = "Редактировать";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.addProductToolStripMenuItem.Text = "Добавить продукт";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // editProductToolStripMenuItem
            // 
            this.editProductToolStripMenuItem.Name = "editProductToolStripMenuItem";
            this.editProductToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.editProductToolStripMenuItem.Text = "Редактировать продукт";
            this.editProductToolStripMenuItem.Click += new System.EventHandler(this.editProductToolStripMenuItem_Click);
            // 
            // deleteProductToolStripMenuItem
            // 
            this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            this.deleteProductToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.deleteProductToolStripMenuItem.Text = "Удалить продукт";
            this.deleteProductToolStripMenuItem.Click += new System.EventHandler(this.deleteProductToolStripMenuItem_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.productsTabPage);
            this.mainTabControl.Controls.Add(this.basketTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(0, 28);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(763, 539);
            this.mainTabControl.TabIndex = 1;
            // 
            // productsTabPage
            // 
            this.productsTabPage.Controls.Add(this.quantityTextBox);
            this.productsTabPage.Controls.Add(this.quantityLabel);
            this.productsTabPage.Controls.Add(this.addToBasketButton);
            this.productsTabPage.Controls.Add(this.searchDataGridView);
            this.productsTabPage.Controls.Add(this.searchButton);
            this.productsTabPage.Controls.Add(this.searchTextBox);
            this.productsTabPage.Controls.Add(this.searchLabel);
            this.productsTabPage.Location = new System.Drawing.Point(4, 22);
            this.productsTabPage.Name = "productsTabPage";
            this.productsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.productsTabPage.Size = new System.Drawing.Size(755, 513);
            this.productsTabPage.TabIndex = 0;
            this.productsTabPage.Text = "Продуктовая база";
            this.productsTabPage.UseVisualStyleBackColor = true;
            // 
            // addToBasketButton
            // 
            this.addToBasketButton.Location = new System.Drawing.Point(359, 484);
            this.addToBasketButton.Name = "addToBasketButton";
            this.addToBasketButton.Size = new System.Drawing.Size(390, 23);
            this.addToBasketButton.TabIndex = 4;
            this.addToBasketButton.Text = "Добавить в корзину";
            this.addToBasketButton.UseVisualStyleBackColor = true;
            this.addToBasketButton.Click += new System.EventHandler(this.addToBasketButton_Click);
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.AllowUserToAddRows = false;
            this.searchDataGridView.AllowUserToDeleteRows = false;
            this.searchDataGridView.AllowUserToResizeColumns = false;
            this.searchDataGridView.AllowUserToResizeRows = false;
            this.searchDataGridView.AutoGenerateColumns = false;
            this.searchDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.measureDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.formattedAmountDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn});
            this.searchDataGridView.DataSource = this.searchBindingSource;
            this.searchDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.searchDataGridView.Location = new System.Drawing.Point(8, 33);
            this.searchDataGridView.MultiSelect = false;
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchDataGridView.Size = new System.Drawing.Size(741, 445);
            this.searchDataGridView.TabIndex = 3;
            this.searchDataGridView.Click += new System.EventHandler(this.searchDataGridView_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(607, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(142, 20);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(99, 7);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(502, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(8, 10);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(85, 13);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Строка поиска:";
            // 
            // basketTabPage
            // 
            this.basketTabPage.Controls.Add(this.anullmentButton);
            this.basketTabPage.Controls.Add(this.createCheckButton);
            this.basketTabPage.Controls.Add(this.basketDataGridView);
            this.basketTabPage.Location = new System.Drawing.Point(4, 22);
            this.basketTabPage.Name = "basketTabPage";
            this.basketTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.basketTabPage.Size = new System.Drawing.Size(755, 513);
            this.basketTabPage.TabIndex = 1;
            this.basketTabPage.Text = "Корзина";
            this.basketTabPage.UseVisualStyleBackColor = true;
            // 
            // createCheckButton
            // 
            this.createCheckButton.Location = new System.Drawing.Point(358, 484);
            this.createCheckButton.Name = "createCheckButton";
            this.createCheckButton.Size = new System.Drawing.Size(390, 23);
            this.createCheckButton.TabIndex = 5;
            this.createCheckButton.Text = "Оформить чек";
            this.createCheckButton.UseVisualStyleBackColor = true;
            this.createCheckButton.Click += new System.EventHandler(this.createCheckButton_Click);
            // 
            // basketDataGridView
            // 
            this.basketDataGridView.AllowUserToAddRows = false;
            this.basketDataGridView.AllowUserToDeleteRows = false;
            this.basketDataGridView.AllowUserToResizeColumns = false;
            this.basketDataGridView.AllowUserToResizeRows = false;
            this.basketDataGridView.AutoGenerateColumns = false;
            this.basketDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.basketDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.basketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.FormattedQuantity,
            this.FormattedTotalSum});
            this.basketDataGridView.DataSource = this.basketBindingSource;
            this.basketDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.basketDataGridView.Location = new System.Drawing.Point(7, 6);
            this.basketDataGridView.Name = "basketDataGridView";
            this.basketDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.basketDataGridView.Size = new System.Drawing.Size(741, 472);
            this.basketDataGridView.TabIndex = 4;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(12, 487);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(128, 13);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Выбранное количество:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(137, 484);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(184, 20);
            this.quantityTextBox.TabIndex = 6;
            this.quantityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.quantityTextBox_Validating);
            // 
            // anullmentButton
            // 
            this.anullmentButton.Location = new System.Drawing.Point(7, 484);
            this.anullmentButton.Name = "anullmentButton";
            this.anullmentButton.Size = new System.Drawing.Size(345, 23);
            this.anullmentButton.TabIndex = 6;
            this.anullmentButton.Text = "Аннуляция";
            this.anullmentButton.UseVisualStyleBackColor = true;
            this.anullmentButton.Click += new System.EventHandler(this.anullmentButton_Click);
            // 
            // FormattedQuantity
            // 
            this.FormattedQuantity.DataPropertyName = "FormattedQuantity";
            this.FormattedQuantity.HeaderText = "Количество";
            this.FormattedQuantity.Name = "FormattedQuantity";
            this.FormattedQuantity.ReadOnly = true;
            // 
            // FormattedTotalSum
            // 
            this.FormattedTotalSum.DataPropertyName = "FormattedTotalSum";
            this.FormattedTotalSum.HeaderText = "Сумма";
            this.FormattedTotalSum.Name = "FormattedTotalSum";
            this.FormattedTotalSum.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // measureDataGridViewTextBoxColumn
            // 
            this.measureDataGridViewTextBoxColumn.DataPropertyName = "Measure";
            this.measureDataGridViewTextBoxColumn.HeaderText = "Мера";
            this.measureDataGridViewTextBoxColumn.Name = "measureDataGridViewTextBoxColumn";
            this.measureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "FormattedPrice";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formattedAmountDataGridViewTextBoxColumn
            // 
            this.formattedAmountDataGridViewTextBoxColumn.DataPropertyName = "FormattedAmount";
            this.formattedAmountDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.formattedAmountDataGridViewTextBoxColumn.Name = "formattedAmountDataGridViewTextBoxColumn";
            this.formattedAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "Время завоза";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.Width = 140;
            // 
            // searchBindingSource
            // 
            this.searchBindingSource.DataSource = typeof(CourseProject.BLL.ProductList);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Measure";
            this.dataGridViewTextBoxColumn2.HeaderText = "Мера";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FormattedPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // basketBindingSource
            // 
            this.basketBindingSource.DataSource = typeof(CourseProject.BLL.PurchaseList);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 579);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Менеджер магазина";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.productsTabPage.ResumeLayout(false);
            this.productsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.basketTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.basketDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductToolStripMenuItem;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage productsTabPage;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.BindingSource searchBindingSource;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TabPage basketTabPage;
        private System.Windows.Forms.Button addToBasketButton;
        private System.Windows.Forms.Button createCheckButton;
        private System.Windows.Forms.DataGridView basketDataGridView;
        private System.Windows.Forms.BindingSource basketBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formattedAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button anullmentButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormattedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormattedTotalSum;
    }
}

