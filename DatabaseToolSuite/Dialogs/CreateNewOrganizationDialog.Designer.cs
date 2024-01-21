namespace DatabaseToolSuite.Dialogs
{
    partial class CreateNewOrganizationDialog
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nextCodeButton = new System.Windows.Forms.Button();
            this.selectCodeButton = new System.Windows.Forms.Button();
            this.organizationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // organizationGroupBox
            // 
            this.organizationGroupBox.Controls.Add(this.selectCodeButton);
            this.organizationGroupBox.Controls.Add(this.nextCodeButton);
            this.organizationGroupBox.Controls.SetChildIndex(this.authorityComboBox, 0);
            this.organizationGroupBox.Controls.SetChildIndex(this.okatoComboBox, 0);
            this.organizationGroupBox.Controls.SetChildIndex(this.codeTextBox, 0);
            this.organizationGroupBox.Controls.SetChildIndex(this.nextCodeButton, 0);
            this.organizationGroupBox.Controls.SetChildIndex(this.selectCodeButton, 0);
            // 
            // authorityComboBox
            // 
            this.authorityComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // okatoComboBox
            // 
            this.okatoComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // nextCodeButton
            // 
            this.nextCodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nextCodeButton.Location = new System.Drawing.Point(260, 93);
            this.nextCodeButton.Name = "nextCodeButton";
            this.nextCodeButton.Size = new System.Drawing.Size(85, 28);
            this.nextCodeButton.TabIndex = 3;
            this.nextCodeButton.Text = "Создать";
            this.nextCodeButton.UseVisualStyleBackColor = true;
            this.nextCodeButton.Click += new System.EventHandler(this.nextCodeButton_Click);
            // 
            // selectCodeButton
            // 
            this.selectCodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectCodeButton.Location = new System.Drawing.Point(351, 93);
            this.selectCodeButton.Name = "selectCodeButton";
            this.selectCodeButton.Size = new System.Drawing.Size(85, 28);
            this.selectCodeButton.TabIndex = 4;
            this.selectCodeButton.Text = "Выбрать...";
            this.selectCodeButton.UseVisualStyleBackColor = true;
            this.selectCodeButton.Click += new System.EventHandler(this.selectCodeButton_Click);
            // 
            // CreateNewOrganizationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(544, 482);
            this.Name = "CreateNewOrganizationDialog";
            this.organizationGroupBox.ResumeLayout(false);
            this.organizationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectCodeButton;
        private System.Windows.Forms.Button nextCodeButton;
    }
}
