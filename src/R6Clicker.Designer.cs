﻿namespace R6Clicker
{
    partial class R6Clicker
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HelpButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ClickTimer = new System.Windows.Forms.Timer(this.components);
            this.ClickIntervalLabel = new System.Windows.Forms.Label();
            this.IntervalBox = new System.Windows.Forms.TextBox();
            this.MousePosTextBox = new System.Windows.Forms.TextBox();
            this.MousePosLabel = new System.Windows.Forms.Label();
            this.CustomPosBoxX = new System.Windows.Forms.TextBox();
            this.CustomPosLabel = new System.Windows.Forms.Label();
            this.SetButton = new System.Windows.Forms.Button();
            this.CustomPosBoxY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Res1080p = new System.Windows.Forms.Button();
            this.Res4k = new System.Windows.Forms.Button();
            this.Res1440p = new System.Windows.Forms.Button();
            this.Res768p = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.HelpButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.StartButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StopButton, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(639, 421);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // HelpButton
            // 
            this.HelpButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.HelpButton.Location = new System.Drawing.Point(3, 381);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(633, 37);
            this.HelpButton.TabIndex = 2;
            this.HelpButton.Text = "How to use?";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(3, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(633, 183);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start (F9)";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(3, 192);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(633, 183);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop (F10)";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ClickTimer
            // 
            this.ClickTimer.Interval = 2000;
            this.ClickTimer.Tick += new System.EventHandler(this.ClickTimer_Tick);
            // 
            // ClickIntervalLabel
            // 
            this.ClickIntervalLabel.AutoSize = true;
            this.ClickIntervalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickIntervalLabel.Location = new System.Drawing.Point(9, 9);
            this.ClickIntervalLabel.Name = "ClickIntervalLabel";
            this.ClickIntervalLabel.Size = new System.Drawing.Size(352, 31);
            this.ClickIntervalLabel.TabIndex = 1;
            this.ClickIntervalLabel.Text = "Click Interval (Milliseconds):";
            // 
            // IntervalBox
            // 
            this.IntervalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntervalBox.Location = new System.Drawing.Point(15, 43);
            this.IntervalBox.Name = "IntervalBox";
            this.IntervalBox.Size = new System.Drawing.Size(633, 38);
            this.IntervalBox.TabIndex = 2;
            // 
            // MousePosTextBox
            // 
            this.MousePosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MousePosTextBox.Location = new System.Drawing.Point(659, 43);
            this.MousePosTextBox.Name = "MousePosTextBox";
            this.MousePosTextBox.ReadOnly = true;
            this.MousePosTextBox.Size = new System.Drawing.Size(446, 38);
            this.MousePosTextBox.TabIndex = 6;
            this.MousePosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MousePosLabel
            // 
            this.MousePosLabel.AutoSize = true;
            this.MousePosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MousePosLabel.Location = new System.Drawing.Point(653, 9);
            this.MousePosLabel.Name = "MousePosLabel";
            this.MousePosLabel.Size = new System.Drawing.Size(199, 31);
            this.MousePosLabel.TabIndex = 4;
            this.MousePosLabel.Text = "Mouse Position";
            // 
            // CustomPosBoxX
            // 
            this.CustomPosBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomPosBoxX.Location = new System.Drawing.Point(659, 435);
            this.CustomPosBoxX.Name = "CustomPosBoxX";
            this.CustomPosBoxX.Size = new System.Drawing.Size(220, 30);
            this.CustomPosBoxX.TabIndex = 11;
            this.CustomPosBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomPosLabel
            // 
            this.CustomPosLabel.AutoSize = true;
            this.CustomPosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomPosLabel.Location = new System.Drawing.Point(654, 407);
            this.CustomPosLabel.Name = "CustomPosLabel";
            this.CustomPosLabel.Size = new System.Drawing.Size(219, 25);
            this.CustomPosLabel.TabIndex = 10;
            this.CustomPosLabel.Text = "Custom Mouse Position";
            // 
            // SetButton
            // 
            this.SetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetButton.Location = new System.Drawing.Point(659, 471);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(446, 38);
            this.SetButton.TabIndex = 12;
            this.SetButton.Text = "Set Custom Mouse Position";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // CustomPosBoxY
            // 
            this.CustomPosBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomPosBoxY.Location = new System.Drawing.Point(885, 435);
            this.CustomPosBoxY.Name = "CustomPosBoxY";
            this.CustomPosBoxY.Size = new System.Drawing.Size(220, 30);
            this.CustomPosBoxY.TabIndex = 13;
            this.CustomPosBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(653, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Screen Resolution";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Res1080p, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Res4k, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Res1440p, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Res768p, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(659, 125);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(446, 279);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // Res1080p
            // 
            this.Res1080p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Res1080p.Location = new System.Drawing.Point(3, 142);
            this.Res1080p.Name = "Res1080p";
            this.Res1080p.Size = new System.Drawing.Size(217, 124);
            this.Res1080p.TabIndex = 9;
            this.Res1080p.Text = "1080p";
            this.Res1080p.UseVisualStyleBackColor = true;
            this.Res1080p.Click += new System.EventHandler(this.Res1080p_Click_1);
            // 
            // Res4k
            // 
            this.Res4k.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Res4k.Location = new System.Drawing.Point(3, 3);
            this.Res4k.Name = "Res4k";
            this.Res4k.Size = new System.Drawing.Size(217, 124);
            this.Res4k.TabIndex = 4;
            this.Res4k.Text = "4K";
            this.Res4k.UseVisualStyleBackColor = true;
            this.Res4k.Click += new System.EventHandler(this.Res4k_Click_1);
            // 
            // Res1440p
            // 
            this.Res1440p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Res1440p.Location = new System.Drawing.Point(226, 3);
            this.Res1440p.Name = "Res1440p";
            this.Res1440p.Size = new System.Drawing.Size(217, 124);
            this.Res1440p.TabIndex = 8;
            this.Res1440p.Text = "1440p";
            this.Res1440p.UseVisualStyleBackColor = true;
            this.Res1440p.Click += new System.EventHandler(this.Res1440p_Click_1);
            // 
            // Res768p
            // 
            this.Res768p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Res768p.Location = new System.Drawing.Point(226, 142);
            this.Res768p.Name = "Res768p";
            this.Res768p.Size = new System.Drawing.Size(217, 124);
            this.Res768p.TabIndex = 10;
            this.Res768p.Text = "768p";
            this.Res768p.UseVisualStyleBackColor = true;
            this.Res768p.Click += new System.EventHandler(this.Res768p_Click_1);
            // 
            // R6Clicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 521);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomPosBoxY);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.CustomPosBoxX);
            this.Controls.Add(this.CustomPosLabel);
            this.Controls.Add(this.MousePosTextBox);
            this.Controls.Add(this.MousePosLabel);
            this.Controls.Add(this.IntervalBox);
            this.Controls.Add(this.ClickIntervalLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "R6Clicker";
            this.Text = "R6Clicker";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer ClickTimer;
        private System.Windows.Forms.Label ClickIntervalLabel;
        private System.Windows.Forms.TextBox IntervalBox;
        private System.Windows.Forms.TextBox MousePosTextBox;
        private System.Windows.Forms.Label MousePosLabel;
        private System.Windows.Forms.TextBox CustomPosBoxX;
        private System.Windows.Forms.Label CustomPosLabel;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.TextBox CustomPosBoxY;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Res1080p;
        private System.Windows.Forms.Button Res4k;
        private System.Windows.Forms.Button Res1440p;
        private System.Windows.Forms.Button Res768p;
    }
}