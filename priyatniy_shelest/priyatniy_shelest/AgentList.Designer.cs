namespace priyatniy_shelest
{
    partial class AgentList
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
            this.outputData = new System.Windows.Forms.DataGridView();
            this.deleteBotton = new System.Windows.Forms.Button();
            this.deleteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outputData)).BeginInit();
            this.SuspendLayout();
            // 
            // outputData
            // 
            this.outputData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputData.Location = new System.Drawing.Point(48, 53);
            this.outputData.Name = "outputData";
            this.outputData.Size = new System.Drawing.Size(387, 197);
            this.outputData.TabIndex = 0;
            this.outputData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // deleteBotton
            // 
            this.deleteBotton.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBotton.Location = new System.Drawing.Point(159, 352);
            this.deleteBotton.Name = "deleteBotton";
            this.deleteBotton.Size = new System.Drawing.Size(66, 23);
            this.deleteBotton.TabIndex = 1;
            this.deleteBotton.Text = "Удалить";
            this.deleteBotton.UseVisualStyleBackColor = true;
            this.deleteBotton.Click += new System.EventHandler(this.deleteBotton_Click);
            // 
            // deleteTextBox
            // 
            this.deleteTextBox.Location = new System.Drawing.Point(48, 354);
            this.deleteTextBox.Name = "deleteTextBox";
            this.deleteTextBox.Size = new System.Drawing.Size(100, 20);
            this.deleteTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите id";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(473, 354);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(473, 63);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(100, 20);
            this.searchTextbox.TabIndex = 5;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            this.searchTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kd_searchTB);
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(473, 44);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(39, 13);
            this.search.TabIndex = 6;
            this.search.Text = "Поиск";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(473, 89);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Обновить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // AgentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteTextBox);
            this.Controls.Add(this.deleteBotton);
            this.Controls.Add(this.outputData);
            this.Name = "AgentList";
            this.Text = "Вывод";
            ((System.ComponentModel.ISupportInitialize)(this.outputData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView outputData;
        private System.Windows.Forms.Button deleteBotton;
        private System.Windows.Forms.TextBox deleteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.Button clearButton;
    }
}