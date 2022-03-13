using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityLibrary
{[Serializable]
    public class Course
    {

     public Guid Id { get; set; }
    public string Code { get; set; }
    
    public string Subject { get; set; }
        



    
   

        public Course()
        {
        Subject = string.Empty;
        Id = Guid.NewGuid();
        
        }

      
        

        
   

    }
}
