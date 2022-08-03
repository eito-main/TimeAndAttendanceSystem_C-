
namespace Time_and_attendance_system_re
{
    partial class Home
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
            this.label2 = new System.Windows.Forms.Label();
            this.stampingButton = new System.Windows.Forms.Button();
            this.workScheduleButton = new System.Windows.Forms.Button();
            this.allWorkSchedualButton = new System.Windows.Forms.Button();
            this.todoListButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(450, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "ホーム";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stampingButton
            // 
            this.stampingButton.Location = new System.Drawing.Point(150, 350);
            this.stampingButton.Name = "stampingButton";
            this.stampingButton.Size = new System.Drawing.Size(100, 50);
            this.stampingButton.TabIndex = 3;
            this.stampingButton.Text = "打刻";
            this.stampingButton.UseVisualStyleBackColor = true;
            this.stampingButton.Click += new System.EventHandler(this.stampingButton_Click);
            // 
            // workScheduleButton
            // 
            this.workScheduleButton.Location = new System.Drawing.Point(350, 350);
            this.workScheduleButton.Name = "workScheduleButton";
            this.workScheduleButton.Size = new System.Drawing.Size(100, 50);
            this.workScheduleButton.TabIndex = 4;
            this.workScheduleButton.Text = "勤務表";
            this.workScheduleButton.UseVisualStyleBackColor = true;
            this.workScheduleButton.Click += new System.EventHandler(this.workScheduleButton_Click);
            // 
            // allWorkSchedualButton
            // 
            this.allWorkSchedualButton.Location = new System.Drawing.Point(750, 350);
            this.allWorkSchedualButton.Name = "allWorkSchedualButton";
            this.allWorkSchedualButton.Size = new System.Drawing.Size(100, 50);
            this.allWorkSchedualButton.TabIndex = 5;
            this.allWorkSchedualButton.Text = "全体勤務表";
            this.allWorkSchedualButton.UseVisualStyleBackColor = true;
            this.allWorkSchedualButton.Click += new System.EventHandler(this.allWorkSchedualButton_Click);
            // 
            // todoListButton
            // 
            this.todoListButton.Location = new System.Drawing.Point(550, 350);
            this.todoListButton.Name = "todoListButton";
            this.todoListButton.Size = new System.Drawing.Size(100, 50);
            this.todoListButton.TabIndex = 6;
            this.todoListButton.Text = "TODO";
            this.todoListButton.UseVisualStyleBackColor = true;
            this.todoListButton.Click += new System.EventHandler(this.todoListButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.todoListButton);
            this.Controls.Add(this.allWorkSchedualButton);
            this.Controls.Add(this.workScheduleButton);
            this.Controls.Add(this.stampingButton);
            this.Controls.Add(this.label2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button stampingButton;
        private System.Windows.Forms.Button workScheduleButton;
        private System.Windows.Forms.Button allWorkSchedualButton;
        private System.Windows.Forms.Button todoListButton;
        private System.Windows.Forms.Timer timer1;
    }
}