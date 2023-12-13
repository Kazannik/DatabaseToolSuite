namespace DatabaseToolSuite.Dialogs
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuBar = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolBar = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.mainStatusBar = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.toolsToolBar = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditPastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditSelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditFindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuBar.SuspendLayout();
            this.mainToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.toolsToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuBar
            // 
            this.mainMenuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView,
            this.mnuDatabase,
            this.mnuTools,
            this.mnuHelp});
            this.mainMenuBar.Location = new System.Drawing.Point(0, 0);
            this.mainMenuBar.Name = "mainMenuBar";
            this.mainMenuBar.Size = new System.Drawing.Size(1118, 33);
            this.mainMenuBar.TabIndex = 0;
            this.mainMenuBar.Text = "Основная";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(65, 29);
            this.mnuFile.Text = "&Файл";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(210, 30);
            this.mnuFileExit.Text = "Выход";
            // 
            // mainToolBar
            // 
            this.mainToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.mainToolBar.Location = new System.Drawing.Point(0, 33);
            this.mainToolBar.Name = "mainToolBar";
            this.mainToolBar.Size = new System.Drawing.Size(1118, 31);
            this.mainToolBar.TabIndex = 1;
            this.mainToolBar.Text = "Стандартная";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // mainStatusBar
            // 
            this.mainStatusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainStatusBar.Location = new System.Drawing.Point(0, 433);
            this.mainStatusBar.Name = "mainStatusBar";
            this.mainStatusBar.Size = new System.Drawing.Size(1118, 22);
            this.mainStatusBar.TabIndex = 2;
            this.mainStatusBar.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 64);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolsToolBar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mainDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1118, 369);
            this.splitContainer1.SplitterDistance = 198;
            this.splitContainer1.TabIndex = 3;
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDataGridView.Location = new System.Drawing.Point(0, 0);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.RowTemplate.Height = 28;
            this.mainDataGridView.Size = new System.Drawing.Size(916, 369);
            this.mainDataGridView.TabIndex = 0;
            // 
            // toolsToolBar
            // 
            this.toolsToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsToolBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolsToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2});
            this.toolsToolBar.Location = new System.Drawing.Point(0, 0);
            this.toolsToolBar.Name = "toolsToolBar";
            this.toolsToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolsToolBar.Size = new System.Drawing.Size(198, 31);
            this.toolsToolBar.TabIndex = 0;
            this.toolsToolBar.Text = "Дополнительная";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditCutToolStripMenuItem,
            this.mnuEditCopyToolStripMenuItem,
            this.mnuEditPastToolStripMenuItem,
            this.mnuEditDeleteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mnuEditSelectAllToolStripMenuItem,
            this.toolStripMenuItem2,
            this.mnuEditFindToolStripMenuItem});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(85, 29);
            this.mnuEdit.Text = "&Правка";
            // 
            // mnuView
            // 
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(54, 29);
            this.mnuView.Text = "&Вид";
            // 
            // mnuDatabase
            // 
            this.mnuDatabase.Name = "mnuDatabase";
            this.mnuDatabase.Size = new System.Drawing.Size(125, 29);
            this.mnuDatabase.Text = "База &данных";
            // 
            // mnuTools
            // 
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(83, 29);
            this.mnuTools.Text = "С&ервис";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(93, 29);
            this.mnuHelp.Text = "Справ&ка";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(221, 30);
            this.mnuHelpAbout.Text = "&О программе...";
            // 
            // mnuEditCutToolStripMenuItem
            // 
            this.mnuEditCutToolStripMenuItem.Name = "mnuEditCutToolStripMenuItem";
            this.mnuEditCutToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.mnuEditCutToolStripMenuItem.Text = "mnuEditCut";
            // 
            // mnuEditCopyToolStripMenuItem
            // 
            this.mnuEditCopyToolStripMenuItem.Name = "mnuEditCopyToolStripMenuItem";
            this.mnuEditCopyToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.mnuEditCopyToolStripMenuItem.Text = "mnuEditCopy";
            // 
            // mnuEditPastToolStripMenuItem
            // 
            this.mnuEditPastToolStripMenuItem.Name = "mnuEditPastToolStripMenuItem";
            this.mnuEditPastToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.mnuEditPastToolStripMenuItem.Text = "mnuEditPast";
            // 
            // mnuEditDeleteToolStripMenuItem
            // 
            this.mnuEditDeleteToolStripMenuItem.Name = "mnuEditDeleteToolStripMenuItem";
            this.mnuEditDeleteToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.mnuEditDeleteToolStripMenuItem.Text = "mnuEditDelete";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 6);
            // 
            // mnuEditSelectAllToolStripMenuItem
            // 
            this.mnuEditSelectAllToolStripMenuItem.Name = "mnuEditSelectAllToolStripMenuItem";
            this.mnuEditSelectAllToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.mnuEditSelectAllToolStripMenuItem.Text = "mnuEditSelectAll";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(225, 6);
            // 
            // mnuEditFindToolStripMenuItem
            // 
            this.mnuEditFindToolStripMenuItem.Name = "mnuEditFindToolStripMenuItem";
            this.mnuEditFindToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.mnuEditFindToolStripMenuItem.Text = "mnuEditFind";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 455);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mainStatusBar);
            this.Controls.Add(this.mainToolBar);
            this.Controls.Add(this.mainMenuBar);
            this.MainMenuStrip = this.mainMenuBar;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.mainMenuBar.ResumeLayout(false);
            this.mainMenuBar.PerformLayout();
            this.mainToolBar.ResumeLayout(false);
            this.mainToolBar.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.toolsToolBar.ResumeLayout(false);
            this.toolsToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStrip mainToolBar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip mainStatusBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.ToolStrip toolsToolBar;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuDatabase;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEditPastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEditDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuEditSelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuEditFindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
    }
}