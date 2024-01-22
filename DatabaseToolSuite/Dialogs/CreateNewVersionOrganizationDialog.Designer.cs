namespace DatabaseToolSuite.Dialogs
{
    partial class CreateNewVersionOrganizationDialog
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
            this.beginDateLabel = new System.Windows.Forms.Label();
            this.beginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameLabel = new System.Windows.Forms.Label();
            this.organizationGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteOwnerButton = new System.Windows.Forms.Button();
            this.selectOwnerButton = new System.Windows.Forms.Button();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.okatoLabel = new System.Windows.Forms.Label();
            this.authorityLabel = new System.Windows.Forms.Label();
            this.okatoComboBox = new DatabaseToolSuite.Controls.OkatoComboBox(this.components);
            this.authorityComboBox = new DatabaseToolSuite.Controls.AuthorityComboBox(this.components);
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.organizationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DatabaseToolSuite.Properties.Resources.Info64;
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            // 
            // beginDateLabel
            // 
            this.beginDateLabel.AutoSize = true;
            this.beginDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginDateLabel.Location = new System.Drawing.Point(124, 94);
            this.beginDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.beginDateLabel.Name = "beginDateLabel";
            this.beginDateLabel.Size = new System.Drawing.Size(263, 20);
            this.beginDateLabel.TabIndex = 36;
            this.beginDateLabel.Text = "Дата введения новой версии:";
            // 
            // beginDateTimePicker
            // 
            this.beginDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginDateTimePicker.Location = new System.Drawing.Point(128, 123);
            this.beginDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.beginDateTimePicker.Name = "beginDateTimePicker";
            this.beginDateTimePicker.Size = new System.Drawing.Size(191, 26);
            this.beginDateTimePicker.TabIndex = 0;
            this.beginDateTimePicker.ValueChanged += new System.EventHandler(this.Controls_ValueChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(8, 33);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(139, 20);
            this.nameLabel.TabIndex = 37;
            this.nameLabel.Text = "Наименование:";
            // 
            // organizationGroupBox
            // 
            this.organizationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.organizationGroupBox.Controls.Add(this.deleteOwnerButton);
            this.organizationGroupBox.Controls.Add(this.selectOwnerButton);
            this.organizationGroupBox.Controls.Add(this.ownerTextBox);
            this.organizationGroupBox.Controls.Add(this.ownerLabel);
            this.organizationGroupBox.Controls.Add(this.okatoLabel);
            this.organizationGroupBox.Controls.Add(this.authorityLabel);
            this.organizationGroupBox.Controls.Add(this.okatoComboBox);
            this.organizationGroupBox.Controls.Add(this.authorityComboBox);
            this.organizationGroupBox.Controls.Add(this.codeTextBox);
            this.organizationGroupBox.Controls.Add(this.codeLabel);
            this.organizationGroupBox.Controls.Add(this.nameTextBox);
            this.organizationGroupBox.Controls.Add(this.nameLabel);
            this.organizationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.organizationGroupBox.Location = new System.Drawing.Point(16, 158);
            this.organizationGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.organizationGroupBox.Name = "organizationGroupBox";
            this.organizationGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.organizationGroupBox.Size = new System.Drawing.Size(690, 373);
            this.organizationGroupBox.TabIndex = 38;
            this.organizationGroupBox.TabStop = false;
            this.organizationGroupBox.Text = "Сведения о подразделении правоохранительного органа";
            // 
            // deleteOwnerButton
            // 
            this.deleteOwnerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteOwnerButton.Location = new System.Drawing.Point(465, 326);
            this.deleteOwnerButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteOwnerButton.Name = "deleteOwnerButton";
            this.deleteOwnerButton.Size = new System.Drawing.Size(213, 34);
            this.deleteOwnerButton.TabIndex = 8;
            this.deleteOwnerButton.Text = "Удалить владельца...";
            this.deleteOwnerButton.Click += new System.EventHandler(this.deleteOwnerButton_Click);
            // 
            // selectOwnerButton
            // 
            this.selectOwnerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectOwnerButton.Location = new System.Drawing.Point(244, 326);
            this.selectOwnerButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectOwnerButton.Name = "selectOwnerButton";
            this.selectOwnerButton.Size = new System.Drawing.Size(213, 34);
            this.selectOwnerButton.TabIndex = 7;
            this.selectOwnerButton.Text = "Выбрать владельца...";
            this.selectOwnerButton.Click += new System.EventHandler(this.selectOwnerButton_Click);
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ownerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerTextBox.Location = new System.Drawing.Point(8, 263);
            this.ownerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ownerTextBox.Multiline = true;
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.ReadOnly = true;
            this.ownerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ownerTextBox.Size = new System.Drawing.Size(669, 56);
            this.ownerTextBox.TabIndex = 45;
            this.ownerTextBox.TextChanged += new System.EventHandler(this.Controls_ValueChanged);
            // 
            // ownerLabel
            // 
            this.ownerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Location = new System.Drawing.Point(8, 240);
            this.ownerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(98, 20);
            this.ownerLabel.TabIndex = 44;
            this.ownerLabel.Text = "Владелец:";
            // 
            // okatoLabel
            // 
            this.okatoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okatoLabel.AutoSize = true;
            this.okatoLabel.Location = new System.Drawing.Point(45, 162);
            this.okatoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.okatoLabel.Name = "okatoLabel";
            this.okatoLabel.Size = new System.Drawing.Size(73, 20);
            this.okatoLabel.TabIndex = 39;
            this.okatoLabel.Text = "ОКАТО:";
            // 
            // authorityLabel
            // 
            this.authorityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.authorityLabel.AutoSize = true;
            this.authorityLabel.Location = new System.Drawing.Point(8, 202);
            this.authorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorityLabel.Name = "authorityLabel";
            this.authorityLabel.Size = new System.Drawing.Size(111, 20);
            this.authorityLabel.TabIndex = 43;
            this.authorityLabel.Text = "Вид органа:";
            // 
            // okatoComboBox
            // 
            this.okatoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okatoComboBox.Code = "";
            this.okatoComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.okatoComboBox.DropDownHeight = 196;
            this.okatoComboBox.DropDownWidth = 80;
            this.okatoComboBox.FormattingEnabled = true;
            this.okatoComboBox.IntegralHeight = false;
            this.okatoComboBox.ItemHeight = 24;
            this.okatoComboBox.Location = new System.Drawing.Point(129, 156);
            this.okatoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.okatoComboBox.MaxDropDownItems = 20;
            this.okatoComboBox.Name = "okatoComboBox";
            this.okatoComboBox.Size = new System.Drawing.Size(548, 30);
            this.okatoComboBox.TabIndex = 6;
            this.okatoComboBox.SelectedIndexChanged += new System.EventHandler(this.Controls_ValueChanged);
            // 
            // authorityComboBox
            // 
            this.authorityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorityComboBox.Code = "";
            this.authorityComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.authorityComboBox.DropDownHeight = 196;
            this.authorityComboBox.DropDownWidth = 80;
            this.authorityComboBox.FormattingEnabled = true;
            this.authorityComboBox.IntegralHeight = false;
            this.authorityComboBox.ItemHeight = 24;
            this.authorityComboBox.Location = new System.Drawing.Point(129, 196);
            this.authorityComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.authorityComboBox.MaxDropDownItems = 20;
            this.authorityComboBox.Name = "authorityComboBox";
            this.authorityComboBox.Size = new System.Drawing.Size(548, 30);
            this.authorityComboBox.TabIndex = 5;
            this.authorityComboBox.SelectedIndexChanged += new System.EventHandler(this.Controls_ValueChanged);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.codeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.codeTextBox.Location = new System.Drawing.Point(204, 118);
            this.codeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(133, 26);
            this.codeTextBox.TabIndex = 2;
            this.codeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codeTextBox.TextChanged += new System.EventHandler(this.Controls_ValueChanged);
            // 
            // codeLabel
            // 
            this.codeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(8, 122);
            this.codeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(185, 20);
            this.codeLabel.TabIndex = 39;
            this.codeLabel.Text = "Код подразделения:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(12, 57);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.nameTextBox.Size = new System.Drawing.Size(669, 53);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.Controls_ValueChanged);
            // 
            // CreateNewVersionOrganizationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(722, 593);
            this.Controls.Add(this.organizationGroupBox);
            this.Controls.Add(this.beginDateLabel);
            this.Controls.Add(this.beginDateTimePicker);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(740, 630);
            this.Name = "CreateNewVersionOrganizationDialog";
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.beginDateTimePicker, 0);
            this.Controls.SetChildIndex(this.beginDateLabel, 0);
            this.Controls.SetChildIndex(this.organizationGroupBox, 0);
            this.Controls.SetChildIndex(this.captionLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.organizationGroupBox.ResumeLayout(false);
            this.organizationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label beginDateLabel;
        private System.Windows.Forms.DateTimePicker beginDateTimePicker;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label okatoLabel;
        private System.Windows.Forms.Label authorityLabel;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Button selectOwnerButton;
        private System.Windows.Forms.Button deleteOwnerButton;
        protected System.Windows.Forms.GroupBox organizationGroupBox;
        public System.Windows.Forms.TextBox codeTextBox;
        protected Controls.AuthorityComboBox authorityComboBox;
        protected Controls.OkatoComboBox okatoComboBox;
    }
}
