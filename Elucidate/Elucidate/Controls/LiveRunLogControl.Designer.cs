﻿using System.Windows.Forms;

namespace Elucidate.Controls
{
    partial class LiveRunLogControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.Label();
            this.toolStripProgressBar1 = new Elucidate.Shared.TextOverProgressBar();
            this.runWithoutCaptureMenuItem = new System.Windows.Forms.CheckBox();
            this.checkBoxDisplayOutput = new System.Windows.Forms.CheckBox();
            this.comboBoxProcessStatus = new System.Windows.Forms.ComboBox();
            this.timerScantilla = new System.Windows.Forms.Timer(this.components);
            this.scintilla = new ScintillaNET.Scintilla();
            this.txtAddCommands = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelAdditionalCommands = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxCommandLineOptions = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelAdditionalCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.toolStripStatusLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStripProgressBar1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.runWithoutCaptureMenuItem, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxDisplayOutput, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxProcessStatus, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 385);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(871, 27);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = true;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Location = new System.Drawing.Point(0, 0);
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripStatusLabel1.MinimumSize = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(132, 17);
            this.toolStripStatusLabel1.TabIndex = 7;
            this.toolStripStatusLabel1.Text = "2000-01-01 00:00:00Z";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.ContainerControl = this;
            this.toolStripProgressBar1.DisplayText = "";
            this.toolStripProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripProgressBar1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.toolStripProgressBar1.Location = new System.Drawing.Point(480, 0);
            this.toolStripProgressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.ShowInTaskbar = true;
            this.toolStripProgressBar1.Size = new System.Drawing.Size(524, 27);
            this.toolStripProgressBar1.Step = 3;
            this.toolStripProgressBar1.TabIndex = 5;
            this.toolStripProgressBar1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // runWithoutCaptureMenuItem
            // 
            this.runWithoutCaptureMenuItem.AutoSize = true;
            this.runWithoutCaptureMenuItem.Location = new System.Drawing.Point(355, 3);
            this.runWithoutCaptureMenuItem.Name = "runWithoutCaptureMenuItem";
            this.runWithoutCaptureMenuItem.Size = new System.Drawing.Size(122, 17);
            this.runWithoutCaptureMenuItem.TabIndex = 4;
            this.runWithoutCaptureMenuItem.Text = "Run without capture";
            this.runWithoutCaptureMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.runWithoutCaptureMenuItem.UseVisualStyleBackColor = true;
            this.runWithoutCaptureMenuItem.Visible = false;
            // 
            // checkBoxDisplayOutput
            // 
            this.checkBoxDisplayOutput.AutoSize = true;
            this.checkBoxDisplayOutput.Checked = true;
            this.checkBoxDisplayOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisplayOutput.Location = new System.Drawing.Point(254, 3);
            this.checkBoxDisplayOutput.Name = "checkBoxDisplayOutput";
            this.checkBoxDisplayOutput.Size = new System.Drawing.Size(95, 17);
            this.checkBoxDisplayOutput.TabIndex = 6;
            this.checkBoxDisplayOutput.Text = "Display Output";
            this.checkBoxDisplayOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxDisplayOutput.UseVisualStyleBackColor = true;
            this.checkBoxDisplayOutput.MouseLeave += new System.EventHandler(this.checkBoxDisplayOutput_MouseLeave);
            this.checkBoxDisplayOutput.MouseHover += new System.EventHandler(this.checkBoxDisplayOutput_MouseHover);
            // 
            // comboBoxProcessStatus
            // 
            this.comboBoxProcessStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcessStatus.FormattingEnabled = true;
            this.comboBoxProcessStatus.IntegralHeight = false;
            this.comboBoxProcessStatus.Items.AddRange(new object[] {
            "Stopped",
            "Running",
            "Abort"});
            this.comboBoxProcessStatus.Location = new System.Drawing.Point(135, 3);
            this.comboBoxProcessStatus.Name = "comboBoxProcessStatus";
            this.comboBoxProcessStatus.Size = new System.Drawing.Size(113, 21);
            this.comboBoxProcessStatus.TabIndex = 3;
            this.comboBoxProcessStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxProcessStatus_SelectedIndexChanged);
            // 
            // timerScantilla
            // 
            this.timerScantilla.Interval = 750;
            this.timerScantilla.Tick += new System.EventHandler(this.timerScantillaTimer_Tick);
            // 
            // scintilla
            // 
            this.scintilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla.Location = new System.Drawing.Point(0, 0);
            this.scintilla.Name = "scintilla";
            this.scintilla.ScrollWidth = 50;
            this.scintilla.Size = new System.Drawing.Size(871, 360);
            this.scintilla.TabIndex = 3;
            this.scintilla.StyleNeeded += new System.EventHandler<ScintillaNET.StyleNeededEventArgs>(this.scintilla_StyleNeeded);
            // 
            // txtAddCommands
            // 
            this.txtAddCommands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddCommands.Location = new System.Drawing.Point(234, 2);
            this.txtAddCommands.Margin = new System.Windows.Forms.Padding(1);
            this.txtAddCommands.MaxLength = 128;
            this.txtAddCommands.Name = "txtAddCommands";
            this.txtAddCommands.Size = new System.Drawing.Size(635, 13);
            this.txtAddCommands.TabIndex = 6;
            this.txtAddCommands.WordWrap = false;
            // 
            // tableLayoutPanelAdditionalCommands
            // 
            this.tableLayoutPanelAdditionalCommands.AutoSize = true;
            this.tableLayoutPanelAdditionalCommands.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelAdditionalCommands.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanelAdditionalCommands.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelAdditionalCommands.ColumnCount = 2;
            this.tableLayoutPanelAdditionalCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAdditionalCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAdditionalCommands.Controls.Add(this.txtAddCommands, 1, 0);
            this.tableLayoutPanelAdditionalCommands.Controls.Add(this.checkBoxCommandLineOptions, 0, 0);
            this.tableLayoutPanelAdditionalCommands.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelAdditionalCommands.Location = new System.Drawing.Point(0, 360);
            this.tableLayoutPanelAdditionalCommands.Margin = new System.Windows.Forms.Padding(12);
            this.tableLayoutPanelAdditionalCommands.MinimumSize = new System.Drawing.Size(50, 10);
            this.tableLayoutPanelAdditionalCommands.Name = "tableLayoutPanelAdditionalCommands";
            this.tableLayoutPanelAdditionalCommands.RowCount = 1;
            this.tableLayoutPanelAdditionalCommands.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAdditionalCommands.Size = new System.Drawing.Size(871, 25);
            this.tableLayoutPanelAdditionalCommands.TabIndex = 1;
            // 
            // checkBoxCommandLineOptions
            // 
            this.checkBoxCommandLineOptions.AutoSize = true;
            this.checkBoxCommandLineOptions.Location = new System.Drawing.Point(4, 4);
            this.checkBoxCommandLineOptions.Name = "checkBoxCommandLineOptions";
            this.checkBoxCommandLineOptions.Size = new System.Drawing.Size(225, 17);
            this.checkBoxCommandLineOptions.TabIndex = 7;
            this.checkBoxCommandLineOptions.Text = "Include Additional Command Line Options:";
            this.checkBoxCommandLineOptions.UseVisualStyleBackColor = true;
            this.checkBoxCommandLineOptions.CheckedChanged += new System.EventHandler(this.checkBoxCommandLineOptions_CheckedChanged);
            // 
            // LiveRunLogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scintilla);
            this.Controls.Add(this.tableLayoutPanelAdditionalCommands);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LiveRunLogControl";
            this.Size = new System.Drawing.Size(871, 412);
            this.Load += new System.EventHandler(this.LiveRunLogControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelAdditionalCommands.ResumeLayout(false);
            this.tableLayoutPanelAdditionalCommands.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxProcessStatus;
        private Shared.TextOverProgressBar toolStripProgressBar1;
        private System.Windows.Forms.CheckBox runWithoutCaptureMenuItem;
        private ScintillaNET.Scintilla scintilla;
        private Timer timerScantilla;
        private CheckBox checkBoxDisplayOutput;
        private Label toolStripStatusLabel1;
        private TableLayoutPanel tableLayoutPanelAdditionalCommands;
        private TextBox txtAddCommands;
        private CheckBox checkBoxCommandLineOptions;
    }
}
