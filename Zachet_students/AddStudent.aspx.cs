using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace students
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                Page.Validate();
                if (!Page.IsValid)
                    return;

                Student student = new Student(FirstName.Text, LastName.Text);
                try
                {
                   
                    SampleContext context = new SampleContext();
                    context._Students.Add(student);
                    context.SaveChanges();
                    Response.Redirect(Request.Url.ToString());
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        protected void FirstName_TextChanged(object sender, EventArgs e)
        {
            if (!char.IsLetter(FirstName.Text.Substring(FirstName.Text.Length - 1).ToCharArray()[0]))
            {
                FirstName.Text.Remove(FirstName.Text.Length - 1);
            }
        }

        protected void LastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}