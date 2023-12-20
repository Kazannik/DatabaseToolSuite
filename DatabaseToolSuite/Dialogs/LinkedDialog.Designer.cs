namespace DatabaseToolSuite.Dialogs
{
    partial class LinkedDialog
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
            this.repositoryLabel = new System.Windows.Forms.Label();
            this.repositoryTextBox = new System.Windows.Forms.TextBox();
            this.dictionaryLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.hideLinkedItemCheckBox = new System.Windows.Forms.CheckBox();
            this.dictionaryTableViewComboBox = new DatabaseToolSuite.Controls.TableViewComboBox(this.components);
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // repositoryLabel
            // 
            this.repositoryLabel.AutoSize = true;
            this.repositoryLabel.Location = new System.Drawing.Point(12, 20);
            this.repositoryLabel.Name = "repositoryLabel";
            this.repositoryLabel.Size = new System.Drawing.Size(157, 17);
            this.repositoryLabel.TabIndex = 0;
            this.repositoryLabel.Text = "Значение из таблицы:";
            // 
            // repositoryTextBox
            // 
            this.repositoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.repositoryTextBox.Location = new System.Drawing.Point(12, 40);
            this.repositoryTextBox.Name = "repositoryTextBox";
            this.repositoryTextBox.ReadOnly = true;
            this.repositoryTextBox.Size = new System.Drawing.Size(478, 22);
            this.repositoryTextBox.TabIndex = 1;
            // 
            // dictionaryLabel
            // 
            this.dictionaryLabel.AutoSize = true;
            this.dictionaryLabel.Location = new System.Drawing.Point(12, 83);
            this.dictionaryLabel.Name = "dictionaryLabel";
            this.dictionaryLabel.Size = new System.Drawing.Size(260, 17);
            this.dictionaryLabel.TabIndex = 2;
            this.dictionaryLabel.Text = "Подставляемое значение из словаря:";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(389, 183);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 27);
            this.cancelButton.TabIndex = 28;
            this.cancelButton.Text = "Отмена";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(281, 183);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 27);
            this.okButton.TabIndex = 27;
            this.okButton.Text = "&ОК";
            // 
            // hideLinkedItemCheckBox
            // 
            this.hideLinkedItemCheckBox.AutoSize = true;
            this.hideLinkedItemCheckBox.Checked = global::DatabaseToolSuite.Properties.Settings.Default.HideLinkedItem;
            this.hideLinkedItemCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideLinkedItemCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DatabaseToolSuite.Properties.Settings.Default, "HideLinkedItem", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.hideLinkedItemCheckBox.Location = new System.Drawing.Point(19, 136);
            this.hideLinkedItemCheckBox.Name = "hideLinkedItemCheckBox";
            this.hideLinkedItemCheckBox.Size = new System.Drawing.Size(305, 21);
            this.hideLinkedItemCheckBox.TabIndex = 29;
            this.hideLinkedItemCheckBox.Text = "Скрыть ранее использованные элементы";
            this.hideLinkedItemCheckBox.UseVisualStyleBackColor = true;
            this.hideLinkedItemCheckBox.CheckedChanged += new System.EventHandler(this.hideLinkedItemCheckBox_CheckedChanged);
            // 
            // dictionaryTableViewComboBox
            // 
            this.dictionaryTableViewComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dictionaryTableViewComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dictionaryTableViewComboBox.DropDownHeight = 164;
            this.dictionaryTableViewComboBox.DropDownWidth = 80;
            this.dictionaryTableViewComboBox.FormattingEnabled = true;
            this.dictionaryTableViewComboBox.IntegralHeight = false;
            this.dictionaryTableViewComboBox.ItemHeight = 20;
            this.dictionaryTableViewComboBox.Location = new System.Drawing.Point(12, 103);
            this.dictionaryTableViewComboBox.MaxDropDownItems = 20;
            this.dictionaryTableViewComboBox.Name = "dictionaryTableViewComboBox";
            this.dictionaryTableViewComboBox.Size = new System.Drawing.Size(372, 26);
            this.dictionaryTableViewComboBox.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(392, 104);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 27);
            this.AddButton.TabIndex = 30;
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // LinkedDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(502, 223);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.hideLinkedItemCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.dictionaryTableViewComboBox);
            this.Controls.Add(this.dictionaryLabel);
            this.Controls.Add(this.repositoryTextBox);
            this.Controls.Add(this.repositoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LinkedDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Связывание значений со словарем";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label repositoryLabel;
        private System.Windows.Forms.TextBox repositoryTextBox;
        private System.Windows.Forms.Label dictionaryLabel;
        private Controls.TableViewComboBox dictionaryTableViewComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.CheckBox hideLinkedItemCheckBox;
        private System.Windows.Forms.Button AddButton;
    }
}