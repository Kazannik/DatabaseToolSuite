namespace DatabaseToolSuite.Dialogs
{
    partial class OrganizationDialog
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
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lockCodeButton = new System.Windows.Forms.Button();
            this.beginDateTextBox = new System.Windows.Forms.TextBox();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.authorityComboBox = new DatabaseToolSuite.Controls.AuthorityComboBox(this.components);
            this.okatoComboBox = new DatabaseToolSuite.Controls.OkatoComboBox(this.components);
            this.SuspendLayout();
            // 
            // codeTextBox
            // 
            this.codeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.codeTextBox.Location = new System.Drawing.Point(20, 40);
            this.codeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(180, 30);
            this.codeTextBox.TabIndex = 2;
            this.codeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(20, 10);
            this.codeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(185, 20);
            this.codeLabel.TabIndex = 3;
            this.codeLabel.Text = "Код подразделения:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вид органа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ОКАТО:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Наименование:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(270, 220);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.nameTextBox.Size = new System.Drawing.Size(642, 89);
            this.nameTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата начала действия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата окончания действия:";
            // 
            // lockCodeButton
            // 
            this.lockCodeButton.Location = new System.Drawing.Point(208, 40);
            this.lockCodeButton.Name = "lockCodeButton";
            this.lockCodeButton.Size = new System.Drawing.Size(40, 32);
            this.lockCodeButton.TabIndex = 12;
            this.lockCodeButton.UseVisualStyleBackColor = true;
            this.lockCodeButton.Click += new System.EventHandler(this.lockCodeButton_Click);
            // 
            // beginDateTextBox
            // 
            this.beginDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginDateTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.beginDateTextBox.Location = new System.Drawing.Point(16, 128);
            this.beginDateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.beginDateTextBox.Name = "beginDateTextBox";
            this.beginDateTextBox.ReadOnly = true;
            this.beginDateTextBox.Size = new System.Drawing.Size(180, 30);
            this.beginDateTextBox.TabIndex = 13;
            this.beginDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.endDateTextBox.Location = new System.Drawing.Point(24, 240);
            this.endDateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.ReadOnly = true;
            this.endDateTextBox.Size = new System.Drawing.Size(180, 30);
            this.endDateTextBox.TabIndex = 14;
            this.endDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // authorityComboBox
            // 
            this.authorityComboBox.Code = "";
            this.authorityComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.authorityComboBox.DropDownHeight = 204;
            this.authorityComboBox.DropDownWidth = 80;
            this.authorityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorityComboBox.FormattingEnabled = true;
            this.authorityComboBox.IntegralHeight = false;
            this.authorityComboBox.ItemHeight = 25;
            this.authorityComboBox.Location = new System.Drawing.Point(270, 40);
            this.authorityComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.authorityComboBox.MaxDropDownItems = 20;
            this.authorityComboBox.Name = "authorityComboBox";
            this.authorityComboBox.Size = new System.Drawing.Size(642, 31);
            this.authorityComboBox.TabIndex = 1;
            // 
            // okatoComboBox
            // 
            this.okatoComboBox.Code = "";
            this.okatoComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.okatoComboBox.DropDownHeight = 204;
            this.okatoComboBox.DropDownWidth = 80;
            this.okatoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okatoComboBox.FormattingEnabled = true;
            this.okatoComboBox.IntegralHeight = false;
            this.okatoComboBox.ItemHeight = 25;
            this.okatoComboBox.Location = new System.Drawing.Point(270, 130);
            this.okatoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.okatoComboBox.MaxDropDownItems = 20;
            this.okatoComboBox.Name = "okatoComboBox";
            this.okatoComboBox.Size = new System.Drawing.Size(642, 31);
            this.okatoComboBox.TabIndex = 0;
            // 
            // OrganizationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 642);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.beginDateTextBox);
            this.Controls.Add(this.lockCodeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.authorityComboBox);
            this.Controls.Add(this.okatoComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrganizationDialog";
            this.Text = "OrganizationDialog";
            this.Load += new System.EventHandler(this.OrganizationDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.OkatoComboBox okatoComboBox;
        private Controls.AuthorityComboBox authorityComboBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button lockCodeButton;
        private System.Windows.Forms.TextBox beginDateTextBox;
        private System.Windows.Forms.TextBox endDateTextBox;
    }
}