using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ClassLibrary3
{
    public class Class1
    {
        public static bool Login(string login, string password)
        {
            Model1Container db = new Model1Container();
            var user = db.UserSet.FirstOrDefault(x => x.Login == login);
            if (user == null)
            {
                return false;
            }
            else
            {
                if (user.assword == password)
                {
                    return true;
                }
                else return false;
            }
        }
            
     
    }
}
