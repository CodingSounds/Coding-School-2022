using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityLibrary;

namespace Session_07
{
    internal class ShowListUniversities : AbstractShowList
    {
        public ShowListUniversities()
        {

        }
        public List<University> Universities { get; set; }

        public override void Showing()
        {
            form.listOfObject.Items.Clear();

            foreach (University _uni in Universities)
            {

                if (_uni != null)
                    form.listOfObject.Items.Add(string.Format("{0}", _uni.Name));
            }


        }
    }
}
