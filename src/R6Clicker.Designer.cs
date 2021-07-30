namespace R6Clicker
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
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ClickTimer = new System.Windows.Forms.Timer(this.components);
            this.ClickIntervalLabel = new System.Windows.Forms.Label();
            this.IntervalBox = new System.Windows.Forms.TextBox();
            this.Res4k = new System.Windows.Forms.Button();
            this.Res1080p = new System.Windows.Forms.Button();
            this.ResolutionTextBox = new System.Windows.Forms.TextBox();
            this.Res768p = new System.Windows.Forms.Button();
            this.Res1440p = new System.Windows.Forms.Button();
            this.MousePosLabel = new System.Windows.Forms.Label();
            this.CustomPosBoxX = new System.Windows.Forms.TextBox();
            this.CustomPosLabel = new System.Windows.Forms.Label();
            this.SetButton = new System.Windows.Forms.Button();
            this.CustomPosBoxY = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.StartButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StopButton, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 108);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(852, 518);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(4, 4);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(844, 251);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start (F10)";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(4, 263);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(844, 251);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop (F9)";
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
            this.ClickIntervalLabel.Location = new System.Drawing.Point(12, 11);
            this.ClickIntervalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClickIntervalLabel.Name = "ClickIntervalLabel";
            this.ClickIntervalLabel.Size = new System.Drawing.Size(440, 39);
            this.ClickIntervalLabel.TabIndex = 1;
            this.ClickIntervalLabel.Text = "Click Interval (Milliseconds):";
            // 
            // IntervalBox
            // 
            this.IntervalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntervalBox.Location = new System.Drawing.Point(20, 53);
            this.IntervalBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IntervalBox.Name = "IntervalBox";
            this.IntervalBox.Size = new System.Drawing.Size(843, 45);
            this.IntervalBox.TabIndex = 2;
            // 
            // Res4k
            // 
            this.Res4k.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Res4k.Location = new System.Drawing.Point(879, 112);
            this.Res4k.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Res4k.Name = "Res4k";
            this.Res4k.Size = new System.Drawing.Size(293, 188);
            this.Res4k.TabIndex = 3;
            this.Res4k.Text = "2400, 1980 (4K)";
            this.Res4k.UseVisualStyleBackColor = true;
            this.Res4k.Click += new System.EventHandler(this.Res4k_Click);
            // 
            // Res1080p
            // 
            this.Res1080p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Res1080p.Location = new System.Drawing.Point(879, 308);
            this.Res1080p.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Res1080p.Name = "Res1080p";
            this.Res1080p.Size = new System.Drawing.Size(293, 190);
            this.Res1080p.TabIndex = 5;
            this.Res1080p.Text = "1200, 985 (1080p)";
            this.Res1080p.UseVisualStyleBackColor = true;
            this.Res1080p.Click += new System.EventHandler(this.Res1080p_Click);
            // 
            // ResolutionTextBox
            // 
            this.ResolutionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolutionTextBox.Location = new System.Drawing.Point(879, 53);
            this.ResolutionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResolutionTextBox.Name = "ResolutionTextBox";
            this.ResolutionTextBox.ReadOnly = true;
            this.ResolutionTextBox.Size = new System.Drawing.Size(593, 45);
            this.ResolutionTextBox.TabIndex = 6;
            // 
            // Res768p
            // 
            this.Res768p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Res768p.Location = new System.Drawing.Point(1180, 308);
            this.Res768p.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Res768p.Name = "Res768p";
            this.Res768p.Size = new System.Drawing.Size(293, 190);
            this.Res768p.TabIndex = 8;
            this.Res768p.Text = "900, 690 (768p)";
            this.Res768p.UseVisualStyleBackColor = true;
            this.Res768p.Click += new System.EventHandler(this.Res768p_Click);
            // 
            // Res1440p
            // 
            this.Res1440p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Res1440p.Location = new System.Drawing.Point(1180, 112);
            this.Res1440p.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Res1440p.Name = "Res1440p";
            this.Res1440p.Size = new System.Drawing.Size(293, 188);
            this.Res1440p.TabIndex = 7;
            this.Res1440p.Text = "1600, 1325 (1440p)";
            this.Res1440p.UseVisualStyleBackColor = true;
            this.Res1440p.Click += new System.EventHandler(this.Res1440p_Click);
            // 
            // MousePosLabel
            // 
            this.MousePosLabel.AutoSize = true;
            this.MousePosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MousePosLabel.Location = new System.Drawing.Point(871, 11);
            this.MousePosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MousePosLabel.Name = "MousePosLabel";
            this.MousePosLabel.Size = new System.Drawing.Size(441, 39);
            this.MousePosLabel.TabIndex = 4;
            this.MousePosLabel.Text = "Mouse Position - Resolution";
            // 
            // CustomPosBoxX
            // 
            this.CustomPosBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomPosBoxX.Location = new System.Drawing.Point(879, 535);
            this.CustomPosBoxX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomPosBoxX.Name = "CustomPosBoxX";
            this.CustomPosBoxX.Size = new System.Drawing.Size(292, 36);
            this.CustomPosBoxX.TabIndex = 11;
            this.CustomPosBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomPosLabel
            // 
            this.CustomPosLabel.AutoSize = true;
            this.CustomPosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomPosLabel.Location = new System.Drawing.Point(872, 501);
            this.CustomPosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomPosLabel.Name = "CustomPosLabel";
            this.CustomPosLabel.Size = new System.Drawing.Size(282, 29);
            this.CustomPosLabel.TabIndex = 10;
            this.CustomPosLabel.Text = "Custom Mouse Position";
            // 
            // SetButton
            // 
            this.SetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetButton.Location = new System.Drawing.Point(879, 580);
            this.SetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(595, 47);
            this.SetButton.TabIndex = 12;
            this.SetButton.Text = "Set Custom Mouse Position";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // CustomPosBoxY
            // 
            this.CustomPosBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomPosBoxY.Location = new System.Drawing.Point(1180, 535);
            this.CustomPosBoxY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomPosBoxY.Name = "CustomPosBoxY";
            this.CustomPosBoxY.Size = new System.Drawing.Size(292, 36);
            this.CustomPosBoxY.TabIndex = 13;
            this.CustomPosBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // R6Clicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 641);
            this.Controls.Add(this.CustomPosBoxY);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.CustomPosBoxX);
            this.Controls.Add(this.CustomPosLabel);
            this.Controls.Add(this.Res768p);
            this.Controls.Add(this.Res1440p);
            this.Controls.Add(this.ResolutionTextBox);
            this.Controls.Add(this.Res1080p);
            this.Controls.Add(this.MousePosLabel);
            this.Controls.Add(this.Res4k);
            this.Controls.Add(this.IntervalBox);
            this.Controls.Add(this.ClickIntervalLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "R6Clicker";
            this.Text = "R6Clicker";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer ClickTimer;
        private System.Windows.Forms.Label ClickIntervalLabel;
        private System.Windows.Forms.TextBox IntervalBox;
        private System.Windows.Forms.Button Res4k;
        private System.Windows.Forms.Button Res1080p;
        private System.Windows.Forms.TextBox ResolutionTextBox;
        private System.Windows.Forms.Button Res768p;
        private System.Windows.Forms.Button Res1440p;
        private System.Windows.Forms.Label MousePosLabel;
        private System.Windows.Forms.TextBox CustomPosBoxX;
        private System.Windows.Forms.Label CustomPosLabel;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.TextBox CustomPosBoxY;
    }
}

