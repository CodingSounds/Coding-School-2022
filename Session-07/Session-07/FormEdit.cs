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
    public partial class FormEdit : Form
    {
        public int WhatKindOfObject { get; set; }

        private bool _newItemOn;

        private bool _delete;

        public string _textBack { get; set; }
        


        public University Uni { get; set; }
        
        public List<University> Universities { get; set; }

        public List<Professor> Professors { get; set; }

        public List<Student> Students { get; set; }


        #region UI Controls
        public FormEdit()
        {
            InitializeComponent();
         
            
        }


        private void txtName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_EditValueChanged(object sender, EventArgs e)
        {

        }

        //Ti patao
        void listOfObject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //bound bug wtf??

        //Done load                     
        private void FormEdit_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = Students;
            _newItemOn = false;
            _delete = false;
            

            SwitchVisibility();


            try
            {
                
                if (WhatKindOfObject == 1)
                {



                    var _show = new ShowListUniversities();
                    _show.form = this;
                    _show.Universities = Universities;
                    _show.Showing();
                }
                else if (WhatKindOfObject == 0)
                {
                    /*bsStudents.DataSource = Students;
                    bsStudents.DataMember = "Name";
                    this.listOfObject.DataBindings.DefaultDataSourceUpdateMode.Equals(1);
                    this.listOfObject.DataBindings.Add(new Binding("EditValue", bsStudents, "Name", true));
                    */


                    /*var _show = new ShowListStudents();
                    _show.form = this;
                    _show.Students = Students;
                    _show.Showing();*/
                    


                }
                else if (WhatKindOfObject == 2)
                {
                    var _show = new ShowListProfessor();
                    _show.form = this;
                    _show.Professors = Professors;
                    _show.Showing();
                }




            }
            catch (Exception)
            {
                MessageBox.Show("You did not load the  file");
                this.DialogResult = DialogResult.OK;

            }
            













        }


        private void listOfObject_MouseClick(object sender, MouseEventArgs e)
        {

            listOfGrades.Items.Clear();
            ListOfShedule.Items.Clear();
            listOfStudents.Items.Clear();
            listOfCourses.Items.Clear();

            
            var index_Click = listOfObject.SelectedIndex;
            if (_delete)
            {
                if (WhatKindOfObject == 0)
                {
                    Students.RemoveAt(index_Click);
                    ShowList_Student(Students);



                }
                if(WhatKindOfObject==2)
                {
                    Professors.RemoveAt(index_Click);
                    ShowList_Professor(Professors);
                }
                if (WhatKindOfObject == 1)
                {
                    Universities.RemoveAt(index_Click);
                    ShowList_Universities(Universities);
                }
                SaveData();
            }
            _delete= false;

            SwitchVisibility();
            VisibilityFormat();
            
            if (WhatKindOfObject == 1)
            {
                try
                {
                    var x = Universities[index_Click];
                    DisplayObj(x.Name, x.YearsInServvice.ToString(), null, null, x.Courses, x.Students, x.Grades, x.ScheduledCourses);

                }
                catch (Exception)
                {
                    DisplayObj("Enter Name", "Enter Years In Service", null);


                }
            }
            if (WhatKindOfObject == 0)
            {
                try
                {
                    var z = Students[index_Click];
                    DisplayObj(z.Name, z.Age.ToString(), z.RegistrationNumber.ToString(), null, z.Courses);
                }
                catch (Exception)
                {
                    
                    DisplayObj("Enter Name", "Enter Age","Enter registration number");


                }
                
            }
            if (WhatKindOfObject == 2)
            {
                try
                {
                    var z = Professors[index_Click];
                    DisplayObj(z.Name, z.Age.ToString(), null, z.Rank,z.Courses);
                }
                catch (Exception)
                {
                    DisplayObj("Enter Name", "Enter Age", null,"Enter Rank");

                }
                

            }















            }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            listOfObject.Items.Add("Click here to enter new object");
            _newItemOn = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_newItemOn == true)
                {
                    if (WhatKindOfObject == 0)
                    {
                        var _student = new Student();
                        _student.Name = txtName.Text;
                        _student.Age = Convert.ToInt32(txtAge.Text);
                        _student.RegistrationNumber = Convert.ToInt32(txtRegNumber.Text);

                        Students.Add(_student);
                        ShowList_Student(Students);
                    }
                    else if (WhatKindOfObject == 2)
                    {
                        var _professor = new Professor();
                        _professor.Name = txtName.Text;
                        _professor.Age = Convert.ToInt32(txtAge.Text);
                        _professor.Rank = txtRegNumber.Text;

                        Professors.Add(_professor);
                        ShowList_Professor(Professors);

                    }
                    else
                    {
                        var _uni = new University();
                        _uni.Name = txtName.Text;
                        _uni.YearsInServvice = Convert.ToInt32(txtAge.Text);

                        Universities.Add(_uni);
                        ShowList_Universities(Universities);
                    }
                    _newItemOn = false;
                    SaveData();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Wrong insert");
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _delete = true;
            MessageBox.Show("Choose the item you want to delete");

        }


        #endregion




        private void ShowList_Professor(List<Professor> list)
        {

            listOfObject.Items.Clear();

            foreach (Person _person in list)
            {

                if (_person != null)
                    listOfObject.Items.Add(string.Format("{0}", _person.Name));
            }
        }

        private void ShowList_Student(List<Student> list)
        {

            listOfObject.Items.Clear();

            foreach (Person _person in list)
            {

                if (_person != null)
                    listOfObject.Items.Add(string.Format("{0}", _person.Name));
            }
        }



        private void ShowList_Universities(List<University> list)
        {

            listOfObject.Items.Clear();

            foreach (University _university in list)
            {

                if (_university != null)
                    listOfObject.Items.Add(string.Format("{0}", _university.Name));
            }
        }
   
        private void DisplayObj(string name, string age,string regNumber, string rank = null, List<Course> courses = null,
            List<Student> students = null, List<Grade> grades = null, List<Schedule> schedules = null)
        {

            if (WhatKindOfObject == 1)
            {
                txtRegNumber.Visible = false;

            }


            if (name != null)
            {
                txtName.Text = name;

            }

            if (age != null)
            {
                txtAge.Text = Convert.ToString(age);
            }
            if (regNumber != null)
            {
                txtRegNumber.Text = regNumber.ToString();
                

            }
            if (rank != null)
            {
                    txtRegNumber.Text = rank;
                    




                }
            if (courses != null)
            {
                foreach (var course in courses)
                {
                    listOfCourses.Items.Add(course.Subject);

                }
                

            }
            if (grades != null)
            {
                foreach (var grade in grades)
                {
                    listOfGrades.Items.Add(grade.Num);
                }
                


            }
            if (schedules != null)
            {
                foreach (var schedule in schedules)
                {
                    ListOfShedule.Items.Add(schedule.Callendar);
                }
                
            }
            if (students != null)
            {
                foreach (var student in students)
                {
                    listOfStudents.Items.Add(student.Name);
                }


            }
            
        }

        private void VisibilityFormat()
        {

            if (WhatKindOfObject == 0|| WhatKindOfObject == 2)//0=mathite kathigites
            {

                listOfGrades.Visible = !(listOfGrades.Visible);

                listOfStudents.Visible = !listOfStudents.Visible;

                ListOfShedule.Visible = !ListOfShedule.Visible;
            }
        }
        private void SwitchVisibility()
        {
            listOfGrades.Visible = !(listOfGrades.Visible);

            listOfStudents.Visible = !listOfStudents.Visible;

            ListOfShedule.Visible = !ListOfShedule.Visible;

            listOfCourses.Visible = !listOfCourses.Visible;

            txtAge.Visible = !txtAge.Visible;

            txtName.Visible = !txtName.Visible;

            txtRegNumber.Visible = !txtRegNumber.Visible;


        }
      

        private void SaveData()
        {
            if (WhatKindOfObject == 0)
            {
                string json = JsonSerializer.Serialize(Students);
                File.WriteAllText("Students.Json", json);

                MessageBox.Show("File Saved!");

            }
            else if (WhatKindOfObject == 1)
            {
                string json = JsonSerializer.Serialize(Universities);
                File.WriteAllText("Universities.Json", json);

                MessageBox.Show("File Saved!");


            }
            else if (WhatKindOfObject == 2)
            {
                string json = JsonSerializer.Serialize(Professors);
                File.WriteAllText("Professors.Json", json);

                MessageBox.Show("File Saved!");

            }
            

            
        }




















































































        //Cant use forms objects

        public abstract class ShowObjectListAbstract 
        {
            public FormEdit f { get; set; }
            public ShowObjectListAbstract()
            {

            }
            public abstract void ShowList();
        }


        public class ShowStudentList : ShowObjectListAbstract
        {
            public List<Student> Students { get; set; }

            
            

            public ShowStudentList()
            {
                
            }

            public override void ShowList()
            {

                var x = 0;

                foreach (Student _student in Students)
                {
                    x++;


                    if (_student.Name != "")
                        x = 2;
                    f.listOfObject.Items.Add(string.Format("{0}", _student.Name));
                }


            }



        }
        public class ShowProfessorList : ShowObjectListAbstract
        {
            public List<Person> Professors { get; set; }
            public ShowProfessorList()
            {

            }
            public override void ShowList()
            {

                var x = 0;

                foreach (Professor _professor in Professors)
                {
                    x++;


                    if (_professor.Name != "")
                        x = 2;
                    f.listOfObject.Items.Add(string.Format("{0}", _professor.Name));
                }


            }
        }

        private void listOfGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _clicknumber = listOfGrades.SelectedIndex;


            //EditMatrix(int _selectedIndex)






        }
        private void EditMatrix<T>(int _selectedIndex,T _matrixName)
        {
            var x = MessageBox.Show("Want to change value", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (x == DialogResult.OK)
            {
                var t = new FormListChange();
                t.ShowDialog();
                _textBack = t.TextForward;
                //listOfGrades.Items.Insert(_matrixName.SelectedIndex, _textBack);

            }
        }

        private void grid1List(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }


    
 }


    





