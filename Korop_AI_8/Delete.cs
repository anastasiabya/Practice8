using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Korop_AI_8
{
    public partial class Delete : Form
    {
        MainForm context;
        public Delete(MainForm context)
        {
            InitializeComponent();
            this.context = context;
            btnDel.Click += new EventHandler(DeleteClick);
        }

        /// <summary>
        /// Удаление файла по данным в формате "каталог\имя_файла.расширение"
        /// </summary>
        private void DeleteClick(object sender, EventArgs e)
        {
                XDocument xdoc = XDocument.Load(MainForm.source);
                context.showAll(null, null);
                var delFile = xdoc.Element("files").Elements("file").Where(s => s.Element("folder").Value + "\\" + s.Element("name").Value + "." + s.Element("expansion").Value == delTextBox.Text);

                if (delFile.Count() == 0)
                {
                    MessageBox.Show("Такого файла не существует" );
                }
                else
                {
                    delFile.Remove();
                    xdoc.Save(MainForm.source);
                    context.showAll(null, null);
                }
                Close();
        }
    }
}
