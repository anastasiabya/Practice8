namespace Korop_AI_8
{
    partial class Search
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
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label paramLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.ComboBox searchComboBox;
        private void InitializeComponent()
        {
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.paramLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchComboBox
            // 
            this.searchComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.Items.AddRange(new object[] {
            "Каталог",
            "Дата создания",
            "Признак удаления"});
            this.searchComboBox.Location = new System.Drawing.Point(15, 24);
            this.searchComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(204, 21);
            this.searchComboBox.TabIndex = 2;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(15, 69);
            this.valueTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(204, 20);
            this.valueTextBox.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Pink;
            this.btnShow.Location = new System.Drawing.Point(60, 93);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(120, 25);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Показать";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // paramLabel
            // 
            this.paramLabel.Location = new System.Drawing.Point(15, 8);
            this.paramLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paramLabel.Name = "paramLabel";
            this.paramLabel.Size = new System.Drawing.Size(112, 19);
            this.paramLabel.TabIndex = 3;
            this.paramLabel.Text = "Параметр поиска:";
            // 
            // valueLabel
            // 
            this.valueLabel.Location = new System.Drawing.Point(15, 49);
            this.valueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(112, 19);
            this.valueLabel.TabIndex = 4;
            this.valueLabel.Text = "Значение: ";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(235, 121);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.paramLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.valueTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Search";
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}