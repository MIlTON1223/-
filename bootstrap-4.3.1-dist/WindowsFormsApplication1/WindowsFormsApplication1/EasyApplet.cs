using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EasyApplet : Form
    {
        List<Author> auth = new List<Author>();
        public EasyApplet()
        {
            InitializeComponent();

            UpdateBinding();
        }
        private void UpdateBinding()
        {
            AuthorFoundListBox.DataSource = auth;
            AuthorFoundListBox.DisplayMember = "FullInfo";
        }
        private void AuthorSearchButton_Click(object sender, EventArgs e)
        {
            //call out our database to get the information from a, here our GetAuthor method
            Data da = new Data();
           auth= da.GetAuthor(AuthorNameTextBox.Text);
            AuthorFoundListBox.Refresh();
            UpdateBinding();
        }
    }
}
