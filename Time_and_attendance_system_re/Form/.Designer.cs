
namespace Time_and_attendance_system_re
{
    partial class WorkSchedual
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
            this.workSchedualDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.csvButton = new System.Windows.Forms.Button();
            this.csvInputB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workSchedualDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workSchedualDataGridView
            // 
            this.workSchedualDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workSchedualDataGridView.Location = new System.Drawing.Point(15, 85);
            this.workSchedualDataGridView.Name = "workSchedualDataGridView";
            this.workSchedualDataGridView.RowTemplate.Height = 21;
            this.workSchedualDataGridView.Size = new System.Drawing.Size(950, 360);
            this.workSchedualDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 1;
            // 
            // csvButton
            // 
            this.csvButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.csvButton.Location = new System.Drawing.Point(840, 45);
            this.csvButton.Name = "csvButton";
            this.csvButton.Size = new System.Drawing.Size(125, 30);
            this.csvButton.TabIndex = 2;
            this.csvButton.Text = "CSV出力";
            this.csvButton.UseVisualStyleBackColor = true;
            this.csvButton.Click += new System.EventHandler(this.csvButton_Click);
            // 
            // csvInputB
            // 
            this.csvInputB.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.csvInputB.Location = new System.Drawing.Point(840, 10);
            this.csvInputB.Name = "csvInputB";
            this.csvInputB.Size = new System.Drawing.Size(125, 29);
            this.csvInputB.TabIndex = 3;
            this.csvInputB.Text = "CSV入力";
            this.csvInputB.UseVisualStyleBackColor = true;
            this.csvInputB.Click += new System.EventHandler(this.csvInputB_Click);
            // 
            // WorkSchedual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.csvInputB);
            this.Controls.Add(this.csvButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workSchedualDataGridView);
            this.Name = "WorkSchedual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WorkSchedual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workSchedualDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView workSchedualDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button csvButton;
        private System.Windows.Forms.Button csvInputB;
    }
}