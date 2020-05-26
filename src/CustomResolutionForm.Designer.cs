namespace R6Clicker.src
{
    partial class CustomResolutionForm
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
            this.SetButton = new System.Windows.Forms.Button();
            this.MousePosX = new System.Windows.Forms.TextBox();
            this.MousePosY = new System.Windows.Forms.TextBox();
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SetButton
            // 
            this.SetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetButton.Location = new System.Drawing.Point(12, 154);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(560, 109);
            this.SetButton.TabIndex = 0;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // MousePosX
            // 
            this.MousePosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MousePosX.Location = new System.Drawing.Point(12, 37);
            this.MousePosX.Name = "MousePosX";
            this.MousePosX.Size = new System.Drawing.Size(560, 30);
            this.MousePosX.TabIndex = 1;
            // 
            // MousePosY
            // 
            this.MousePosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MousePosY.Location = new System.Drawing.Point(12, 118);
            this.MousePosY.Name = "MousePosY";
            this.MousePosY.Size = new System.Drawing.Size(560, 30);
            this.MousePosY.TabIndex = 2;
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XLabel.Location = new System.Drawing.Point(7, 9);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(170, 25);
            this.XLabel.TabIndex = 3;
            this.XLabel.Text = "Cursor X Position:";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YLabel.Location = new System.Drawing.Point(7, 90);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(169, 25);
            this.YLabel.TabIndex = 4;
            this.YLabel.Text = "Cursor Y Position:";
            // 
            // CustomResolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 275);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.MousePosY);
            this.Controls.Add(this.MousePosX);
            this.Controls.Add(this.SetButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomResolutionForm";
            this.Text = "Input Custom Resolution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.TextBox MousePosX;
        private System.Windows.Forms.TextBox MousePosY;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
    }
}