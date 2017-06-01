namespace CourseProject.PL
{
    partial class DeleteForm
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
            this.numLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.measureLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(13, 13);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(227, 13);
            this.numLabel.TabIndex = 0;
            this.numLabel.Text = "Введите количество удаляемой продукции:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(16, 30);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(171, 20);
            this.quantityTextBox.TabIndex = 1;
            this.quantityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.quantityTextBox_Validating);
            // 
            // measureLabel
            // 
            this.measureLabel.AutoSize = true;
            this.measureLabel.Location = new System.Drawing.Point(193, 33);
            this.measureLabel.Name = "measureLabel";
            this.measureLabel.Size = new System.Drawing.Size(35, 13);
            this.measureLabel.TabIndex = 2;
            this.measureLabel.Text = "label1";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(16, 58);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(218, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Подтвердить";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 93);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.measureLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.numLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DeleteForm";
            this.Text = "Удалить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label measureLabel;
        private System.Windows.Forms.Button okButton;
    }
}