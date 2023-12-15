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
            this.components = new System.ComponentModel.Container();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.name2TextBox = new System.Windows.Forms.TextBox();
            this.name2Label = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.centrumTextBox = new System.Windows.Forms.TextBox();
            this.centrumLabel = new System.Windows.Forms.Label();
            this.genitiveTextBox = new System.Windows.Forms.TextBox();
            this.genitiveLabel = new System.Windows.Forms.Label();
            this.terNumericTextBox = new DatabaseToolSuite.Controls.NumericTextBox(this.components);
            this.kod1NumericTextBox = new DatabaseToolSuite.Controls.NumericTextBox(this.components);
            this.labTextBox = new System.Windows.Forms.TextBox();
            this.okatoTextBox = new System.Windows.Forms.TextBox();
            this.okatoLabel = new System.Windows.Forms.Label();
            this.terLabel = new System.Windows.Forms.Label();
            this.kod1Label = new System.Windows.Forms.Label();
            this.labLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(208, 424);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 27);
            this.cancelButton.TabIndex = 30;
            this.cancelButton.Text = "Отмена";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(315, 424);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 27);
            this.okButton.TabIndex = 29;
            this.okButton.Text = "&ОК";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(19, 25);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(86, 17);
            this.idLabel.TabIndex = 31;
            this.idLabel.Text = "Код ОКАТО";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(15, 189);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(398, 73);
            this.nameTextBox.TabIndex = 34;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 170);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(106, 17);
            this.nameLabel.TabIndex = 33;
            this.nameLabel.Text = "Наименование";
            // 
            // name2TextBox
            // 
            this.name2TextBox.Location = new System.Drawing.Point(16, 283);
            this.name2TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name2TextBox.Name = "name2TextBox";
            this.name2TextBox.Size = new System.Drawing.Size(397, 22);
            this.name2TextBox.TabIndex = 36;
            this.name2TextBox.TextChanged += new System.EventHandler(this.name2TextBox_TextChanged);
            // 
            // name2Label
            // 
            this.name2Label.AutoSize = true;
            this.name2Label.Location = new System.Drawing.Point(13, 264);
            this.name2Label.Name = "name2Label";
            this.name2Label.Size = new System.Drawing.Size(192, 17);
            this.name2Label.TabIndex = 35;
            this.name2Label.Text = "Отражаемое наименование";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.codeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeTextBox.Location = new System.Drawing.Point(111, 19);
            this.codeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(100, 27);
            this.codeTextBox.TabIndex = 38;
            this.codeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // centrumTextBox
            // 
            this.centrumTextBox.Location = new System.Drawing.Point(16, 331);
            this.centrumTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.centrumTextBox.Name = "centrumTextBox";
            this.centrumTextBox.Size = new System.Drawing.Size(397, 22);
            this.centrumTextBox.TabIndex = 40;
            this.centrumTextBox.TextChanged += new System.EventHandler(this.centrumTextBox_TextChanged);
            // 
            // centrumLabel
            // 
            this.centrumLabel.AutoSize = true;
            this.centrumLabel.Location = new System.Drawing.Point(13, 312);
            this.centrumLabel.Name = "centrumLabel";
            this.centrumLabel.Size = new System.Drawing.Size(50, 17);
            this.centrumLabel.TabIndex = 39;
            this.centrumLabel.Text = "Центр";
            // 
            // genitiveTextBox
            // 
            this.genitiveTextBox.Location = new System.Drawing.Point(16, 379);
            this.genitiveTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genitiveTextBox.Name = "genitiveTextBox";
            this.genitiveTextBox.Size = new System.Drawing.Size(397, 22);
            this.genitiveTextBox.TabIndex = 42;
            this.genitiveTextBox.TextChanged += new System.EventHandler(this.genitiveTextBox_TextChanged);
            // 
            // genitiveLabel
            // 
            this.genitiveLabel.AutoSize = true;
            this.genitiveLabel.Location = new System.Drawing.Point(13, 360);
            this.genitiveLabel.Name = "genitiveLabel";
            this.genitiveLabel.Size = new System.Drawing.Size(261, 17);
            this.genitiveLabel.TabIndex = 41;
            this.genitiveLabel.Text = "Наименование в родительном падеже";
            // 
            // terNumericTextBox
            // 
            this.terNumericTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.terNumericTextBox.Location = new System.Drawing.Point(111, 77);
            this.terNumericTextBox.MaxLength = 2;
            this.terNumericTextBox.Name = "terNumericTextBox";
            this.terNumericTextBox.Size = new System.Drawing.Size(100, 22);
            this.terNumericTextBox.TabIndex = 43;
            this.terNumericTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.terNumericTextBox.TextChanged += new System.EventHandler(this.terNumericTextBox_TextChanged);
            // 
            // kod1NumericTextBox
            // 
            this.kod1NumericTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kod1NumericTextBox.Location = new System.Drawing.Point(111, 105);
            this.kod1NumericTextBox.MaxLength = 2;
            this.kod1NumericTextBox.Name = "kod1NumericTextBox";
            this.kod1NumericTextBox.Size = new System.Drawing.Size(100, 22);
            this.kod1NumericTextBox.TabIndex = 44;
            this.kod1NumericTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kod1NumericTextBox.TextChanged += new System.EventHandler(this.kod1NumericTextBox_TextChanged);
            // 
            // labTextBox
            // 
            this.labTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labTextBox.Location = new System.Drawing.Point(111, 134);
            this.labTextBox.MaxLength = 2;
            this.labTextBox.Name = "labTextBox";
            this.labTextBox.Size = new System.Drawing.Size(100, 22);
            this.labTextBox.TabIndex = 45;
            this.labTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.labTextBox.TextChanged += new System.EventHandler(this.labTextBox_TextChanged);
            // 
            // okatoTextBox
            // 
            this.okatoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.okatoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okatoTextBox.Location = new System.Drawing.Point(111, 50);
            this.okatoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okatoTextBox.Name = "okatoTextBox";
            this.okatoTextBox.ReadOnly = true;
            this.okatoTextBox.Size = new System.Drawing.Size(100, 22);
            this.okatoTextBox.TabIndex = 46;
            this.okatoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // okatoLabel
            // 
            this.okatoLabel.AutoSize = true;
            this.okatoLabel.Location = new System.Drawing.Point(48, 53);
            this.okatoLabel.Name = "okatoLabel";
            this.okatoLabel.Size = new System.Drawing.Size(57, 17);
            this.okatoLabel.TabIndex = 47;
            this.okatoLabel.Text = "ОКАТО";
            // 
            // terLabel
            // 
            this.terLabel.AutoSize = true;
            this.terLabel.Location = new System.Drawing.Point(48, 80);
            this.terLabel.Name = "terLabel";
            this.terLabel.Size = new System.Drawing.Size(36, 17);
            this.terLabel.TabIndex = 48;
            this.terLabel.Text = "TER";
            // 
            // kod1Label
            // 
            this.kod1Label.AutoSize = true;
            this.kod1Label.Location = new System.Drawing.Point(48, 108);
            this.kod1Label.Name = "kod1Label";
            this.kod1Label.Size = new System.Drawing.Size(46, 17);
            this.kod1Label.TabIndex = 49;
            this.kod1Label.Text = "KOD1";
            // 
            // labLabel
            // 
            this.labLabel.AutoSize = true;
            this.labLabel.Location = new System.Drawing.Point(48, 137);
            this.labLabel.Name = "labLabel";
            this.labLabel.Size = new System.Drawing.Size(51, 17);
            this.labLabel.TabIndex = 50;
            this.labLabel.Text = "LABEL";
            // 
            // OkatoEditDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(426, 462);
            this.Controls.Add(this.labLabel);
            this.Controls.Add(this.kod1Label);
            this.Controls.Add(this.terLabel);
            this.Controls.Add(this.okatoLabel);
            this.Controls.Add(this.okatoTextBox);
            this.Controls.Add(this.labTextBox);
            this.Controls.Add(this.kod1NumericTextBox);
            this.Controls.Add(this.terNumericTextBox);
            this.Controls.Add(this.genitiveTextBox);
            this.Controls.Add(this.genitiveLabel);
            this.Controls.Add(this.centrumTextBox);
            this.Controls.Add(this.centrumLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.name2TextBox);
            this.Controls.Add(this.name2Label);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OkatoEditDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник ОКАТО";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox name2TextBox;
        private System.Windows.Forms.Label name2Label;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox centrumTextBox;
        private System.Windows.Forms.Label centrumLabel;
        private System.Windows.Forms.TextBox genitiveTextBox;
        private System.Windows.Forms.Label genitiveLabel;
        private Controls.NumericTextBox terNumericTextBox;
        private Controls.NumericTextBox kod1NumericTextBox;
        private System.Windows.Forms.TextBox labTextBox;
        private System.Windows.Forms.TextBox okatoTextBox;
        private System.Windows.Forms.Label okatoLabel;
        private System.Windows.Forms.Label terLabel;
        private System.Windows.Forms.Label kod1Label;
        private System.Windows.Forms.Label labLabel;
    }
}
