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
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.Res1080p = new System.Windows.Forms.Button();
            this.ResolutionTextBox = new System.Windows.Forms.TextBox();
            this.Res768p = new System.Windows.Forms.Button();
            this.Res1440p = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.StartButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StopButton, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 421);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(3, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(769, 204);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(3, 213);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(769, 205);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
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
            this.IntervalBox.Size = new System.Drawing.Size(769, 38);
            this.IntervalBox.TabIndex = 2;
            // 
            // Res4k
            // 
            this.Res4k.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Res4k.Location = new System.Drawing.Point(793, 91);
            this.Res4k.Name = "Res4k";
            this.Res4k.Size = new System.Drawing.Size(220, 204);
            this.Res4k.TabIndex = 3;
            this.Res4k.Text = "3840x2160";
            this.Res4k.UseVisualStyleBackColor = true;
            this.Res4k.Click += new System.EventHandler(this.Res4k_Click);
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolutionLabel.Location = new System.Drawing.Point(787, 9);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(143, 31);
            this.ResolutionLabel.TabIndex = 4;
            this.ResolutionLabel.Text = "Resolution";
            // 
            // Res1080p
            // 
            this.Res1080p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Res1080p.Location = new System.Drawing.Point(793, 301);
            this.Res1080p.Name = "Res1080p";
            this.Res1080p.Size = new System.Drawing.Size(220, 205);
            this.Res1080p.TabIndex = 5;
            this.Res1080p.Text = "1920x1080";
            this.Res1080p.UseVisualStyleBackColor = true;
            this.Res1080p.Click += new System.EventHandler(this.Res1080p_Click);
            // 
            // ResolutionTextBox
            // 
            this.ResolutionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolutionTextBox.Location = new System.Drawing.Point(793, 43);
            this.ResolutionTextBox.Name = "ResolutionTextBox";
            this.ResolutionTextBox.Size = new System.Drawing.Size(446, 38);
            this.ResolutionTextBox.TabIndex = 6;
            // 
            // Res768p
            // 
            this.Res768p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Res768p.Location = new System.Drawing.Point(1019, 301);
            this.Res768p.Name = "Res768p";
            this.Res768p.Size = new System.Drawing.Size(220, 205);
            this.Res768p.TabIndex = 8;
            this.Res768p.Text = "1366x768";
            this.Res768p.UseVisualStyleBackColor = true;
            this.Res768p.Click += new System.EventHandler(this.Res768p_Click);
            // 
            // Res1440p
            // 
            this.Res1440p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Res1440p.Location = new System.Drawing.Point(1019, 91);
            this.Res1440p.Name = "Res1440p";
            this.Res1440p.Size = new System.Drawing.Size(220, 204);
            this.Res1440p.TabIndex = 7;
            this.Res1440p.Text = "2560x1440";
            this.Res1440p.UseVisualStyleBackColor = true;
            this.Res1440p.Click += new System.EventHandler(this.Res1440p_Click);
            // 
            // R6Clicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 521);
            this.Controls.Add(this.Res768p);
            this.Controls.Add(this.Res1440p);
            this.Controls.Add(this.ResolutionTextBox);
            this.Controls.Add(this.Res1080p);
            this.Controls.Add(this.ResolutionLabel);
            this.Controls.Add(this.Res4k);
            this.Controls.Add(this.IntervalBox);
            this.Controls.Add(this.ClickIntervalLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Timer ClickTimer;
        private System.Windows.Forms.Label ClickIntervalLabel;
        private System.Windows.Forms.TextBox IntervalBox;
        private System.Windows.Forms.Button Res4k;
        private System.Windows.Forms.Label ResolutionLabel;
        private System.Windows.Forms.Button Res1080p;
        private System.Windows.Forms.TextBox ResolutionTextBox;
        private System.Windows.Forms.Button Res768p;
        private System.Windows.Forms.Button Res1440p;
    }
}

