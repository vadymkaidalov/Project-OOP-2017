namespace CourseProject.PL
{
    partial class EditForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.measureLabel = new System.Windows.Forms.Label();
            this.measureComboBox = new System.Windows.Forms.ComboBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.deliveryDateLabel = new System.Windows.Forms.Label();
            this.autoDateRadioButton = new System.Windows.Forms.RadioButton();
            this.customDateRadioButton = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.Button();
            this.deliveryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(86, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Наименование:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(258, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // measureLabel
            // 
            this.measureLabel.AutoSize = true;
            this.measureLabel.Location = new System.Drawing.Point(12, 48);
            this.measureLabel.Name = "measureLabel";
            this.measureLabel.Size = new System.Drawing.Size(37, 13);
            this.measureLabel.TabIndex = 2;
            this.measureLabel.Text = "Мера:";
            // 
            // measureComboBox
            // 
            this.measureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.measureComboBox.Items.AddRange(new object[] {
            "шт",
            "кг",
            "л"});
            this.measureComboBox.Location = new System.Drawing.Point(12, 65);
            this.measureComboBox.Name = "measureComboBox";
            this.measureComboBox.Size = new System.Drawing.Size(95, 21);
            this.measureComboBox.TabIndex = 3;
            this.measureComboBox.SelectedIndexChanged += new System.EventHandler(this.measureComboBox_SelectedIndexChanged);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(110, 48);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(69, 13);
            this.amountLabel.TabIndex = 4;
            this.amountLabel.Text = "Количество:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(113, 66);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(157, 20);
            this.amountTextBox.TabIndex = 5;
            this.amountTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.amountTextBox_Validating);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(12, 109);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(95, 20);
            this.priceTextBox.TabIndex = 6;
            this.priceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.priceTextBox_Validating);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 93);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(36, 13);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Цена:";
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.AutoSize = true;
            this.deliveryDateLabel.Location = new System.Drawing.Point(15, 136);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(82, 13);
            this.deliveryDateLabel.TabIndex = 8;
            this.deliveryDateLabel.Text = "Время завоза:";
            // 
            // autoDateRadioButton
            // 
            this.autoDateRadioButton.AutoSize = true;
            this.autoDateRadioButton.Location = new System.Drawing.Point(12, 152);
            this.autoDateRadioButton.Name = "autoDateRadioButton";
            this.autoDateRadioButton.Size = new System.Drawing.Size(141, 17);
            this.autoDateRadioButton.TabIndex = 11;
            this.autoDateRadioButton.TabStop = true;
            this.autoDateRadioButton.Text = "Автоматически сейчас";
            this.autoDateRadioButton.UseVisualStyleBackColor = true;
            this.autoDateRadioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.autoDateRadioButton_MouseClick);
            // 
            // customDateRadioButton
            // 
            this.customDateRadioButton.AutoSize = true;
            this.customDateRadioButton.Location = new System.Drawing.Point(159, 152);
            this.customDateRadioButton.Name = "customDateRadioButton";
            this.customDateRadioButton.Size = new System.Drawing.Size(111, 17);
            this.customDateRadioButton.TabIndex = 12;
            this.customDateRadioButton.TabStop = true;
            this.customDateRadioButton.Text = "Выбрать самому";
            this.customDateRadioButton.UseVisualStyleBackColor = true;
            this.customDateRadioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.customDateRadioButton_MouseClick);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 201);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(258, 23);
            this.okButton.TabIndex = 13;
            this.okButton.Text = "Сохранить";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // deliveryDateTimePicker
            // 
            this.deliveryDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.deliveryDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deliveryDateTimePicker.Location = new System.Drawing.Point(12, 175);
            this.deliveryDateTimePicker.Name = "deliveryDateTimePicker";
            this.deliveryDateTimePicker.Size = new System.Drawing.Size(258, 20);
            this.deliveryDateTimePicker.TabIndex = 15;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 231);
            this.Controls.Add(this.deliveryDateTimePicker);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.customDateRadioButton);
            this.Controls.Add(this.autoDateRadioButton);
            this.Controls.Add(this.deliveryDateLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.measureComboBox);
            this.Controls.Add(this.measureLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditForm";
            this.Text = "Описание продукта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label measureLabel;
        private System.Windows.Forms.ComboBox measureComboBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label deliveryDateLabel;
        private System.Windows.Forms.RadioButton autoDateRadioButton;
        private System.Windows.Forms.RadioButton customDateRadioButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DateTimePicker deliveryDateTimePicker;
    }
}