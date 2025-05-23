﻿namespace eSTOL_Training_Tool_Core.UI
{
    partial class FormUI
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUI));
            labelResult = new System.Windows.Forms.Label();
            textBoxResult = new System.Windows.Forms.TextBox();
            textBoxUser = new System.Windows.Forms.TextBox();
            labelPreset = new System.Windows.Forms.Label();
            comboBoxPreset = new System.Windows.Forms.ComboBox();
            buttonApplyPreset = new System.Windows.Forms.Button();
            buttonTeleport = new System.Windows.Forms.Button();
            buttonSetRefPos = new System.Windows.Forms.Button();
            textBoxStatus = new System.Windows.Forms.TextBox();
            buttonCreatePreset = new System.Windows.Forms.Button();
            panel = new System.Windows.Forms.Panel();
            comboBoxUnit = new System.Windows.Forms.ComboBox();
            checkBoxResult = new System.Windows.Forms.CheckBox();
            checkBoxTelemetry = new System.Windows.Forms.CheckBox();
            timer1 = new System.Windows.Forms.Timer(components);
            labelStopwatch = new System.Windows.Forms.Label();
            progressBarStopwatch = new System.Windows.Forms.ProgressBar();
            buttonStartStopwatch = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            checkBoxOntop = new System.Windows.Forms.CheckBox();
            numericUpDownStopwatchOffest = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            checkBoxDebugging = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStopwatchOffest).BeginInit();
            SuspendLayout();
            // 
            // labelResult
            // 
            labelResult.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelResult.AutoSize = true;
            labelResult.Location = new System.Drawing.Point(12, 9);
            labelResult.Name = "labelResult";
            labelResult.Size = new System.Drawing.Size(39, 15);
            labelResult.TabIndex = 0;
            labelResult.Text = "Result";
            // 
            // textBoxResult
            // 
            textBoxResult.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxResult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBoxResult.Location = new System.Drawing.Point(12, 27);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new System.Drawing.Size(463, 616);
            textBoxResult.TabIndex = 1;
            // 
            // textBoxUser
            // 
            textBoxUser.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            textBoxUser.Location = new System.Drawing.Point(747, 27);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new System.Drawing.Size(212, 23);
            textBoxUser.TabIndex = 2;
            textBoxUser.TextChanged += textBoxUser_TextChanged;
            textBoxUser.KeyDown += textBoxUser_KeyDown;
            // 
            // labelPreset
            // 
            labelPreset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelPreset.AutoSize = true;
            labelPreset.Location = new System.Drawing.Point(747, 131);
            labelPreset.Name = "labelPreset";
            labelPreset.Size = new System.Drawing.Size(39, 15);
            labelPreset.TabIndex = 3;
            labelPreset.Text = "Preset";
            labelPreset.Click += labelPreset_Click;
            // 
            // comboBoxPreset
            // 
            comboBoxPreset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            comboBoxPreset.FormattingEnabled = true;
            comboBoxPreset.Location = new System.Drawing.Point(748, 149);
            comboBoxPreset.Name = "comboBoxPreset";
            comboBoxPreset.Size = new System.Drawing.Size(211, 23);
            comboBoxPreset.TabIndex = 4;
            // 
            // buttonApplyPreset
            // 
            buttonApplyPreset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonApplyPreset.AutoSize = true;
            buttonApplyPreset.Location = new System.Drawing.Point(749, 178);
            buttonApplyPreset.Name = "buttonApplyPreset";
            buttonApplyPreset.Size = new System.Drawing.Size(210, 25);
            buttonApplyPreset.TabIndex = 5;
            buttonApplyPreset.Text = "Apply";
            buttonApplyPreset.UseVisualStyleBackColor = true;
            buttonApplyPreset.Click += buttonApplyPreset_Click;
            // 
            // buttonTeleport
            // 
            buttonTeleport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonTeleport.AutoSize = true;
            buttonTeleport.Location = new System.Drawing.Point(749, 269);
            buttonTeleport.Name = "buttonTeleport";
            buttonTeleport.Size = new System.Drawing.Size(210, 25);
            buttonTeleport.TabIndex = 6;
            buttonTeleport.Text = "Teleport";
            buttonTeleport.UseVisualStyleBackColor = true;
            buttonTeleport.Click += buttonTeleport_Click;
            // 
            // buttonSetRefPos
            // 
            buttonSetRefPos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonSetRefPos.Location = new System.Drawing.Point(748, 209);
            buttonSetRefPos.Name = "buttonSetRefPos";
            buttonSetRefPos.Size = new System.Drawing.Size(210, 23);
            buttonSetRefPos.TabIndex = 7;
            buttonSetRefPos.Text = "Set Start";
            buttonSetRefPos.UseVisualStyleBackColor = true;
            buttonSetRefPos.Click += buttonSetRefPos_Click;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxStatus.Location = new System.Drawing.Point(12, 649);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.ReadOnly = true;
            textBoxStatus.Size = new System.Drawing.Size(729, 23);
            textBoxStatus.TabIndex = 8;
            textBoxStatus.Text = "Status";
            textBoxStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCreatePreset
            // 
            buttonCreatePreset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonCreatePreset.AutoSize = true;
            buttonCreatePreset.Location = new System.Drawing.Point(749, 238);
            buttonCreatePreset.Name = "buttonCreatePreset";
            buttonCreatePreset.Size = new System.Drawing.Size(210, 25);
            buttonCreatePreset.TabIndex = 9;
            buttonCreatePreset.Text = "Create Preset";
            buttonCreatePreset.UseVisualStyleBackColor = true;
            buttonCreatePreset.Click += buttonCreatePreset_Click;
            // 
            // panel
            // 
            panel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            panel.Location = new System.Drawing.Point(481, 27);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(260, 616);
            panel.TabIndex = 10;
            panel.Paint += panel_Paint;
            // 
            // comboBoxUnit
            // 
            comboBoxUnit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            comboBoxUnit.FormattingEnabled = true;
            comboBoxUnit.Location = new System.Drawing.Point(747, 105);
            comboBoxUnit.Name = "comboBoxUnit";
            comboBoxUnit.Size = new System.Drawing.Size(212, 23);
            comboBoxUnit.TabIndex = 11;
            comboBoxUnit.SelectedIndexChanged += comboBoxUnit_SelectedIndexChanged;
            // 
            // checkBoxResult
            // 
            checkBoxResult.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            checkBoxResult.AutoSize = true;
            checkBoxResult.Checked = true;
            checkBoxResult.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxResult.Location = new System.Drawing.Point(747, 56);
            checkBoxResult.Name = "checkBoxResult";
            checkBoxResult.Size = new System.Drawing.Size(91, 19);
            checkBoxResult.TabIndex = 12;
            checkBoxResult.Text = "send Results";
            checkBoxResult.UseVisualStyleBackColor = true;
            checkBoxResult.CheckedChanged += checkBoxResult_CheckedChanged;
            // 
            // checkBoxTelemetry
            // 
            checkBoxTelemetry.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            checkBoxTelemetry.AutoSize = true;
            checkBoxTelemetry.Checked = true;
            checkBoxTelemetry.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxTelemetry.Location = new System.Drawing.Point(747, 80);
            checkBoxTelemetry.Name = "checkBoxTelemetry";
            checkBoxTelemetry.Size = new System.Drawing.Size(106, 19);
            checkBoxTelemetry.TabIndex = 13;
            checkBoxTelemetry.Text = "send Telemetry";
            checkBoxTelemetry.UseVisualStyleBackColor = true;
            checkBoxTelemetry.CheckedChanged += checkBoxTelemetry_CheckedChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += Timer;
            // 
            // labelStopwatch
            // 
            labelStopwatch.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            labelStopwatch.AutoSize = true;
            labelStopwatch.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelStopwatch.Location = new System.Drawing.Point(749, 594);
            labelStopwatch.Name = "labelStopwatch";
            labelStopwatch.Size = new System.Drawing.Size(132, 41);
            labelStopwatch.TabIndex = 14;
            labelStopwatch.Text = " 00:00";
            labelStopwatch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBarStopwatch
            // 
            progressBarStopwatch.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            progressBarStopwatch.Location = new System.Drawing.Point(747, 648);
            progressBarStopwatch.Name = "progressBarStopwatch";
            progressBarStopwatch.Size = new System.Drawing.Size(210, 23);
            progressBarStopwatch.TabIndex = 15;
            // 
            // buttonStartStopwatch
            // 
            buttonStartStopwatch.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonStartStopwatch.Location = new System.Drawing.Point(881, 611);
            buttonStartStopwatch.Name = "buttonStartStopwatch";
            buttonStartStopwatch.Size = new System.Drawing.Size(76, 24);
            buttonStartStopwatch.TabIndex = 16;
            buttonStartStopwatch.Text = "T-Offset";
            buttonStartStopwatch.UseVisualStyleBackColor = true;
            buttonStartStopwatch.Click += buttonStartStopwatch_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(828, 530);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(129, 30);
            label1.TabIndex = 17;
            label1.Text = "always listen to Airboss\r\nfor timing instructions";
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button1.Location = new System.Drawing.Point(882, 592);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonStart_Click;
            // 
            // checkBoxOntop
            // 
            checkBoxOntop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            checkBoxOntop.AutoSize = true;
            checkBoxOntop.Location = new System.Drawing.Point(858, 5);
            checkBoxOntop.Name = "checkBoxOntop";
            checkBoxOntop.Size = new System.Drawing.Size(99, 19);
            checkBoxOntop.TabIndex = 19;
            checkBoxOntop.Text = "always on top";
            checkBoxOntop.UseVisualStyleBackColor = true;
            checkBoxOntop.CheckedChanged += checkBoxOntop_CheckedChanged;
            // 
            // numericUpDownStopwatchOffest
            // 
            numericUpDownStopwatchOffest.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            numericUpDownStopwatchOffest.Location = new System.Drawing.Point(749, 563);
            numericUpDownStopwatchOffest.Name = "numericUpDownStopwatchOffest";
            numericUpDownStopwatchOffest.Size = new System.Drawing.Size(208, 23);
            numericUpDownStopwatchOffest.TabIndex = 20;
            numericUpDownStopwatchOffest.Value = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDownStopwatchOffest.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(749, 545);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 15);
            label2.TabIndex = 21;
            label2.Text = "Offset";
            // 
            // checkBoxDebugging
            // 
            checkBoxDebugging.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            checkBoxDebugging.AutoSize = true;
            checkBoxDebugging.Location = new System.Drawing.Point(749, 5);
            checkBoxDebugging.Name = "checkBoxDebugging";
            checkBoxDebugging.Size = new System.Drawing.Size(60, 19);
            checkBoxDebugging.TabIndex = 22;
            checkBoxDebugging.Text = "debug";
            checkBoxDebugging.UseVisualStyleBackColor = true;
            checkBoxDebugging.CheckedChanged += checkBoxDebugging_CheckedChanged;
            // 
            // FormUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(969, 683);
            Controls.Add(checkBoxDebugging);
            Controls.Add(label2);
            Controls.Add(numericUpDownStopwatchOffest);
            Controls.Add(checkBoxOntop);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(buttonStartStopwatch);
            Controls.Add(progressBarStopwatch);
            Controls.Add(labelStopwatch);
            Controls.Add(checkBoxTelemetry);
            Controls.Add(checkBoxResult);
            Controls.Add(comboBoxUnit);
            Controls.Add(panel);
            Controls.Add(buttonCreatePreset);
            Controls.Add(textBoxStatus);
            Controls.Add(buttonSetRefPos);
            Controls.Add(buttonTeleport);
            Controls.Add(buttonApplyPreset);
            Controls.Add(comboBoxPreset);
            Controls.Add(labelPreset);
            Controls.Add(textBoxUser);
            Controls.Add(textBoxResult);
            Controls.Add(labelResult);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FormUI";
            Text = "eSTOL Training Tool";
            ((System.ComponentModel.ISupportInitialize)numericUpDownStopwatchOffest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelPreset;
        private System.Windows.Forms.ComboBox comboBoxPreset;
        private System.Windows.Forms.Button buttonApplyPreset;
        private System.Windows.Forms.Button buttonTeleport;
        private System.Windows.Forms.Button buttonSetRefPos;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonCreatePreset;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.CheckBox checkBoxResult;
        private System.Windows.Forms.CheckBox checkBoxTelemetry;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelStopwatch;
        private System.Windows.Forms.ProgressBar progressBarStopwatch;
        private System.Windows.Forms.Button buttonStartStopwatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxOntop;
        private System.Windows.Forms.NumericUpDown numericUpDownStopwatchOffest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxDebugging;
    }
}