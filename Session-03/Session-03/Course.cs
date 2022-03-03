using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Course
    {

     public Guid Id { get; set; }
    public string Code { get; set; }
    public string Subject { get; set; } 

    public Course(string code,string subject)
        {
        Id = Guid.NewGuid();
        Code = code;
        Subject = subject;
        }

    }
}
