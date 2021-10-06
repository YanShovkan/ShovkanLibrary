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
        UniversityWordTable universityWordTable = new UniversityWordTable();
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
            Dictionary<string, int> columncolumnNamesAndSize = new Dictionary<string, int> { { "Age", 2000 }, { "Name", 4000 }, { "Salary", 3000 } };
            List<string> titles =  new List<string> { "Как", "Так"};
            List<int[]> consolidatedСolumns = new List<int[]> { new int[] { 1, 2 }, new int[] { 2, 3 } };

            list.Add(new Student { Name = "Иван Иванов", Salary = 1000, Age = 24 });
            list.Add(new Student { Name = "Вася", Salary = 410, Age = 19 });
            list.Add(new Student { Name = "Макс", Salary = 255, Age = 34 });

            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    universityWordTable.CreateDoc(dialog.FileName, "Егор бэбридзе", list, consolidatedСolumns, columncolumnNamesAndSize, titles);
                }
            }
        }
    }
}
