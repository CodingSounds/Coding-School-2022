using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLibrary.DataObjects
{
    public class User
    {
        public PetShopClass PetShopClass { get; set; }
        public string Username { get; set; }
        public Guid ID { get; set; }
        public string Password { get; set; }
        public bool Auth()
        {
            if (Username == "admin" && Password == "admin")
            {
                return true;
            }
            return false;
        }

        public User()
        {
            ID = Guid.NewGuid();

        }


    }
}
