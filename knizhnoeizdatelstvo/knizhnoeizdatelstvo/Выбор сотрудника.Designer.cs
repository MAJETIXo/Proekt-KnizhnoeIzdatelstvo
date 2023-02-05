
namespace knizhnoeizdatelstvo
{
    partial class vibsotr
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.Manager = new System.Windows.Forms.Button();
            this.izadatel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Manager
            // 
            this.Manager.Location = new System.Drawing.Point(288, 252);
            this.Manager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(229, 46);
            this.Manager.TabIndex = 3;
            this.Manager.Text = "Менеджер";
            this.Manager.UseVisualStyleBackColor = true;
            this.Manager.Click += new System.EventHandler(this.Manager_Click);
            // 
            // izadatel
            // 
            this.izadatel.Location = new System.Drawing.Point(288, 169);
            this.izadatel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.izadatel.Name = "izadatel";
            this.izadatel.Size = new System.Drawing.Size(229, 46);
            this.izadatel.TabIndex = 6;
            this.izadatel.Text = "Издатель";
            this.izadatel.UseVisualStyleBackColor = true;
            this.izadatel.Click += new System.EventHandler(this.izadatel_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(12, 412);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 27);
            this.button3.TabIndex = 112;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(304, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 113;
            this.label1.Text = "Выбор сотрудника";
            // 
            // vibsotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::knizhnoeizdatelstvo.Properties.Resources.фон;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.izadatel);
            this.Controls.Add(this.Manager);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "vibsotr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор сотрудника";
            this.Load += new System.EventHandler(this.vibsotr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button Manager;
        private System.Windows.Forms.Button izadatel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}