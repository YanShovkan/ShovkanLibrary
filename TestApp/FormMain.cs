using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualComponents;
using NotVisualComponents;

namespace TestApp
{
    public partial class FormMain : Form
    {
        UniversityWordDocument universityWordDocument = new UniversityWordDocument();
        UniversityWordTable universityWordTable = new UniversityWordTable();
        UniversityWordGraphic universityWordGraphic = new UniversityWordGraphic();

        public FormMain()
        {
            InitializeComponent();
        }


        private void buttonFillListBox_Click(object sender, EventArgs e)
        {
            universityListBox.LayoutString("Имя {Name} , степендия {Salary} , возраст {Age}", '{', '}');
            List<Student> list = new List<Student>();

            list.Add(new Student { Name = "Иван Иванов", Salary = 1000, Age = 24 });
            list.Add(new Student { Name = "Вася", Salary = 410, Age = 19 });
            list.Add(new Student { Name = "Макс", Salary = 255, Age = 34 });

            universityListBox.Fill<Student>(list);
        }

        private void buttonPickFromListBox_Click(object sender, EventArgs e)
        {
            Student student = universityListBox.GetItem<Student>();
            MessageBox.Show(student.Name + " " + student.Salary + " " + student.Age);
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            List<Student> list = new List<Student>();

            list.Add(new Student { Name = "Иван Иванов", Salary = 1000, Age = 24 });
            list.Add(new Student { Name = "Вася", Salary = 410, Age = 19 });
            list.Add(new Student { Name = "Макс", Salary = 255, Age = 34 });

            //1
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    universityWordDocument.CreateDoc(dialog.FileName, "Документ по студентам", new string[] { "1 строка", " 2 строка" });
                }
            }

            //2
            Dictionary<string, int> columncolumnNamesAndSize = new Dictionary<string, int> { { "Age", 2000 }, { "Name", 4000 }, { "Salary", 3000 } };
            List<string> titles = new List<string> { "Личные данные", "Возраст", "Имя", "Стипендия" };
            List<int[]> consolidatedСolumns = new List<int[]> { new int[] { 1, 0 } };


            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    universityWordTable.CreateDoc(dialog.FileName, "Отчет по студентам в таблице", list, consolidatedСolumns, columncolumnNamesAndSize, titles);
                }
            }

            //3
            Dictionary<string, int[]> objects = new Dictionary<string, int[]> { { "line1", new int[] { 1, 2, 5, 134, 123, 333, 1, 23 } }, { "line2", new int[] { 7, 9, 5 } } };

            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    universityWordGraphic.CreateDoc(dialog.FileName, "титл", "legenda", objects, LegendPosition.Top);
                }
            }

        }
    }
}
