namespace Korop_AI_8
{
    partial class Delete
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
        private System.Windows.Forms.TextBox delTextBox;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label delLabel;
        private void InitializeComponent()
        {
            this.delTextBox = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.delLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delTextBox
            // 
            this.delTextBox.Location = new System.Drawing.Point(18, 32);
            this.delTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.delTextBox.Name = "delTextBox";
            this.delTextBox.Size = new System.Drawing.Size(320, 20);
            this.delTextBox.TabIndex = 0;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Pink;
            this.btnDel.Location = new System.Drawing.Point(112, 56);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(135, 27);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // delLabel
            // 
            this.delLabel.Location = new System.Drawing.Point(15, 8);
            this.delLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.delLabel.Name = "delLabel";
            this.delLabel.Size = new System.Drawing.Size(338, 22);
            this.delLabel.TabIndex = 2;
            this.delLabel.Text = "Введите данные в формате \"каталог\\имя_файла.расширение\"";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(349, 94);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.delLabel);
            this.Controls.Add(this.delTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Delete";
            this.Text = "Удаление файла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}