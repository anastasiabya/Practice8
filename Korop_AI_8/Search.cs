using System;
using System.Windows.Forms;

namespace Korop_AI_8
{
    public partial class Search : Form
    {
        MainForm context;
        public Search(MainForm context, int ind, string val)
        {
            InitializeComponent();
            this.context = context;
            searchComboBox.SelectedIndex = ind;
            valueTextBox.Text = val;
            btnShow.Click += new System.EventHandler(SearchClick);
        }
        /// <summary>
        /// Вывод в текстовое поле найденных файлов
        /// </summary>
        private void SearchClick(object sender, EventArgs e)
        {
            context.Search(searchComboBox.SelectedIndex, valueTextBox.Text);
            Close();
        }
    }
}
