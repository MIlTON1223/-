using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Author
    {
        public string  AuthorName { get; set; }
        public int AuthorID { get; set; }
        public int AuthorTelephone { get; set; }

        

        public string FullInfo
        {
            get 
            { 
            return $"(AuthorName)([AuthorTelephone])"; 
            }
           
        }

    }
}
