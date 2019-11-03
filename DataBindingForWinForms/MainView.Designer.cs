namespace DataBindingForWinForms
{
    partial class MainView
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.EvenButton = new System.Windows.Forms.Button();
            this.OddButton = new System.Windows.Forms.Button();
            this.AllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 12);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 21;
            this.DataGridView.Size = new System.Drawing.Size(240, 426);
            this.DataGridView.TabIndex = 0;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(272, 12);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 19);
            this.IdTextBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(378, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 19);
            this.NameTextBox.TabIndex = 1;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(484, 12);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 2;
            this.InsertButton.Text = "追加";
            this.InsertButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(565, 12);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "全件削除";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(646, 12);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // EvenButton
            // 
            this.EvenButton.Location = new System.Drawing.Point(484, 41);
            this.EvenButton.Name = "EvenButton";
            this.EvenButton.Size = new System.Drawing.Size(75, 23);
            this.EvenButton.TabIndex = 2;
            this.EvenButton.Text = "偶数";
            this.EvenButton.UseVisualStyleBackColor = true;
            // 
            // OddButton
            // 
            this.OddButton.Location = new System.Drawing.Point(565, 41);
            this.OddButton.Name = "OddButton";
            this.OddButton.Size = new System.Drawing.Size(75, 23);
            this.OddButton.TabIndex = 2;
            this.OddButton.Text = "奇数";
            this.OddButton.UseVisualStyleBackColor = true;
            // 
            // AllButton
            // 
            this.AllButton.Location = new System.Drawing.Point(646, 41);
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(75, 23);
            this.AllButton.TabIndex = 2;
            this.AllButton.Text = "全件";
            this.AllButton.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AllButton);
            this.Controls.Add(this.OddButton);
            this.Controls.Add(this.EvenButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.DataGridView);
            this.Name = "MainView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DataGridView;
        public System.Windows.Forms.TextBox IdTextBox;
        public System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.Button InsertButton;
        public System.Windows.Forms.Button ClearButton;
        public System.Windows.Forms.Button OKButton;
        public System.Windows.Forms.Button EvenButton;
        public System.Windows.Forms.Button OddButton;
        public System.Windows.Forms.Button AllButton;
    }
}

