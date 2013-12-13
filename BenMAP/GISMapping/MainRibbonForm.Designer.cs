﻿namespace BenMAP
{
    partial class MainRibbonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRibbonForm));
            this.ribbon1 = new DotSpatial.Controls.RibbonControls.Ribbon();
            this.ribbonButton1 = new DotSpatial.Controls.RibbonControls.RibbonButton();
            this.ribbonTab1 = new DotSpatial.Controls.RibbonControls.RibbonTab();
            this.orbNewProject = new DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem();
            this.orbOpenProject = new DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem();
            this.orbSaveProject = new DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem();
            this.orbSaveProjectAs = new DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem();
            this.orbPrintLayout = new DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem();
            this.orbExtensions = new DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem();
            this.orbApplicationSettings = new DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem();
            this.orbAbout = new DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem();
            this.orbExit = new DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem();
            this.spatialStatusStrip1 = new DotSpatial.Controls.SpatialStatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.appManager1 = new DotSpatial.Controls.AppManager();
            this.legend1 = new DotSpatial.Controls.Legend();
            this.mainMap = new DotSpatial.Controls.Map();
            this.spatialTabControl1 = new DotSpatial.Controls.SpatialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbReference = new System.Windows.Forms.ComboBox();
            this.ribbonOrbMenuItem1 = new DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem();
            this.spatialStatusStrip1.SuspendLayout();
            this.spatialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.BorderMode = DotSpatial.Controls.RibbonControls.RibbonWindowMode.NonClientAreaGlass;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.AltKey = null;
            this.ribbon1.QuickAcessToolbar.Image = null;
            this.ribbon1.QuickAcessToolbar.Items.Add(this.ribbonButton1);
            this.ribbon1.QuickAcessToolbar.Tag = null;
            this.ribbon1.QuickAcessToolbar.Text = null;
            this.ribbon1.QuickAcessToolbar.ToolTip = null;
            this.ribbon1.QuickAcessToolbar.ToolTipImage = null;
            this.ribbon1.QuickAcessToolbar.ToolTipTitle = null;
            this.ribbon1.QuickAcessToolbar.Value = null;
            this.ribbon1.Size = new System.Drawing.Size(716, 125);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.TabSpacing = 6;
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.AltKey = null;
            this.ribbonButton1.DropDownArrowDirection = DotSpatial.Controls.RibbonControls.RibbonArrowDirection.Down;
            this.ribbonButton1.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.MaxSizeMode = DotSpatial.Controls.RibbonControls.RibbonElementSizeMode.Compact;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Style = DotSpatial.Controls.RibbonControls.RibbonButtonStyle.Normal;
            this.ribbonButton1.Tag = null;
            this.ribbonButton1.Text = "ribbonButton1";
            this.ribbonButton1.ToolTip = null;
            this.ribbonButton1.ToolTipImage = null;
            this.ribbonButton1.ToolTipTitle = null;
            this.ribbonButton1.Value = null;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Tag = null;
            this.ribbonTab1.Text = "Home";
            // 
            // orbNewProject
            // 
            this.orbNewProject.AltKey = null;
            this.orbNewProject.DropDownArrowDirection = DotSpatial.Controls.RibbonControls.RibbonArrowDirection.Left;
            this.orbNewProject.DropDownArrowSize = new System.Drawing.Size(5, 3);
            //this.orbNewProject.Image = global::BenMAP.Properties.Resources.new_file;
            //this.orbNewProject.SmallImage = global::BenMAP.Properties.Resources.new_file;
            this.orbNewProject.Style = DotSpatial.Controls.RibbonControls.RibbonButtonStyle.Normal;
            this.orbNewProject.Tag = null;
            this.orbNewProject.Text = "New Project";
            this.orbNewProject.ToolTip = null;
            this.orbNewProject.ToolTipImage = null;
            this.orbNewProject.ToolTipTitle = null;
            this.orbNewProject.Value = null;
            //this.orbNewProject.Click += new System.EventHandler(this.orbNewProject_Click);
            // 
            // orbOpenProject
            // 
            this.orbOpenProject.AltKey = null;
            this.orbOpenProject.DropDownArrowDirection = DotSpatial.Controls.RibbonControls.RibbonArrowDirection.Left;
            this.orbOpenProject.DropDownArrowSize = new System.Drawing.Size(5, 3);
            //this.orbOpenProject.Image = global::BenMAP.Properties.Resources.open_file;
            //this.orbOpenProject.SmallImage = global::BenMAP.Properties.Resources.open_file;
            this.orbOpenProject.Style = DotSpatial.Controls.RibbonControls.RibbonButtonStyle.Normal;
            this.orbOpenProject.Tag = null;
            this.orbOpenProject.Text = "Open Project";
            this.orbOpenProject.ToolTip = null;
            this.orbOpenProject.ToolTipImage = null;
            this.orbOpenProject.ToolTipTitle = null;
            this.orbOpenProject.Value = null;
            //this.orbOpenProject.Click += new System.EventHandler(this.orbOpenProject_Click);
            // 
            // orbSaveProject
            // 
            this.orbSaveProject.AltKey = null;
            this.orbSaveProject.DropDownArrowDirection = DotSpatial.Controls.RibbonControls.RibbonArrowDirection.Left;
            this.orbSaveProject.DropDownArrowSize = new System.Drawing.Size(5, 3);
            //this.orbSaveProject.Image = global::BenMAP.Properties.Resources.save_file;
            //this.orbSaveProject.SmallImage = global::BenMAP.Properties.Resources.save_file;
            this.orbSaveProject.Style = DotSpatial.Controls.RibbonControls.RibbonButtonStyle.Normal;
            this.orbSaveProject.Tag = null;
            this.orbSaveProject.Text = "Save Project";
            this.orbSaveProject.ToolTip = null;
            this.orbSaveProject.ToolTipImage = null;
            this.orbSaveProject.ToolTipTitle = null;
            this.orbSaveProject.Value = null;
            //this.orbSaveProject.Click += new System.EventHandler(this.orbSaveProject_Click);
            // 
            // orbSaveProjectAs
            // 
            this.orbSaveProjectAs.AltKey = null;
            this.orbSaveProjectAs.DropDownArrowDirection = DotSpatial.Controls.RibbonControls.RibbonArrowDirection.Left;
            this.orbSaveProjectAs.DropDownArrowSize = new System.Drawing.Size(5, 3);
            //this.orbSaveProjectAs.Image = global::BenMAP.Properties.Resources.save_as;
            //this.orbSaveProjectAs.SmallImage = global::BenMAP.Properties.Resources.save_as;
            this.orbSaveProjectAs.Style = DotSpatial.Controls.RibbonControls.RibbonButtonStyle.Normal;
            this.orbSaveProjectAs.Tag = null;
            this.orbSaveProjectAs.Text = "Save Project As";
            this.orbSaveProjectAs.ToolTip = null;
            this.orbSaveProjectAs.ToolTipImage = null;
            this.orbSaveProjectAs.ToolTipTitle = null;
            this.orbSaveProjectAs.Value = null;
            //this.orbSaveProjectAs.Click += new System.EventHandler(this.orbSaveProjectAs_Click);
            // 
            // orbPrintLayout
            // 
            this.orbPrintLayout.AltKey = null;
            this.orbPrintLayout.DropDownArrowDirection = DotSpatial.Controls.RibbonControls.RibbonArrowDirection.Left;
            this.orbPrintLayout.DropDownArrowSize = new System.Drawing.Size(5, 3);
            //this.orbPrintLayout.Image = global::BenMAP.Properties.Resources.print;
            //this.orbPrintLayout.SmallImage = global::BenMAP.Properties.Resources.print;
            this.orbPrintLayout.Style = DotSpatial.Controls.RibbonControls.RibbonButtonStyle.Normal;
            this.orbPrintLayout.Tag = null;
            this.orbPrintLayout.Text = "Print";
            this.orbPrintLayout.ToolTip = null;
            this.orbPrintLayout.ToolTipImage = null;
            this.orbPrintLayout.ToolTipTitle = null;
            this.orbPrintLayout.Value = null;
            //this.orbPrintLayout.Click += new System.EventHandler(this.orbPrintLayout_Click);
            // 
            // orbExtensions
            // 
            this.orbExtensions.AltKey = null;
            this.orbExtensions.DropDownArrowDirection = DotSpatial.Controls.RibbonControls.RibbonArrowDirection.Left;
            this.orbExtensions.DropDownArrowSize = new System.Drawing.Size(5, 3);
            //this.orbExtensions.Image = global::BenMAP.Properties.Resources.extensions32;
            //this.orbExtensions.SmallImage = global::BenMAP.Properties.Resources.extensions32;
            this.orbExtensions.Style = DotSpatial.Controls.RibbonControls.RibbonButtonStyle.Normal;
            this.orbExtensions.Tag = null;
            this.orbExtensions.Text = "Extensions";
            this.orbExtensions.ToolTip = null;
            this.orbExtensions.ToolTipImage = null;
            this.orbExtensions.ToolTipTitle = null;
            this.orbExtensions.Value = null;
            //this.orbExtensions.Click += new System.EventHandler(this.orbExtensions_Click);
            // 
            // orbApplicationSettings
            // 
            this.orbApplicationSettings.AltKey = null;
            this.orbApplicationSettings.DropDownArrowDirection = DotSpatial.Controls.RibbonControls.RibbonArrowDirection.Left;
            this.orbApplicationSettings.DropDownArrowSize = new System.Drawing.Size(5, 3);
            //this.orbApplicationSettings.Image = global::BenMAP.Properties.Resources.settings;
            //this.orbApplicationSettings.SmallImage = global::BenMAP.Properties.Resources.settings;
            this.orbApplicationSettings.Style = DotSpatial.Controls.RibbonControls.RibbonButtonStyle.Normal;
            this.orbApplicationSettings.Tag = null;
            this.orbApplicationSettings.Text = "Application Settings";
            this.orbApplicationSettings.ToolTip = null;
            this.orbApplicationSettings.ToolTipImage = null;
            this.orbApplicationSettings.ToolTipTitle = null;
            this.orbApplicationSettings.Value = null;
            //this.orbApplicationSettings.Click += new System.EventHandler(this.orbApplicationSettings_Click);
            // 
            // orbAbout
            // 
            this.orbAbout.AltKey = null;
            this.orbAbout.DropDownArrowDirection = DotSpatial.Controls.RibbonControls.RibbonArrowDirection.Left;
            this.orbAbout.DropDownArrowSize = new System.Drawing.Size(5, 3);
            //this.orbAbout.Image = global::BenMAP.Properties.Resources.identifier;
            //this.orbAbout.SmallImage = global::BenMAP.Properties.Resources.identifier;
            this.orbAbout.Style = DotSpatial.Controls.RibbonControls.RibbonButtonStyle.Normal;
            this.orbAbout.Tag = null;
            this.orbAbout.Text = "About";
            this.orbAbout.ToolTip = null;
            this.orbAbout.ToolTipImage = null;
            this.orbAbout.ToolTipTitle = null;
            this.orbAbout.Value = null;
            //this.orbAbout.Click += new System.EventHandler(this.orbAbout_Click);
            // 
            // orbExit
            // 
            this.orbExit.AltKey = null;
            this.orbExit.DropDownArrowDirection = DotSpatial.Controls.RibbonControls.RibbonArrowDirection.Left;
            this.orbExit.DropDownArrowSize = new System.Drawing.Size(5, 3);
            //this.orbExit.Image = global::BenMAP.Properties.Resources.delete;
            //this.orbExit.SmallImage = global::BenMAP.Properties.Resources.delete;
            this.orbExit.Style = DotSpatial.Controls.RibbonControls.RibbonButtonStyle.Normal;
            this.orbExit.Tag = null;
            this.orbExit.Text = "Exit";
            this.orbExit.ToolTip = null;
            this.orbExit.ToolTipImage = null;
            this.orbExit.ToolTipTitle = null;
            this.orbExit.Value = null;
            //this.orbExit.Click += new System.EventHandler(this.orbExit_Click);
            // 
            // spatialStatusStrip1
            // 
            this.spatialStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.progressBar1});
            this.spatialStatusStrip1.Location = new System.Drawing.Point(0, 488);
            this.spatialStatusStrip1.Name = "spatialStatusStrip1";
            this.spatialStatusStrip1.ProgressBar = null;
            this.spatialStatusStrip1.ProgressLabel = this.lblStatus;
            this.spatialStatusStrip1.Size = new System.Drawing.Size(716, 22);
            this.spatialStatusStrip1.TabIndex = 1;
            this.spatialStatusStrip1.Text = "spatialStatusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(86, 17);
            this.lblStatus.Text = "Current Layer";
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 16);
            this.progressBar1.Visible = false;
            // 
            // appManager1
            // 
            this.appManager1.AppEnableMethod = DotSpatial.Controls.AppEnableMethod.RibbonButton;
            this.appManager1.DataManager.DataProviderDirectories = ((System.Collections.Generic.List<string>)(resources.GetObject("appManager1.DataManager.DataProviderDirectories")));
            this.appManager1.DataManager.LoadInRam = true;
            this.appManager1.DataManager.ProgressHandler = null;
            this.appManager1.Directories = ((System.Collections.Generic.List<string>)(resources.GetObject("appManager1.Directories")));
            this.appManager1.LayoutControl = null;
            this.appManager1.Legend = this.legend1;
            this.appManager1.MainMenu = null;
            this.appManager1.MainToolStrip = this.spatialStatusStrip1;
            this.appManager1.Map = this.mainMap;
            this.appManager1.ProgressHandler = null;
            this.appManager1.Ribbon = this.ribbon1;
            this.appManager1.TabManager = this.spatialTabControl1;
            this.appManager1.ToolManager = null;
            this.appManager1.ToolStripContainer = null;
            // 
            // legend1
            // 
            this.legend1.BackColor = System.Drawing.Color.White;
            this.legend1.ControlRectangle = new System.Drawing.Rectangle(0, 0, 174, 329);
            this.legend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legend1.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 168, 284);
            this.legend1.HorizontalScrollEnabled = true;
            this.legend1.Indentation = 30;
            this.legend1.IsInitialized = false;
            this.legend1.Location = new System.Drawing.Point(0, 0);
            this.legend1.MinimumSize = new System.Drawing.Size(5, 5);
            this.legend1.Name = "legend1";
            this.legend1.ProgressHandler = null;
            this.legend1.ResetOnResize = false;
            this.legend1.SelectionFontColor = System.Drawing.Color.Black;
            this.legend1.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.legend1.Size = new System.Drawing.Size(174, 329);
            this.legend1.TabIndex = 0;
            this.legend1.Text = "legend1";
            this.legend1.VerticalScrollEnabled = true;
            // 
            // mainMap
            // 
            this.mainMap.AllowDrop = true;
            this.mainMap.BackColor = System.Drawing.Color.White;
            this.mainMap.CollectAfterDraw = false;
            this.mainMap.CollisionDetection = false;
            this.mainMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMap.ExtendBuffer = false;
            this.mainMap.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.mainMap.IsBusy = false;
            this.mainMap.Legend = this.legend1;
            this.mainMap.Location = new System.Drawing.Point(0, 0);
            this.mainMap.Name = "mainMap";
            this.mainMap.ProgressHandler = null;
            this.mainMap.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.mainMap.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.mainMap.RedrawLayersWhileResizing = false;
            this.mainMap.SelectionEnabled = true;
            this.mainMap.Size = new System.Drawing.Size(514, 329);
            this.mainMap.TabIndex = 0;
            // 
            // spatialTabControl1
            // 
            this.spatialTabControl1.Controls.Add(this.tabPage1);
            this.spatialTabControl1.Controls.Add(this.tabPage2);
            this.spatialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spatialTabControl1.Location = new System.Drawing.Point(0, 125);
            this.spatialTabControl1.Name = "spatialTabControl1";
            this.spatialTabControl1.SelectedIndex = 0;
            this.spatialTabControl1.Size = new System.Drawing.Size(716, 363);
            this.spatialTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(708, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Map";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.legend1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mainMap);
            this.splitContainer1.Size = new System.Drawing.Size(702, 331);
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(708, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Table";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbReference
            // 
            this.cbReference.FormattingEnabled = true;
            this.cbReference.Location = new System.Drawing.Point(164, 28);
            this.cbReference.Name = "cbReference";
            this.cbReference.Size = new System.Drawing.Size(135, 20);
            this.cbReference.TabIndex = 3;
            this.cbReference.Text = "-- Reference Layer --";
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.AltKey = null;
            this.ribbonOrbMenuItem1.DropDownArrowDirection = DotSpatial.Controls.RibbonControls.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Style = DotSpatial.Controls.RibbonControls.RibbonButtonStyle.Normal;
            this.ribbonOrbMenuItem1.Tag = null;
            this.ribbonOrbMenuItem1.Text = "ribbonOrbMenuItem1";
            this.ribbonOrbMenuItem1.ToolTip = null;
            this.ribbonOrbMenuItem1.ToolTipImage = null;
            this.ribbonOrbMenuItem1.ToolTipTitle = null;
            this.ribbonOrbMenuItem1.Value = null;
            // 
            // MainRibbonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 510);
            this.Controls.Add(this.cbReference);
            this.Controls.Add(this.spatialTabControl1);
            this.Controls.Add(this.spatialStatusStrip1);
            this.Controls.Add(this.ribbon1);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainRibbonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BenMAP";
            //this.Load += new System.EventHandler(this.MainRibbonForm_Load);
            this.spatialStatusStrip1.ResumeLayout(false);
            this.spatialStatusStrip1.PerformLayout();
            this.spatialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DotSpatial.Controls.RibbonControls.Ribbon ribbon1;
        private DotSpatial.Controls.RibbonControls.RibbonTab ribbonTab1;
        private DotSpatial.Controls.SpatialStatusStrip spatialStatusStrip1;
        private DotSpatial.Controls.AppManager appManager1;
        private DotSpatial.Controls.Map mainMap;
        private DotSpatial.Controls.SpatialTabControl spatialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage2;
        private DotSpatial.Controls.Legend legend1;
        private DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem orbNewProject;
        private DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem orbOpenProject;
        private DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem orbSaveProject;
        private DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem orbSaveProjectAs;
        private DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem orbPrintLayout;
        private DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem orbExtensions;
        private DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem orbApplicationSettings;
        private DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem orbAbout;
        private DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem orbExit;
        private DotSpatial.Controls.RibbonControls.RibbonButton ribbonButton1;
        private System.Windows.Forms.ComboBox cbReference;
        private DotSpatial.Controls.RibbonControls.RibbonOrbMenuItem ribbonOrbMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
    }
}

