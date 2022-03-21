using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityLibrary;

namespace Session_07
{
    internal class ShowListStudents : AbstractShowList
    {
        public ShowListStudents()
        {

        }
        public List<Student> Students { get; set; }
        
        public override void Showing()
        {
            form.listOfObject.Items.Clear();

            foreach (Person _student in Students)
            {

                if (_student != null)
                    form.listOfObject.Items.Add(string.Format("{0}", _student.Name));
            }


        }
    }
    
}
