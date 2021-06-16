namespace priyatniy_shelest
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.addAgent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(21, 26);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(76, 62);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(291, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(73, 15);
            this.Title.TabIndex = 1;
            this.Title.Text = "Главное окно";
            // 
            // addAgent
            // 
            this.addAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(17)))));
            this.addAgent.Cursor = System.Windows.Forms.Cursors.Default;
            this.addAgent.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAgent.Location = new System.Drawing.Point(277, 133);
            this.addAgent.Name = "addAgent";
            this.addAgent.Size = new System.Drawing.Size(124, 23);
            this.addAgent.TabIndex = 2;
            this.addAgent.Text = "Добавить агента";
            this.addAgent.UseVisualStyleBackColor = false;
            this.addAgent.Click += new System.EventHandler(this.addAgent_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(17)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(277, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Список агентов";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addAgent);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Logo);
            this.Name = "Main";
            this.Text = "Главное окно";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button addAgent;
        private System.Windows.Forms.Button button1;
    }
}

