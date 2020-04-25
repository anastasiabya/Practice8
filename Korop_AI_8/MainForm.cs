using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Korop_AI_8
{
    public partial class MainForm : Form
    {
        public int ind = 0;
        public string val = "";
        public static string source = "../../../source.xml";
        public MainForm()
        {
            InitializeComponent();
            showAll(null, null);
            this.showAllToolStripMenuItem.Click += new EventHandler(showAll);
            this.deleteToolStripMenuItem.Click += new EventHandler(DeleteClick);
            this.setSearchToolStripMenuItem.Click += new System.EventHandler(this.SearchClick);
        }
        /// <summary>
        /// Показать информацию о всех файлах
        /// </summary>
        public void showAll(object sender, EventArgs e)
        {
            
                XDocument xdoc = XDocument.Load(source);
                var files = xdoc.Element("files");
                tableView.Text = "";
                foreach (XElement xe in files.Elements("file"))
                {
                    tableView.Text += getInfo(xe);
                }
        }

        /// <summary>
        /// Информация о файле в виде строки
        /// </summary>
        /// <param name="xe">XElement с информацией о файле</param>
        /// <returns>Информация о файле</returns>
        public string getInfo(XElement xe)
        {
            string info = "";
            XElement folder = xe.Element("folder");
            XElement name = xe.Element("name");
            XElement expansion = xe.Element("expansion");
            XElement date = xe.Element("date");
            XElement time = xe.Element("time");
            XElement delete = xe.Element("delete");
            XElement sector = xe.Element("sector");
            XElement read = xe.Element("read");
            XElement hidden = xe.Element("hidden");
            XElement system = xe.Element("system");

            if ((folder.Value == "") || (name.Value=="") || (expansion.Value=="") || (date.Value == "")
                 || (time.Value == "") || (delete.Value == "") || (sector.Value == ""))
                info = "";
            else
            {
                if (read.Value == "") read.Value = "false";
                if (hidden.Value == "") hidden.Value = "false";
                if (system.Value == "") system.Value = "false";
                info = Environment.NewLine + "Каталог: " + folder.Value + Environment.NewLine +
                       "Имя файла: " + name.Value + Environment.NewLine +
                       "Расширение: " + expansion.Value + Environment.NewLine +
                       "Дата создания: " + date.Value + Environment.NewLine +
                       "Время создания: " + time.Value + Environment.NewLine +
                       "Признак удаления: " + delete.Value + Environment.NewLine +
                       "Количество выделенных секторов: " + sector.Value + Environment.NewLine +
                       "Только чтение: " + read.Value + Environment.NewLine +
                       "Скрытый: " + hidden.Value + Environment.NewLine +
                       "Системный: " + system.Value + Environment.NewLine + "________________________________" + Environment.NewLine;
            }
                return info;
        }

        /// <summary>
        /// Открытие формы с поиском файлов
        /// </summary>
        private void SearchClick(object sender, EventArgs e)
        {
            Search sear = new Search(this, ind, val);
            sear.Show();
        }

        /// <summary>
        /// Открытие формы с добавлением нового файла
        /// </summary>
        private void AddClick(object sender, EventArgs e)
        {
            Add add = new Add(this);
            add.Show();
        }

        /// <summary>
        /// Открытие формы с удалением файла
        /// </summary>
        private void DeleteClick(object sender, EventArgs e)
        {
            Delete del = new Delete(this);
            del.Show();
        }

        /// <summary>
        /// Вывод в текстовое поле результат поиска
        /// </summary>
        /// <param name="ind">Индекс параметра для сравнения</param>
        /// <param name="str">Значение, по которому происходит поиск</param>
        public void Search(int ind, String str)
        {
            String param = "";
            switch (ind)
            {
                case 0:
                    param = "folder";
                    break;
                case 1:
                    param = "date";
                    break;
                case 2:
                    param = "delete";
                    break;
            }
            tableView.Text = "";
            try
            {
                var res = XDocument.Load(source).Element("files").Elements("file").Where(s => s.Element(param).Value.ToLower().Contains(str.ToLower()));
                foreach (XElement xe in res)
                {
                    tableView.Text += getInfo(xe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
