using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityLibrary;

namespace Session_07
{
    public partial class FormInterface : Form
    {
        string FILE_NAME_Students = "Students.json";
        string FILE_NAME_Professors = "Professors.json";
        string FILE_NAME_Universities = "Universities.json";
        private List<Student> _students;
        private List<Professor> _professors;
        private List<University> _universities;
        
        public FormInterface()
        {
            InitializeComponent();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormEdit();
            f.WhatKindOfObject = 0;
            f.Students = _students;
            f.ShowDialog();
        }

        private void universitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormEdit();
            f.WhatKindOfObject = 1;
            f.Universities = _universities;
            f.ShowDialog();

        }

        private void professorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormEdit();
            f.WhatKindOfObject = 2;
            f.Professors = _professors;
            f.ShowDialog();

        }

        private void FormInterface_Load(object sender, EventArgs e)
        {

        }

        private void Load_Click(object sender, EventArgs e)
        {
        }

        private void loadStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData(0);
            MessageBox.Show("Loading was succesfull");
        }


        private void LoadData(int WhatKindOfObject)
        {

            if (WhatKindOfObject == 0)
            {
                string s = File.ReadAllText(FILE_NAME_Students);



                _students = (List<UniversityLibrary.Student>)JsonSerializer.Deserialize(s, typeof(List<UniversityLibrary.Student>));

            }
            else if (WhatKindOfObject == 1)
            {
                string s = File.ReadAllText(FILE_NAME_Universities);



                _universities = (List<UniversityLibrary.University>)JsonSerializer.Deserialize(s, typeof(List<UniversityLibrary.University>));

            }
            else if (WhatKindOfObject == 2)
            {
                string s = File.ReadAllText(FILE_NAME_Professors);



                _professors = (List<UniversityLibrary.Professor>)JsonSerializer.Deserialize(s, typeof(List<UniversityLibrary.Professor>));

            }

        }

        private void loadUniversitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData(1);
            MessageBox.Show("Loading was succesfull");
        }

        private void loadProfessorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData(2);
            MessageBox.Show("Loading was succesfull");

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }

}
