namespace RunClub
{
    partial class DistanceForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.distanceTextBox = new System.Windows.Forms.MaskedTextBox();
            this.distancePanel = new System.Windows.Forms.Panel();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.distancePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.titleLabel.Location = new System.Drawing.Point(19, 19);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(282, 50);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Сколько километров вы пробежали ";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.distanceTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distanceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.distanceTextBox.Location = new System.Drawing.Point(201, 13);
            this.distanceTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.distanceTextBox.Mask = "00.0";
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(37, 26);
            this.distanceTextBox.TabIndex = 2;
            this.distanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.distanceTextBox.ValidatingType = typeof(int);
            // 
            // distancePanel
            // 
            this.distancePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distancePanel.Controls.Add(this.distanceLabel);
            this.distancePanel.Controls.Add(this.distanceTextBox);
            this.distancePanel.Location = new System.Drawing.Point(35, 88);
            this.distancePanel.Margin = new System.Windows.Forms.Padding(10);
            this.distancePanel.Name = "distancePanel";
            this.distancePanel.Size = new System.Drawing.Size(250, 50);
            this.distancePanel.TabIndex = 3;
            // 
            // distanceLabel
            // 
            this.distanceLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.distanceLabel.Location = new System.Drawing.Point(10, 10);
            this.distanceLabel.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(190, 30);
            this.distanceLabel.TabIndex = 4;
            this.distanceLabel.Text = "Дистанция бега (км):";
            this.distanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.SlateBlue;
            this.continueButton.FlatAppearance.BorderSize = 0;
            this.continueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.continueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.continueButton.ForeColor = System.Drawing.Color.White;
            this.continueButton.Location = new System.Drawing.Point(35, 158);
            this.continueButton.Margin = new System.Windows.Forms.Padding(10);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(250, 50);
            this.continueButton.TabIndex = 7;
            this.continueButton.Text = "Далее";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Margin = new System.Windows.Forms.Padding(10);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(320, 240);
            this.backgroundPanel.TabIndex = 9;
            // 
            // DistanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 240);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.distancePanel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.backgroundPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DistanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DistanceForm_Load);
            this.distancePanel.ResumeLayout(false);
            this.distancePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.MaskedTextBox distanceTextBox;
        private System.Windows.Forms.Panel distancePanel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Panel backgroundPanel;
    }
}