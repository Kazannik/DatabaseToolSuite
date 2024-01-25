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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTable = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.rowCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.selectedRowStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.cleanFilterButton = new System.Windows.Forms.Button();
            this.filterCodeNumericTextBox = new DatabaseToolSuite.Controls.NumericTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filterNameTextBox = new System.Windows.Forms.TextBox();
            this.filterLockCodeViewCheckBox = new System.Windows.Forms.CheckBox();
            this.okatoLabel = new System.Windows.Forms.Label();
            this.filterAuthorityComboBox = new DatabaseToolSuite.Controls.AuthorityComboBox();
            this.filterOkatoComboBox = new DatabaseToolSuite.Controls.OkatoComboBox();
            this.authorityLabel = new System.Windows.Forms.Label();
            this.gaspsListView = new DatabaseToolSuite.Controls.GaspsListView();
            this.contextMenuTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.mainToolStripBar = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fileSaveButton = new System.Windows.Forms.ToolStripButton();
            this.tableNewOrganizationButton = new System.Windows.Forms.ToolStripButton();
            this.tableCreateOrganizationButton = new System.Windows.Forms.ToolStripButton();
            this.tableCreateNewVersionButton = new System.Windows.Forms.ToolStripButton();
            this.tableRemoveOrganizationButton = new System.Windows.Forms.ToolStripButton();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExportToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTableNewOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTableCreateOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTableCreateNewVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTableRemoveOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTableEditError = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextNewOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextCreateOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextCreateNewVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextRemoveOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextEditError = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            this.contextMenuTable.SuspendLayout();
            this.mainToolStripBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTable,
            this.mnuHelp});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(982, 28);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "Основное";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSaveAs,
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
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(315, 26);
            this.mnuFileNew.Text = "mnuFileNew";
            this.mnuFileNew.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(312, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(312, 6);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(312, 6);
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
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(333, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(333, 6);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(333, 6);
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
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(185, 6);
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
            // filterPanel
            // 
            this.filterPanel.AutoScroll = true;
            this.filterPanel.BackColor = System.Drawing.SystemColors.Window;
            this.filterPanel.Controls.Add(this.filterGroupBox);
            this.filterPanel.Location = new System.Drawing.Point(0, 70);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(4);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(982, 160);
            this.filterPanel.TabIndex = 3;
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterGroupBox.Controls.Add(this.cleanFilterButton);
            this.filterGroupBox.Controls.Add(this.filterCodeNumericTextBox);
            this.filterGroupBox.Controls.Add(this.label1);
            this.filterGroupBox.Controls.Add(this.label2);
            this.filterGroupBox.Controls.Add(this.filterNameTextBox);
            this.filterGroupBox.Controls.Add(this.filterLockCodeViewCheckBox);
            this.filterGroupBox.Controls.Add(this.okatoLabel);
            this.filterGroupBox.Controls.Add(this.filterAuthorityComboBox);
            this.filterGroupBox.Controls.Add(this.filterOkatoComboBox);
            this.filterGroupBox.Controls.Add(this.authorityLabel);
            this.filterGroupBox.Location = new System.Drawing.Point(7, 5);
            this.filterGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterGroupBox.Size = new System.Drawing.Size(667, 153);
            this.filterGroupBox.TabIndex = 2;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Фильтр";
            // 
            // cleanFilterButton
            // 
            this.cleanFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cleanFilterButton.Location = new System.Drawing.Point(560, 112);
            this.cleanFilterButton.Margin = new System.Windows.Forms.Padding(4);
            this.cleanFilterButton.Name = "cleanFilterButton";
            this.cleanFilterButton.Size = new System.Drawing.Size(100, 27);
            this.cleanFilterButton.TabIndex = 8;
            this.cleanFilterButton.Text = "Очистить";
            this.cleanFilterButton.Click += new System.EventHandler(this.cleanFilterButton_Click);
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
            this.filterNameTextBox.Size = new System.Drawing.Size(380, 22);
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
            this.filterOkatoComboBox.Size = new System.Drawing.Size(553, 26);
            this.filterOkatoComboBox.TabIndex = 3;
            this.filterOkatoComboBox.SelectedIndexChanged += new System.EventHandler(this.Filter_ParametersChanged);
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
            this.gaspsListView.Location = new System.Drawing.Point(0, 239);
            this.gaspsListView.LockShow = false;
            this.gaspsListView.Margin = new System.Windows.Forms.Padding(5);
            this.gaspsListView.Name = "gaspsListView";
            this.gaspsListView.ReserveShow = true;
            this.gaspsListView.Size = new System.Drawing.Size(982, 289);
            this.gaspsListView.TabIndex = 1;
            this.gaspsListView.UnlockShow = true;
            this.gaspsListView.ItemSelectionChanged += new System.EventHandler(this.gaspsListView_ItemSelectionChanged);
            this.gaspsListView.ItemMouseClick += new System.EventHandler<DatabaseToolSuite.Controls.GaspsListViewEventArgs>(this.gaspsListView_ItemMouseClick);
            // 
            // contextMenuTable
            // 
            this.contextMenuTable.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContextNewOrganization,
            this.mnuContextCreateOrganization,
            this.toolStripMenuItem8,
            this.mnuContextCreateNewVersion,
            this.toolStripMenuItem9,
            this.mnuContextRemoveOrganization,
            this.toolStripMenuItem10,
            this.mnuContextEditError});
            this.contextMenuTable.Name = "contextMenuTable";
            this.contextMenuTable.Size = new System.Drawing.Size(339, 172);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(335, 6);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(335, 6);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(335, 6);
            // 
            // mainToolStripBar
            // 
            this.mainToolStripBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStripBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainToolStripBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileSaveButton,
            this.toolStripSeparator1,
            this.tableNewOrganizationButton,
            this.tableCreateOrganizationButton,
            this.toolStripSeparator2,
            this.tableCreateNewVersionButton,
            this.toolStripSeparator3,
            this.tableRemoveOrganizationButton});
            this.mainToolStripBar.Location = new System.Drawing.Point(0, 28);
            this.mainToolStripBar.Name = "mainToolStripBar";
            this.mainToolStripBar.Size = new System.Drawing.Size(982, 39);
            this.mainToolStripBar.TabIndex = 9;
            this.mainToolStripBar.Text = "Стандартная";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // fileSaveButton
            // 
            this.fileSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fileSaveButton.Image = global::DatabaseToolSuite.Properties.Resources.Save32;
            this.fileSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileSaveButton.Name = "fileSaveButton";
            this.fileSaveButton.Size = new System.Drawing.Size(36, 36);
            this.fileSaveButton.Text = "Сохранить файл";
            this.fileSaveButton.Click += new System.EventHandler(this.FileSaveToolStripMenuItem_Click);
            // 
            // tableNewOrganizationButton
            // 
            this.tableNewOrganizationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableNewOrganizationButton.Image = global::DatabaseToolSuite.Properties.Resources.New32;
            this.tableNewOrganizationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tableNewOrganizationButton.Name = "tableNewOrganizationButton";
            this.tableNewOrganizationButton.Size = new System.Drawing.Size(36, 36);
            this.tableNewOrganizationButton.Text = "Создать запись...";
            this.tableNewOrganizationButton.Click += new System.EventHandler(this.TableNewOrganization_Click);
            // 
            // tableCreateOrganizationButton
            // 
            this.tableCreateOrganizationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableCreateOrganizationButton.Image = global::DatabaseToolSuite.Properties.Resources.NewSeries32;
            this.tableCreateOrganizationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tableCreateOrganizationButton.Name = "tableCreateOrganizationButton";
            this.tableCreateOrganizationButton.Size = new System.Drawing.Size(36, 36);
            this.tableCreateOrganizationButton.Text = "Создать запись на основе текущей...";
            this.tableCreateOrganizationButton.Click += new System.EventHandler(this.TableCreateOrganization_Click);
            // 
            // tableCreateNewVersionButton
            // 
            this.tableCreateNewVersionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableCreateNewVersionButton.Image = global::DatabaseToolSuite.Properties.Resources.Duplicate32;
            this.tableCreateNewVersionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tableCreateNewVersionButton.Name = "tableCreateNewVersionButton";
            this.tableCreateNewVersionButton.Size = new System.Drawing.Size(36, 36);
            this.tableCreateNewVersionButton.Text = "Создать новую версию записи...";
            this.tableCreateNewVersionButton.Click += new System.EventHandler(this.TableCreateVersion_Click);
            // 
            // tableRemoveOrganizationButton
            // 
            this.tableRemoveOrganizationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableRemoveOrganizationButton.Image = global::DatabaseToolSuite.Properties.Resources.Delete32;
            this.tableRemoveOrganizationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tableRemoveOrganizationButton.Name = "tableRemoveOrganizationButton";
            this.tableRemoveOrganizationButton.Size = new System.Drawing.Size(36, 36);
            this.tableRemoveOrganizationButton.Text = "Заблокировать запись...";
            this.tableRemoveOrganizationButton.Click += new System.EventHandler(this.TableRemoveOrganization_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Image = global::DatabaseToolSuite.Properties.Resources.Open24;
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(315, 26);
            this.mnuFileOpen.Text = "Открыть...";
            this.mnuFileOpen.Click += new System.EventHandler(this.FileOpenToolStripMenuItem_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Image = global::DatabaseToolSuite.Properties.Resources.Save24;
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(315, 26);
            this.mnuFileSave.Text = "Сохранить";
            this.mnuFileSave.Click += new System.EventHandler(this.FileSaveToolStripMenuItem_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Image = global::DatabaseToolSuite.Properties.Resources.SaveAs24;
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(315, 26);
            this.mnuFileSaveAs.Text = "Сохранить как...";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.FileSaveAsToolStripMenuItem_Click);
            // 
            // mnuFileImport
            // 
            this.mnuFileImport.Image = global::DatabaseToolSuite.Properties.Resources.ImportTextFile24;
            this.mnuFileImport.Name = "mnuFileImport";
            this.mnuFileImport.Size = new System.Drawing.Size(315, 26);
            this.mnuFileImport.Text = "Импорт из файла...";
            this.mnuFileImport.Click += new System.EventHandler(this.FileImport_Click);
            // 
            // mnuFileExport
            // 
            this.mnuFileExport.Image = global::DatabaseToolSuite.Properties.Resources.ExportXmlFile24;
            this.mnuFileExport.Name = "mnuFileExport";
            this.mnuFileExport.Size = new System.Drawing.Size(315, 26);
            this.mnuFileExport.Text = "Экспорт данных в файл...";
            this.mnuFileExport.Click += new System.EventHandler(this.FileExport_Click);
            // 
            // mnuFileExportToExcel
            // 
            this.mnuFileExportToExcel.Image = global::DatabaseToolSuite.Properties.Resources.ExportExcel24;
            this.mnuFileExportToExcel.Name = "mnuFileExportToExcel";
            this.mnuFileExportToExcel.Size = new System.Drawing.Size(315, 26);
            this.mnuFileExportToExcel.Text = "Экспорт данных в MS Office Excel";
            this.mnuFileExportToExcel.Click += new System.EventHandler(this.FileExportToExcel_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Image = global::DatabaseToolSuite.Properties.Resources.FileExit24;
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(315, 26);
            this.mnuFileExit.Text = "Выход";
            this.mnuFileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // mnuTableNewOrganization
            // 
            this.mnuTableNewOrganization.Image = global::DatabaseToolSuite.Properties.Resources.New24;
            this.mnuTableNewOrganization.Name = "mnuTableNewOrganization";
            this.mnuTableNewOrganization.Size = new System.Drawing.Size(336, 26);
            this.mnuTableNewOrganization.Text = "Создать запись...";
            this.mnuTableNewOrganization.Click += new System.EventHandler(this.TableNewOrganization_Click);
            // 
            // mnuTableCreateOrganization
            // 
            this.mnuTableCreateOrganization.Image = global::DatabaseToolSuite.Properties.Resources.NewSeries24;
            this.mnuTableCreateOrganization.Name = "mnuTableCreateOrganization";
            this.mnuTableCreateOrganization.Size = new System.Drawing.Size(336, 26);
            this.mnuTableCreateOrganization.Text = "Создать запись на основе текущей...";
            this.mnuTableCreateOrganization.Click += new System.EventHandler(this.TableCreateOrganization_Click);
            // 
            // mnuTableCreateNewVersion
            // 
            this.mnuTableCreateNewVersion.Image = global::DatabaseToolSuite.Properties.Resources.Duplicate24;
            this.mnuTableCreateNewVersion.Name = "mnuTableCreateNewVersion";
            this.mnuTableCreateNewVersion.Size = new System.Drawing.Size(336, 26);
            this.mnuTableCreateNewVersion.Text = "Создать новую версию записи...";
            this.mnuTableCreateNewVersion.Click += new System.EventHandler(this.TableCreateVersion_Click);
            // 
            // mnuTableRemoveOrganization
            // 
            this.mnuTableRemoveOrganization.Image = global::DatabaseToolSuite.Properties.Resources.Delete24;
            this.mnuTableRemoveOrganization.Name = "mnuTableRemoveOrganization";
            this.mnuTableRemoveOrganization.Size = new System.Drawing.Size(336, 26);
            this.mnuTableRemoveOrganization.Text = "Заблокировать запись...";
            this.mnuTableRemoveOrganization.Click += new System.EventHandler(this.TableRemoveOrganization_Click);
            // 
            // mnuTableEditError
            // 
            this.mnuTableEditError.Image = global::DatabaseToolSuite.Properties.Resources.Edit24;
            this.mnuTableEditError.Name = "mnuTableEditError";
            this.mnuTableEditError.Size = new System.Drawing.Size(336, 26);
            this.mnuTableEditError.Text = "Исправить ошибку...";
            this.mnuTableEditError.Click += new System.EventHandler(this.TableEditError_Click);
            // 
            // mnuHelpStatistic
            // 
            this.mnuHelpStatistic.Image = global::DatabaseToolSuite.Properties.Resources.Statistics24;
            this.mnuHelpStatistic.Name = "mnuHelpStatistic";
            this.mnuHelpStatistic.Size = new System.Drawing.Size(188, 26);
            this.mnuHelpStatistic.Text = "Статистика";
            this.mnuHelpStatistic.Click += new System.EventHandler(this.HelpStatistic_Click);
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Image = global::DatabaseToolSuite.Properties.Resources.About24;
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(188, 26);
            this.mnuHelpAbout.Text = "О программе...";
            this.mnuHelpAbout.Click += new System.EventHandler(this.HelpAbout_Click);
            // 
            // mnuContextNewOrganization
            // 
            this.mnuContextNewOrganization.Image = global::DatabaseToolSuite.Properties.Resources.New24;
            this.mnuContextNewOrganization.Name = "mnuContextNewOrganization";
            this.mnuContextNewOrganization.Size = new System.Drawing.Size(338, 30);
            this.mnuContextNewOrganization.Text = "Создать запись...";
            this.mnuContextNewOrganization.Click += new System.EventHandler(this.TableNewOrganization_Click);
            // 
            // mnuContextCreateOrganization
            // 
            this.mnuContextCreateOrganization.Image = global::DatabaseToolSuite.Properties.Resources.NewSeries24;
            this.mnuContextCreateOrganization.Name = "mnuContextCreateOrganization";
            this.mnuContextCreateOrganization.Size = new System.Drawing.Size(338, 30);
            this.mnuContextCreateOrganization.Text = "Создать запись на основе текущей...";
            this.mnuContextCreateOrganization.Click += new System.EventHandler(this.TableCreateOrganization_Click);
            // 
            // mnuContextCreateNewVersion
            // 
            this.mnuContextCreateNewVersion.Image = global::DatabaseToolSuite.Properties.Resources.Duplicate24;
            this.mnuContextCreateNewVersion.Name = "mnuContextCreateNewVersion";
            this.mnuContextCreateNewVersion.Size = new System.Drawing.Size(338, 30);
            this.mnuContextCreateNewVersion.Text = "Создать новую версию записи...";
            this.mnuContextCreateNewVersion.Click += new System.EventHandler(this.TableCreateVersion_Click);
            // 
            // mnuContextRemoveOrganization
            // 
            this.mnuContextRemoveOrganization.Image = global::DatabaseToolSuite.Properties.Resources.Delete24;
            this.mnuContextRemoveOrganization.Name = "mnuContextRemoveOrganization";
            this.mnuContextRemoveOrganization.Size = new System.Drawing.Size(338, 30);
            this.mnuContextRemoveOrganization.Text = "Заблокировать запись...";
            this.mnuContextRemoveOrganization.Click += new System.EventHandler(this.TableRemoveOrganization_Click);
            // 
            // mnuContextEditError
            // 
            this.mnuContextEditError.Image = global::DatabaseToolSuite.Properties.Resources.Edit24;
            this.mnuContextEditError.Name = "mnuContextEditError";
            this.mnuContextEditError.Size = new System.Drawing.Size(338, 30);
            this.mnuContextEditError.Text = "Исправить ошибку...";
            this.mnuContextEditError.Click += new System.EventHandler(this.TableEditError_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.mainToolStripBar);
            this.Controls.Add(this.gaspsListView);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(954, 328);
            this.Name = "AppForm";
            this.Text = "Справочник подразделений правоохранительных органов в НСИ ГАС ПС";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppForm_FormClosing);
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.Resize += new System.EventHandler(this.AppForm_Resize);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.filterPanel.ResumeLayout(false);
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.contextMenuTable.ResumeLayout(false);
            this.mainToolStripBar.ResumeLayout(false);
            this.mainToolStripBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileImport;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExport;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.GroupBox filterGroupBox;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuTable;
        private System.Windows.Forms.ToolStripMenuItem mnuContextNewOrganization;
        private System.Windows.Forms.ToolStripMenuItem mnuContextCreateOrganization;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem mnuContextCreateNewVersion;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem mnuContextRemoveOrganization;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem mnuContextEditError;
        protected System.Windows.Forms.Button cleanFilterButton;
        private System.Windows.Forms.ToolStrip mainToolStripBar;
        private System.Windows.Forms.ToolStripButton fileSaveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tableNewOrganizationButton;
        private System.Windows.Forms.ToolStripButton tableCreateOrganizationButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tableCreateNewVersionButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tableRemoveOrganizationButton;
    }
}