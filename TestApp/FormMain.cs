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

namespace TestApp
{
    public partial class FormMain : Form
    {
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
            Student student =  universityListBox.GetItem<Student>();
            MessageBox.Show(student.Name + " " + student.Salary + " " + student.Age);
        }
    }
}
