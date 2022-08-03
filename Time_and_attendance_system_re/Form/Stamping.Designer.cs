
namespace Time_and_attendance_system_re
{
    partial class Stamping
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
            this.statusLabel = new System.Windows.Forms.Label();
            this.attendanceButton = new System.Windows.Forms.Button();
            this.leavingButton = new System.Windows.Forms.Button();
            this.restButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.Location = new System.Drawing.Point(450, 100);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(100, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "打刻";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.statusLabel.Location = new System.Drawing.Point(450, 200);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(100, 30);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Status";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // attendanceButton
            // 
            this.attendanceButton.Location = new System.Drawing.Point(200, 350);
            this.attendanceButton.Name = "attendanceButton";
            this.attendanceButton.Size = new System.Drawing.Size(100, 50);
            this.attendanceButton.TabIndex = 2;
            this.attendanceButton.Text = "出勤";
            this.attendanceButton.UseVisualStyleBackColor = true;
            this.attendanceButton.Click += new System.EventHandler(this.attendanceButton_Click);
            // 
            // leavingButton
            // 
            this.leavingButton.Location = new System.Drawing.Point(700, 350);
            this.leavingButton.Name = "leavingButton";
            this.leavingButton.Size = new System.Drawing.Size(100, 50);
            this.leavingButton.TabIndex = 4;
            this.leavingButton.Text = "退勤";
            this.leavingButton.UseVisualStyleBackColor = true;
            this.leavingButton.Click += new System.EventHandler(this.leavingButton_Click);
            // 
            // restButton
            // 
            this.restButton.Location = new System.Drawing.Point(450, 350);
            this.restButton.Name = "restButton";
            this.restButton.Size = new System.Drawing.Size(100, 50);
            this.restButton.TabIndex = 3;
            this.restButton.Text = "休憩";
            this.restButton.UseVisualStyleBackColor = true;
            this.restButton.Click += new System.EventHandler(this.restButton_Click);
            // 
            // Stamping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.leavingButton);
            this.Controls.Add(this.restButton);
            this.Controls.Add(this.attendanceButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Stamping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button attendanceButton;
        private System.Windows.Forms.Button leavingButton;
        private System.Windows.Forms.Button restButton;
    }
}