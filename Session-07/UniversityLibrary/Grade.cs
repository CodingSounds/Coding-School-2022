﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityLibrary
{
    public class Grade
    {
       

        public Guid ID { get; }
        public Guid StudentID { get; }

        public Guid CourseID { get; }

        public int Num { get; set; }
    public Grade() {
            ID = Guid.NewGuid();
                   }



        
    }
}
