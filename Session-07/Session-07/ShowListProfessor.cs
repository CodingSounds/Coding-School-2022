using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityLibrary;

namespace Session_07
{
    internal class ShowListProfessor : AbstractShowList
    {
        public ShowListProfessor()
        {

        }
        public List<Professor> Professors { get; set; }

        public override void Showing()
        {
            form.listOfObject.Items.Clear();

            foreach (Person _professor in Professors)
            {

                if (_professor != null)
                    form.listOfObject.Items.Add(string.Format("{0}", _professor.Name));
            }


        }
    }
}
