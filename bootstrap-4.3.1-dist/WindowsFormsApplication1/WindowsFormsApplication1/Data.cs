using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication1
{
    public class Data
    {
        public List<Author> GetAuthor(String AuthorName)
        {
            //permit us compile the app while modifying it
            //throw new NotImplementedException();
            using { IDbconnection connection = new System.Data.SqlClient.SqlConnection(Helper.CNNVal("AuthorDB") }}
            {
              var output=  connection.Query<Author>($"select * from people where AuthorName='{AuthorName]' ").ToList();
                return output;
            }
        }
        
    }
}
