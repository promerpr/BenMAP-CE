﻿namespace BenMAP
{
    partial class QALYResultsReport
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkPopDeltas = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudElements = new System.Windows.Forms.NumericUpDown();
            this.nudDigits = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnHealthGrid = new System.Windows.Forms.RadioButton();
            this.rbtnGRidHealth = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.olvResult = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvHealth = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnRow = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDigits)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvColumnRow)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOK);
            this.groupBox3.Location = new System.Drawing.Point(2, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(695, 89);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(581, 40);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(2, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 19);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.chkPopDeltas);
            this.groupBox6.Location = new System.Drawing.Point(521, 14);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 79);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Advanced Options";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "Population Weighted Deltas:";
            // 
            // chkPopDeltas
            // 
            this.chkPopDeltas.AutoSize = true;
            this.chkPopDeltas.Location = new System.Drawing.Point(179, 23);
            this.chkPopDeltas.Name = "chkPopDeltas";
            this.chkPopDeltas.Size = new System.Drawing.Size(15, 14);
            this.chkPopDeltas.TabIndex = 1;
            this.chkPopDeltas.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.nudElements);
            this.groupBox5.Controls.Add(this.nudDigits);
            this.groupBox5.Location = new System.Drawing.Point(313, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 79);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Display Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Elements in Preview:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Digits After Decimal Point:";
            // 
            // nudElements
            // 
            this.nudElements.Location = new System.Drawing.Point(152, 45);
            this.nudElements.Name = "nudElements";
            this.nudElements.Size = new System.Drawing.Size(50, 22);
            this.nudElements.TabIndex = 3;
            // 
            // nudDigits
            // 
            this.nudDigits.Location = new System.Drawing.Point(152, 20);
            this.nudDigits.Name = "nudDigits";
            this.nudDigits.Size = new System.Drawing.Size(50, 22);
            this.nudDigits.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnHealthGrid);
            this.groupBox4.Controls.Add(this.rbtnGRidHealth);
            this.groupBox4.Location = new System.Drawing.Point(6, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(304, 79);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Grouping Options";
            // 
            // rbtnHealthGrid
            // 
            this.rbtnHealthGrid.AutoSize = true;
            this.rbtnHealthGrid.Location = new System.Drawing.Point(6, 45);
            this.rbtnHealthGrid.Name = "rbtnHealthGrid";
            this.rbtnHealthGrid.Size = new System.Drawing.Size(317, 16);
            this.rbtnHealthGrid.TabIndex = 2;
            this.rbtnHealthGrid.TabStop = true;
            this.rbtnHealthGrid.Text = "Group by Health impact function,then by Gridcell.";
            this.rbtnHealthGrid.UseVisualStyleBackColor = true;
            // 
            // rbtnGRidHealth
            // 
            this.rbtnGRidHealth.AutoSize = true;
            this.rbtnGRidHealth.Checked = true;
            this.rbtnGRidHealth.Location = new System.Drawing.Point(6, 21);
            this.rbtnGRidHealth.Name = "rbtnGRidHealth";
            this.rbtnGRidHealth.Size = new System.Drawing.Size(317, 16);
            this.rbtnGRidHealth.TabIndex = 1;
            this.rbtnGRidHealth.TabStop = true;
            this.rbtnGRidHealth.Text = "Group by Gridcell,then by Health impact function.";
            this.rbtnGRidHealth.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.olvResult);
            this.groupBox1.Controls.Add(this.olvHealth);
            this.groupBox1.Controls.Add(this.olvColumnRow);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Column Selection";
            // 
            // olvResult
            // 
            this.olvResult.AllColumns.Add(this.olvColumn3);
            this.olvResult.AllowColumnReorder = true;
            this.olvResult.AllowDrop = true;
            this.olvResult.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.olvResult.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.olvResult.CellEditEnterChangesRows = true;
            this.olvResult.CheckBoxes = true;
            this.olvResult.CheckedAspectName = "isChecked";
            this.olvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn3});
            this.olvResult.CopySelectionOnControlC = false;
            this.olvResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvResult.EmptyListMsg = "This list is empty. ";
            this.olvResult.FullRowSelect = true;
            this.olvResult.HeaderUsesThemes = false;
            this.olvResult.HideSelection = false;
            this.olvResult.Location = new System.Drawing.Point(426, 39);
            this.olvResult.Name = "olvResult";
            this.olvResult.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.olvResult.OverlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.olvResult.OverlayText.BorderWidth = 2F;
            this.olvResult.OverlayText.Rotation = -20;
            this.olvResult.OverlayText.Text = "";
            this.olvResult.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvResult.ShowCommandMenuOnRightClick = true;
            this.olvResult.ShowGroups = false;
            this.olvResult.ShowImagesOnSubItems = true;
            this.olvResult.ShowItemCountOnGroups = true;
            this.olvResult.ShowItemToolTips = true;
            this.olvResult.Size = new System.Drawing.Size(261, 171);
            this.olvResult.SpaceBetweenGroups = 20;
            this.olvResult.TabIndex = 9;
            this.olvResult.UseAlternatingBackColors = true;
            this.olvResult.UseCompatibleStateImageBehavior = false;
            this.olvResult.UseFiltering = true;
            this.olvResult.UseHotItem = true;
            this.olvResult.UseHyperlinks = true;
            this.olvResult.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "FieldName";
            this.olvColumn3.IsEditable = false;
            this.olvColumn3.IsTileViewColumn = true;
            this.olvColumn3.MaximumWidth = 180;
            this.olvColumn3.MinimumWidth = 50;
            this.olvColumn3.Text = "FieldName";
            this.olvColumn3.Width = 180;
            // 
            // olvHealth
            // 
            this.olvHealth.AllColumns.Add(this.olvColumn1);
            this.olvHealth.AllowColumnReorder = true;
            this.olvHealth.AllowDrop = true;
            this.olvHealth.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.olvHealth.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.olvHealth.CheckBoxes = true;
            this.olvHealth.CheckedAspectName = "isChecked";
            this.olvHealth.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1});
            this.olvHealth.CopySelectionOnControlC = false;
            this.olvHealth.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvHealth.EmptyListMsg = "This list is empty. ";
            this.olvHealth.FullRowSelect = true;
            this.olvHealth.HeaderUsesThemes = false;
            this.olvHealth.HideSelection = false;
            this.olvHealth.Location = new System.Drawing.Point(156, 38);
            this.olvHealth.Name = "olvHealth";
            this.olvHealth.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.olvHealth.OverlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.olvHealth.OverlayText.BorderWidth = 2F;
            this.olvHealth.OverlayText.Rotation = -20;
            this.olvHealth.OverlayText.Text = "";
            this.olvHealth.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvHealth.ShowCommandMenuOnRightClick = true;
            this.olvHealth.ShowGroups = false;
            this.olvHealth.ShowImagesOnSubItems = true;
            this.olvHealth.ShowItemCountOnGroups = true;
            this.olvHealth.ShowItemToolTips = true;
            this.olvHealth.Size = new System.Drawing.Size(261, 171);
            this.olvHealth.SpaceBetweenGroups = 20;
            this.olvHealth.TabIndex = 8;
            this.olvHealth.UseAlternatingBackColors = true;
            this.olvHealth.UseCompatibleStateImageBehavior = false;
            this.olvHealth.UseFiltering = true;
            this.olvHealth.UseHotItem = true;
            this.olvHealth.UseHyperlinks = true;
            this.olvHealth.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "FieldName";
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.IsTileViewColumn = true;
            this.olvColumn1.MaximumWidth = 180;
            this.olvColumn1.MinimumWidth = 50;
            this.olvColumn1.Text = "FieldName";
            this.olvColumn1.Width = 180;
            // 
            // olvColumnRow
            // 
            this.olvColumnRow.AllColumns.Add(this.olvColumn2);
            this.olvColumnRow.AllowColumnReorder = true;
            this.olvColumnRow.AllowDrop = true;
            this.olvColumnRow.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.olvColumnRow.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.olvColumnRow.CheckBoxes = true;
            this.olvColumnRow.CheckedAspectName = "isChecked";
            this.olvColumnRow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn2});
            this.olvColumnRow.CopySelectionOnControlC = false;
            this.olvColumnRow.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvColumnRow.EmptyListMsg = "This list is empty. ";
            this.olvColumnRow.FullRowSelect = true;
            this.olvColumnRow.HeaderUsesThemes = false;
            this.olvColumnRow.HideSelection = false;
            this.olvColumnRow.Location = new System.Drawing.Point(9, 38);
            this.olvColumnRow.Name = "olvColumnRow";
            this.olvColumnRow.OverlayText.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.olvColumnRow.OverlayText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.olvColumnRow.OverlayText.BorderWidth = 2F;
            this.olvColumnRow.OverlayText.Rotation = -20;
            this.olvColumnRow.OverlayText.Text = "";
            this.olvColumnRow.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvColumnRow.ShowCommandMenuOnRightClick = true;
            this.olvColumnRow.ShowGroups = false;
            this.olvColumnRow.ShowImagesOnSubItems = true;
            this.olvColumnRow.ShowItemCountOnGroups = true;
            this.olvColumnRow.ShowItemToolTips = true;
            this.olvColumnRow.Size = new System.Drawing.Size(137, 171);
            this.olvColumnRow.SpaceBetweenGroups = 20;
            this.olvColumnRow.TabIndex = 7;
            this.olvColumnRow.UseAlternatingBackColors = true;
            this.olvColumnRow.UseCompatibleStateImageBehavior = false;
            this.olvColumnRow.UseFiltering = true;
            this.olvColumnRow.UseHotItem = true;
            this.olvColumnRow.UseHyperlinks = true;
            this.olvColumnRow.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "FieldName";
            this.olvColumn2.IsEditable = false;
            this.olvColumn2.IsTileViewColumn = true;
            this.olvColumn2.MaximumWidth = 180;
            this.olvColumn2.MinimumWidth = 50;
            this.olvColumn2.Text = "FieldName";
            this.olvColumn2.Width = 180;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result Fields:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "QALY Method Fields:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grid Fields:";
            // 
            // QALYResultsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 357);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QALYResultsReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QALY Results Report Set";
            this.Load += new System.EventHandler(this.QALYResultsReport_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDigits)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvColumnRow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkPopDeltas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudElements;
        private System.Windows.Forms.NumericUpDown nudDigits;
        private System.Windows.Forms.RadioButton rbtnHealthGrid;
        private System.Windows.Forms.RadioButton rbtnGRidHealth;
        private System.Windows.Forms.Button btnOK;
        private BrightIdeasSoftware.ObjectListView olvResult;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.ObjectListView olvHealth;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.ObjectListView olvColumnRow;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
    }
}