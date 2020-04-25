using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Korop_AI_8
{
    public partial class Add : Form
    {
        MainForm context;
        public Add(MainForm context)
        {
            InitializeComponent();
            this.context = context;
            btnAdd.Click += new EventHandler(AddClick);
        }
        /// <summary>
        /// Добавление нового файла по нажатию кнопки
        /// </summary>
        private void AddClick(object sender, EventArgs e)
        {
            var count = 0;
            XDocument xdoc = XDocument.Load(MainForm.source);

            foreach (var f in xdoc.Element("files").Elements("file"))
            {
                if ((f.Element("folder").Value + "\\" + f.Element("name").Value + "." + f.Element("expansion").Value)
                    == (folderTextBox.Text + "\\" + nameTextBox.Text + "." + expansionTextBox.Text))
                {
                    count++;
                }
            }
            if (count != 0)
                MessageBox.Show("Такой файл в данном каталоге уже существует");
            else
            {
                if (folderTextBox.Text != "" && nameTextBox.Text != "" && expansionTextBox.Text != "" && dateTextBox.Text != ""
                && deleteTextBox.Text != "" && timeTextBox.Text != "" && sectorTextBox.Text != "")
                {
                        xdoc.Element("files").Add(new XElement("file",
                            new XElement("folder", folderTextBox.Text),
                            new XElement("name", nameTextBox.Text),
                            new XElement("expansion", expansionTextBox.Text),
                            new XElement("date", dateTextBox.Text),
                            new XElement("time", timeTextBox.Text),
                            new XElement("delete", deleteTextBox.Text),
                            new XElement("sector", sectorTextBox.Text),
                            new XElement("read", readCheckBox.Checked),
                            new XElement("hidden", hiddenCheckBox.Checked),
                            new XElement("system", systemCheckBox.Checked)));
                        xdoc.Save(MainForm.source);
                        context.showAll(null, null);
                        Close();
                }
                else
                {
                    MessageBox.Show("Заполните все поля");
                }
            }
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}
