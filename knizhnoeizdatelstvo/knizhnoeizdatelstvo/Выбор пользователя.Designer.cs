
namespace knizhnoeizdatelstvo
{
    partial class vibpolz
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Klient = new System.Windows.Forms.Button();
            this.Sotrudnik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Klient
            // 
            this.Klient.Location = new System.Drawing.Point(300, 190);
            this.Klient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Klient.Name = "Klient";
            this.Klient.Size = new System.Drawing.Size(231, 44);
            this.Klient.TabIndex = 1;
            this.Klient.Text = "Клиент";
            this.Klient.UseVisualStyleBackColor = true;
            this.Klient.Click += new System.EventHandler(this.Klient_Click);
            // 
            // Sotrudnik
            // 
            this.Sotrudnik.Location = new System.Drawing.Point(300, 299);
            this.Sotrudnik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sotrudnik.Name = "Sotrudnik";
            this.Sotrudnik.Size = new System.Drawing.Size(231, 44);
            this.Sotrudnik.TabIndex = 2;
            this.Sotrudnik.Text = "Сотрудник";
            this.Sotrudnik.UseVisualStyleBackColor = true;
            this.Sotrudnik.Click += new System.EventHandler(this.Sotrudnik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(360, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "ВХОД";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // vibpolz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::knizhnoeizdatelstvo.Properties.Resources.фон;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sotrudnik);
            this.Controls.Add(this.Klient);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "vibpolz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Klient;
        private System.Windows.Forms.Button Sotrudnik;
        private System.Windows.Forms.Label label1;
    }
}

