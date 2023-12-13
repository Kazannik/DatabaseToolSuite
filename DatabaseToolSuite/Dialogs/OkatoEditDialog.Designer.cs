namespace DatabaseToolSuite.Dialogs
{
    partial class OkatoEditDialog
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.name2TextBox = new System.Windows.Forms.TextBox();
            this.name2Label = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.centrumTextBox = new System.Windows.Forms.TextBox();
            this.centrumLabel = new System.Windows.Forms.Label();
            this.genitiveTextBox = new System.Windows.Forms.TextBox();
            this.genitiveLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(450, 312);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 34);
            this.cancelButton.TabIndex = 30;
            this.cancelButton.Text = "Отмена";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(570, 312);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(112, 34);
            this.okButton.TabIndex = 29;
            this.okButton.Text = "&ОК";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 43);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(97, 20);
            this.idLabel.TabIndex = 31;
            this.idLabel.Text = "Код ОКАТО";
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.Location = new System.Drawing.Point(236, 40);
            this.idTextBox.MaxLength = 5;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(126, 26);
            this.idTextBox.TabIndex = 32;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(236, 104);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(447, 26);
            this.nameTextBox.TabIndex = 34;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 107);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(122, 20);
            this.nameLabel.TabIndex = 33;
            this.nameLabel.Text = "Наименование";
            // 
            // name2TextBox
            // 
            this.name2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name2TextBox.Location = new System.Drawing.Point(236, 136);
            this.name2TextBox.Name = "name2TextBox";
            this.name2TextBox.Size = new System.Drawing.Size(446, 26);
            this.name2TextBox.TabIndex = 36;
            this.name2TextBox.TextChanged += new System.EventHandler(this.name2TextBox_TextChanged);
            // 
            // name2Label
            // 
            this.name2Label.AutoSize = true;
            this.name2Label.Location = new System.Drawing.Point(12, 139);
            this.name2Label.Name = "name2Label";
            this.name2Label.Size = new System.Drawing.Size(218, 20);
            this.name2Label.TabIndex = 35;
            this.name2Label.Text = "Упрощенное наименование";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTextBox.Location = new System.Drawing.Point(236, 72);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(126, 26);
            this.codeTextBox.TabIndex = 38;
            // 
            // centrumTextBox
            // 
            this.centrumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.centrumTextBox.Location = new System.Drawing.Point(236, 168);
            this.centrumTextBox.Name = "centrumTextBox";
            this.centrumTextBox.Size = new System.Drawing.Size(446, 26);
            this.centrumTextBox.TabIndex = 40;
            this.centrumTextBox.TextChanged += new System.EventHandler(this.centrumTextBox_TextChanged);
            // 
            // centrumLabel
            // 
            this.centrumLabel.AutoSize = true;
            this.centrumLabel.Location = new System.Drawing.Point(12, 171);
            this.centrumLabel.Name = "centrumLabel";
            this.centrumLabel.Size = new System.Drawing.Size(57, 20);
            this.centrumLabel.TabIndex = 39;
            this.centrumLabel.Text = "Центр";
            // 
            // genitiveTextBox
            // 
            this.genitiveTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genitiveTextBox.Location = new System.Drawing.Point(236, 226);
            this.genitiveTextBox.Name = "genitiveTextBox";
            this.genitiveTextBox.Size = new System.Drawing.Size(446, 26);
            this.genitiveTextBox.TabIndex = 42;
            this.genitiveTextBox.TextChanged += new System.EventHandler(this.genitiveTextBox_TextChanged);
            // 
            // genitiveLabel
            // 
            this.genitiveLabel.AutoSize = true;
            this.genitiveLabel.Location = new System.Drawing.Point(12, 203);
            this.genitiveLabel.Name = "genitiveLabel";
            this.genitiveLabel.Size = new System.Drawing.Size(305, 20);
            this.genitiveLabel.TabIndex = 41;
            this.genitiveLabel.Text = "Наименование в родительном падеже";
            // 
            // OkatoEditDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(695, 360);
            this.Controls.Add(this.genitiveTextBox);
            this.Controls.Add(this.genitiveLabel);
            this.Controls.Add(this.centrumTextBox);
            this.Controls.Add(this.centrumLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.name2TextBox);
            this.Controls.Add(this.name2Label);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OkatoEditDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Справочник ОКАТО";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox name2TextBox;
        private System.Windows.Forms.Label name2Label;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox centrumTextBox;
        private System.Windows.Forms.Label centrumLabel;
        private System.Windows.Forms.TextBox genitiveTextBox;
        private System.Windows.Forms.Label genitiveLabel;
    }
}
