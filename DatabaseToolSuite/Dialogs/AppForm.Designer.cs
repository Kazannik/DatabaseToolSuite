namespace DatabaseToolSuite.Dialogs
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExportToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTableNewOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTableCreateOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTableCreateNewVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTableRemoveOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTableEditError = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.rowCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.selectedRowStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filtrGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filterNameTextBox = new System.Windows.Forms.TextBox();
            this.filterLockCodeViewCheckBox = new System.Windows.Forms.CheckBox();
            this.okatoLabel = new System.Windows.Forms.Label();
            this.authorityLabel = new System.Windows.Forms.Label();
            this.gaspsListView = new DatabaseToolSuite.Controls.GaspsListView();
            this.filterCodeNumericTextBox = new DatabaseToolSuite.Controls.NumericTextBox(this.components);
            this.filterAuthorityComboBox = new DatabaseToolSuite.Controls.AuthorityComboBox();
            this.filterOkatoComboBox = new DatabaseToolSuite.Controls.OkatoComboBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.filtrGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTable,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNewToolStripMenuItem,
            this.mnuFileOpenToolStripMenuItem,
            this.mnuFileSaveToolStripMenuItem,
            this.mnuFileSaveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mnuFileImport,
            this.mnuFileExport,
            this.toolStripMenuItem2,
            this.mnuFileExportToExcel,
            this.toolStripMenuItem6,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(57, 24);
            this.mnuFile.Text = "Файл";
            // 
            // mnuFileNewToolStripMenuItem
            // 
            this.mnuFileNewToolStripMenuItem.Name = "mnuFileNewToolStripMenuItem";
            this.mnuFileNewToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.mnuFileNewToolStripMenuItem.Text = "mnuFileNew";
            this.mnuFileNewToolStripMenuItem.Visible = false;
            // 
            // mnuFileOpenToolStripMenuItem
            // 
            this.mnuFileOpenToolStripMenuItem.Name = "mnuFileOpenToolStripMenuItem";
            this.mnuFileOpenToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.mnuFileOpenToolStripMenuItem.Text = "Открыть...";
            this.mnuFileOpenToolStripMenuItem.Click += new System.EventHandler(this.FileOpenToolStripMenuItem_Click);
            // 
            // mnuFileSaveToolStripMenuItem
            // 
            this.mnuFileSaveToolStripMenuItem.Name = "mnuFileSaveToolStripMenuItem";
            this.mnuFileSaveToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.mnuFileSaveToolStripMenuItem.Text = "Сохранить";
            this.mnuFileSaveToolStripMenuItem.Click += new System.EventHandler(this.FileSaveToolStripMenuItem_Click);
            // 
            // mnuFileSaveAsToolStripMenuItem
            // 
            this.mnuFileSaveAsToolStripMenuItem.Name = "mnuFileSaveAsToolStripMenuItem";
            this.mnuFileSaveAsToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.mnuFileSaveAsToolStripMenuItem.Text = "Сохранить как...";
            this.mnuFileSaveAsToolStripMenuItem.Click += new System.EventHandler(this.FileSaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(312, 6);
            // 
            // mnuFileImport
            // 
            this.mnuFileImport.Name = "mnuFileImport";
            this.mnuFileImport.Size = new System.Drawing.Size(315, 26);
            this.mnuFileImport.Text = "Импорт из файла...";
            this.mnuFileImport.Click += new System.EventHandler(this.FileImport_Click);
            // 
            // mnuFileExport
            // 
            this.mnuFileExport.Name = "mnuFileExport";
            this.mnuFileExport.Size = new System.Drawing.Size(315, 26);
            this.mnuFileExport.Text = "Экспорт данных в файл...";
            this.mnuFileExport.Click += new System.EventHandler(this.FileExport_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(312, 6);
            // 
            // mnuFileExportToExcel
            // 
            this.mnuFileExportToExcel.Name = "mnuFileExportToExcel";
            this.mnuFileExportToExcel.Size = new System.Drawing.Size(315, 26);
            this.mnuFileExportToExcel.Text = "Экспорт данных в MS Office Excel";
            this.mnuFileExportToExcel.Click += new System.EventHandler(this.FileExportToExcel_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(312, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(315, 26);
            this.mnuFileExit.Text = "Выход";
            this.mnuFileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // mnuTable
            // 
            this.mnuTable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTableNewOrganization,
            this.mnuTableCreateOrganization,
            this.toolStripMenuItem3,
            this.mnuTableCreateNewVersion,
            this.toolStripMenuItem4,
            this.mnuTableRemoveOrganization,
            this.toolStripMenuItem7,
            this.mnuTableEditError});
            this.mnuTable.Name = "mnuTable";
            this.mnuTable.Size = new System.Drawing.Size(219, 24);
            this.mnuTable.Text = "Справочник подразделений";
            // 
            // mnuTableNewOrganization
            // 
            this.mnuTableNewOrganization.Name = "mnuTableNewOrganization";
            this.mnuTableNewOrganization.Size = new System.Drawing.Size(336, 26);
            this.mnuTableNewOrganization.Text = "Создать запись...";
            this.mnuTableNewOrganization.Click += new System.EventHandler(this.TableNewOrganization_Click);
            // 
            // mnuTableCreateOrganization
            // 
            this.mnuTableCreateOrganization.Name = "mnuTableCreateOrganization";
            this.mnuTableCreateOrganization.Size = new System.Drawing.Size(336, 26);
            this.mnuTableCreateOrganization.Text = "Создать запись на основе текущей...";
            this.mnuTableCreateOrganization.Click += new System.EventHandler(this.TableCreateOrganization_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(333, 6);
            // 
            // mnuTableCreateNewVersion
            // 
            this.mnuTableCreateNewVersion.Name = "mnuTableCreateNewVersion";
            this.mnuTableCreateNewVersion.Size = new System.Drawing.Size(336, 26);
            this.mnuTableCreateNewVersion.Text = "Создать новую версию записи...";
            this.mnuTableCreateNewVersion.Click += new System.EventHandler(this.TableCreateVersion_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(333, 6);
            // 
            // mnuTableRemoveOrganization
            // 
            this.mnuTableRemoveOrganization.Name = "mnuTableRemoveOrganization";
            this.mnuTableRemoveOrganization.Size = new System.Drawing.Size(336, 26);
            this.mnuTableRemoveOrganization.Text = "Заблокировать запись...";
            this.mnuTableRemoveOrganization.Click += new System.EventHandler(this.TableRemoveOrganization_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(333, 6);
            // 
            // mnuTableEditError
            // 
            this.mnuTableEditError.Name = "mnuTableEditError";
            this.mnuTableEditError.Size = new System.Drawing.Size(336, 26);
            this.mnuTableEditError.Text = "Исправить ошибку...";
            this.mnuTableEditError.Click += new System.EventHandler(this.TableEditError_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpStatistic,
            this.toolStripMenuItem5,
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(79, 24);
            this.mnuHelp.Text = "Справка";
            // 
            // mnuHelpStatistic
            // 
            this.mnuHelpStatistic.Name = "mnuHelpStatistic";
            this.mnuHelpStatistic.Size = new System.Drawing.Size(188, 26);
            this.mnuHelpStatistic.Text = "Статистика";
            this.mnuHelpStatistic.Click += new System.EventHandler(this.HelpStatistic_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(185, 6);
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(188, 26);
            this.mnuHelpAbout.Text = "О программе...";
            this.mnuHelpAbout.Click += new System.EventHandler(this.HelpAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rowCountStatusLabel,
            this.selectedRowStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(982, 25);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // rowCountStatusLabel
            // 
            this.rowCountStatusLabel.AutoSize = false;
            this.rowCountStatusLabel.Name = "rowCountStatusLabel";
            this.rowCountStatusLabel.Size = new System.Drawing.Size(200, 20);
            this.rowCountStatusLabel.Text = "##";
            this.rowCountStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectedRowStatusLabel
            // 
            this.selectedRowStatusLabel.Name = "selectedRowStatusLabel";
            this.selectedRowStatusLabel.Size = new System.Drawing.Size(169, 20);
            this.selectedRowStatusLabel.Text = "selectedRowStatusLabel";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.filtrGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 160);
            this.panel1.TabIndex = 3;
            // 
            // filtrGroupBox
            // 
            this.filtrGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filtrGroupBox.Controls.Add(this.filterCodeNumericTextBox);
            this.filtrGroupBox.Controls.Add(this.label1);
            this.filtrGroupBox.Controls.Add(this.label2);
            this.filtrGroupBox.Controls.Add(this.filterNameTextBox);
            this.filtrGroupBox.Controls.Add(this.filterLockCodeViewCheckBox);
            this.filtrGroupBox.Controls.Add(this.okatoLabel);
            this.filtrGroupBox.Controls.Add(this.filterAuthorityComboBox);
            this.filtrGroupBox.Controls.Add(this.filterOkatoComboBox);
            this.filtrGroupBox.Controls.Add(this.authorityLabel);
            this.filtrGroupBox.Location = new System.Drawing.Point(7, 5);
            this.filtrGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filtrGroupBox.Name = "filtrGroupBox";
            this.filtrGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filtrGroupBox.Size = new System.Drawing.Size(667, 153);
            this.filtrGroupBox.TabIndex = 2;
            this.filtrGroupBox.TabStop = false;
            this.filtrGroupBox.Text = "Фильтр";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Наименование подразделения:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Код подразделения:";
            // 
            // filterNameTextBox
            // 
            this.filterNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterNameTextBox.Location = new System.Drawing.Point(173, 114);
            this.filterNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterNameTextBox.Name = "filterNameTextBox";
            this.filterNameTextBox.Size = new System.Drawing.Size(488, 22);
            this.filterNameTextBox.TabIndex = 7;
            this.filterNameTextBox.TextChanged += new System.EventHandler(this.Filter_ParametersChanged);
            // 
            // filterLockCodeViewCheckBox
            // 
            this.filterLockCodeViewCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterLockCodeViewCheckBox.AutoSize = true;
            this.filterLockCodeViewCheckBox.Location = new System.Drawing.Point(446, 57);
            this.filterLockCodeViewCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterLockCodeViewCheckBox.Name = "filterLockCodeViewCheckBox";
            this.filterLockCodeViewCheckBox.Size = new System.Drawing.Size(217, 21);
            this.filterLockCodeViewCheckBox.TabIndex = 5;
            this.filterLockCodeViewCheckBox.Text = "Включить заблокированные";
            this.filterLockCodeViewCheckBox.UseVisualStyleBackColor = true;
            this.filterLockCodeViewCheckBox.CheckedChanged += new System.EventHandler(this.Filter_ParametersChanged);
            // 
            // okatoLabel
            // 
            this.okatoLabel.AutoSize = true;
            this.okatoLabel.Location = new System.Drawing.Point(4, 25);
            this.okatoLabel.Name = "okatoLabel";
            this.okatoLabel.Size = new System.Drawing.Size(90, 17);
            this.okatoLabel.TabIndex = 35;
            this.okatoLabel.Text = "Код ОКАТО:";
            // 
            // authorityLabel
            // 
            this.authorityLabel.AutoSize = true;
            this.authorityLabel.Location = new System.Drawing.Point(4, 57);
            this.authorityLabel.Name = "authorityLabel";
            this.authorityLabel.Size = new System.Drawing.Size(93, 17);
            this.authorityLabel.TabIndex = 0;
            this.authorityLabel.Text = "Вид органов:";
            // 
            // gaspsListView
            // 
            this.gaspsListView.DataSet = null;
            this.gaspsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaspsListView.Location = new System.Drawing.Point(0, 188);
            this.gaspsListView.LockShow = false;
            this.gaspsListView.Margin = new System.Windows.Forms.Padding(5);
            this.gaspsListView.Name = "gaspsListView";
            this.gaspsListView.ReserveShow = true;
            this.gaspsListView.Size = new System.Drawing.Size(982, 340);
            this.gaspsListView.TabIndex = 1;
            this.gaspsListView.UnlockShow = true;
            this.gaspsListView.ItemSelectionChanged += new System.EventHandler(this.gaspsListView_ItemSelectionChanged);
            // 
            // filterCodeNumericTextBox
            // 
            this.filterCodeNumericTextBox.Location = new System.Drawing.Point(7, 114);
            this.filterCodeNumericTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterCodeNumericTextBox.Name = "filterCodeNumericTextBox";
            this.filterCodeNumericTextBox.Size = new System.Drawing.Size(161, 22);
            this.filterCodeNumericTextBox.TabIndex = 6;
            this.filterCodeNumericTextBox.TextChanged += new System.EventHandler(this.Filter_ParametersChanged);
            // 
            // filterAuthorityComboBox
            // 
            this.filterAuthorityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterAuthorityComboBox.Code = "";
            this.filterAuthorityComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterAuthorityComboBox.DropDownHeight = 164;
            this.filterAuthorityComboBox.DropDownWidth = 80;
            this.filterAuthorityComboBox.FormattingEnabled = true;
            this.filterAuthorityComboBox.IntegralHeight = false;
            this.filterAuthorityComboBox.ItemHeight = 20;
            this.filterAuthorityComboBox.Location = new System.Drawing.Point(105, 53);
            this.filterAuthorityComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterAuthorityComboBox.MaxDropDownItems = 20;
            this.filterAuthorityComboBox.Name = "filterAuthorityComboBox";
            this.filterAuthorityComboBox.Size = new System.Drawing.Size(296, 26);
            this.filterAuthorityComboBox.TabIndex = 4;
            this.filterAuthorityComboBox.SelectedIndexChanged += new System.EventHandler(this.Filter_ParametersChanged);
            // 
            // filterOkatoComboBox
            // 
            this.filterOkatoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterOkatoComboBox.Code = "";
            this.filterOkatoComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterOkatoComboBox.DropDownHeight = 164;
            this.filterOkatoComboBox.DropDownWidth = 80;
            this.filterOkatoComboBox.FormattingEnabled = true;
            this.filterOkatoComboBox.IntegralHeight = false;
            this.filterOkatoComboBox.ItemHeight = 20;
            this.filterOkatoComboBox.Location = new System.Drawing.Point(107, 21);
            this.filterOkatoComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterOkatoComboBox.MaxDropDownItems = 20;
            this.filterOkatoComboBox.Name = "filterOkatoComboBox";
            this.filterOkatoComboBox.Size = new System.Drawing.Size(559, 26);
            this.filterOkatoComboBox.TabIndex = 3;
            this.filterOkatoComboBox.SelectedIndexChanged += new System.EventHandler(this.Filter_ParametersChanged);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.gaspsListView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(954, 328);
            this.Name = "AppForm";
            this.Text = "Справочник подразделений правоохранительных органов в НСИ ГАС ПС";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppForm_FormClosing);
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.filtrGroupBox.ResumeLayout(false);
            this.filtrGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileImport;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExport;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox filtrGroupBox;
        private Controls.NumericTextBox filterCodeNumericTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filterNameTextBox;
        private System.Windows.Forms.CheckBox filterLockCodeViewCheckBox;
        private System.Windows.Forms.Label okatoLabel;
        private Controls.AuthorityComboBox filterAuthorityComboBox;
        private Controls.OkatoComboBox filterOkatoComboBox;
        private System.Windows.Forms.Label authorityLabel;
        private Controls.GaspsListView gaspsListView;
        private System.Windows.Forms.ToolStripStatusLabel rowCountStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem mnuTable;
        private System.Windows.Forms.ToolStripMenuItem mnuTableNewOrganization;
        private System.Windows.Forms.ToolStripMenuItem mnuTableCreateOrganization;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuTableCreateNewVersion;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnuTableRemoveOrganization;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpStatistic;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolStripStatusLabel selectedRowStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExportToExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem mnuTableEditError;
    }
}