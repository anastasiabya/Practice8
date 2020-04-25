using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;


namespace Korop_AI_8
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Файл не содержит записей
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "";
            MainForm.source = "../../../UnitTestProject1/testFiles/test1.xml";
            MainForm mainform = new MainForm();
            string actual = mainform.tableView.Text;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Файл содержит одну запись
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            string expected = Environment.NewLine + "Каталог: photos" + Environment.NewLine +
                   "Имя файла: 1" + Environment.NewLine +
                   "Расширение: gif" + Environment.NewLine +
                   "Дата создания: 24.04.2020" + Environment.NewLine +
                   "Время создания: 23:32" + Environment.NewLine +
                   "Признак удаления: полное" + Environment.NewLine +
                   "Количество выделенных секторов: 50" + Environment.NewLine +
                   "Только чтение: true" + Environment.NewLine +
                   "Скрытый: true" + Environment.NewLine +
                   "Системный: true" + Environment.NewLine + "________________________________" + Environment.NewLine;

            MainForm.source = "../../../UnitTestProject1/testFiles/test2.xml";
            MainForm mainform = new MainForm();
            string actual = mainform.tableView.Text;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Файл содержит 2 записи
        /// </summary>
        [TestMethod]
        public void TestMethod3()
        {
            string expected = Environment.NewLine + "Каталог: photos" + Environment.NewLine +
                   "Имя файла: 1" + Environment.NewLine +
                   "Расширение: gif" + Environment.NewLine +
                   "Дата создания: 24.04.2020" + Environment.NewLine +
                   "Время создания: 23:32" + Environment.NewLine +
                   "Признак удаления: полное" + Environment.NewLine +
                   "Количество выделенных секторов: 50" + Environment.NewLine +
                   "Только чтение: true" + Environment.NewLine +
                   "Скрытый: true" + Environment.NewLine +
                   "Системный: true" + Environment.NewLine + "________________________________" + Environment.NewLine +
                   Environment.NewLine + "Каталог: photos" + Environment.NewLine +
                   "Имя файла: 2" + Environment.NewLine +
                   "Расширение: gif" + Environment.NewLine +
                   "Дата создания: 24.04.2020" + Environment.NewLine +
                   "Время создания: 23:32" + Environment.NewLine +
                   "Признак удаления: полное" + Environment.NewLine +
                   "Количество выделенных секторов: 50" + Environment.NewLine +
                   "Только чтение: true" + Environment.NewLine +
                   "Скрытый: true" + Environment.NewLine +
                   "Системный: true" + Environment.NewLine + "________________________________" + Environment.NewLine;

            MainForm.source = "../../../UnitTestProject1/testFiles/test3.xml";
            MainForm mainform = new MainForm();
            string actual = mainform.tableView.Text;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Файл содержит запись без каталога
        /// </summary>
        [TestMethod]
        public void TestMethod4()
        {
            string expected = "";
            MainForm.source = "../../../UnitTestProject1/testFiles/test4.xml";
            MainForm mainform = new MainForm();
            string actual = mainform.tableView.Text;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Файл содержит запись без имени
        /// </summary>
        [TestMethod]
        public void TestMethod5()
        {
            string expected = "";
            MainForm.source = "../../../UnitTestProject1/testFiles/test5.xml";
            MainForm mainform = new MainForm();
            string actual = mainform.tableView.Text;

            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// Файл содержит запись без расширения
        /// </summary>
        [TestMethod]
        public void TestMethod6()
        {
            string expected = "";
            MainForm.source = "../../../UnitTestProject1/testFiles/test6.xml";
            MainForm mainform = new MainForm();
            string actual = mainform.tableView.Text;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Файл содержит запись без даты создания
        /// </summary>
        [TestMethod]
        public void TestMethod7()
        {
            string expected = "";
            MainForm.source = "../../../UnitTestProject1/testFiles/test7.xml";
            MainForm mainform = new MainForm();
            string actual = mainform.tableView.Text;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Файл содержит запись без времени создания
        /// </summary>
        [TestMethod]
        public void TestMethod8()
        {
            string expected = "";
            MainForm.source = "../../../UnitTestProject1/testFiles/test8.xml";
            MainForm mainform = new MainForm();
            string actual = mainform.tableView.Text;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Файл содержит запись без признака удаления
        /// </summary>
        [TestMethod]
        public void TestMethod9()
        {
            string expected = "";
            MainForm.source = "../../../UnitTestProject1/testFiles/test9.xml";
            MainForm mainform = new MainForm();
            string actual = mainform.tableView.Text;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Файл содержит запись без количества выделенных секторов
        /// </summary>
        [TestMethod]
        public void TestMethod10()
        {
            string expected = "";
            MainForm.source = "../../../UnitTestProject1/testFiles/test10.xml";
            MainForm mainform = new MainForm();
            string actual = mainform.tableView.Text;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Файл содержит запись без "только чтение", "скрытый", "системный"
        /// </summary>
        [TestMethod]
        public void TestMethod11()
        {
            string expected = Environment.NewLine + "Каталог: photos" + Environment.NewLine +
                   "Имя файла: 1" + Environment.NewLine +
                   "Расширение: gif" + Environment.NewLine +
                   "Дата создания: 24.04.2020" + Environment.NewLine +
                   "Время создания: 23:32" + Environment.NewLine +
                   "Признак удаления: полное" + Environment.NewLine +
                   "Количество выделенных секторов: 50" + Environment.NewLine +
                   "Только чтение: false" + Environment.NewLine +
                   "Скрытый: false" + Environment.NewLine +
                   "Системный: false" + Environment.NewLine + "________________________________" + Environment.NewLine;

            MainForm.source = "../../../UnitTestProject1/testFiles/test11.xml";
            MainForm mainform = new MainForm();
            string actual = mainform.tableView.Text;

            Assert.AreEqual(expected, actual);
        }
    }
}
