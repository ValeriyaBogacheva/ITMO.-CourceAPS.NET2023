using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace students
{
    public partial class ShowStudents : System.Web.UI.Page
    {
        int selectedID;
        string selectedFirstName;
        string selectedLastName;
        SampleContext context;
        protected void Page_Load(object sender, EventArgs e)
        {
            context = new SampleContext();
            if (IsPostBack)
            {
                Page.Validate();
                if (!Page.IsValid)
                    return;
                int point = 0;
              
                if (int.TryParse(TextBox1.Text, out point))
                {
                    if (GridView1.SelectedIndex < 0)
                    {
                        Label1.ForeColor = System.Drawing.Color.Red;
                        return;
                    }
                    try
                    {
                        int.TryParse(GridView1.SelectedRow.Cells[1].Text, out selectedID);
                        var student = context._Students.Find(selectedID);
                        student.sumPoints = student.sumPoints + point;
                        student.points = student.points + " " + point.ToString();
                        context.SaveChanges();
                        Response.Redirect(Request.Url.ToString());

                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.ForeColor = System.Drawing.Color.Black;
            int.TryParse(GridView1.SelectedRow.Cells[1].Text, out selectedID);
            selectedFirstName = GridView1.SelectedRow.Cells[2].Text;
            selectedLastName = GridView1.SelectedRow.Cells[3].Text;
            Label1.Text = selectedFirstName + " " + selectedLastName;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropDownList1.SelectedIndex)
            {
                case 0:
                    GridView1.Sort("ID", SortDirection.Ascending);
                    GridView1.AllowPaging = false;
                    break;
                case 1:
                    GridView1.Sort("sumPoints", SortDirection.Descending);
                    GridView1.AllowPaging = true;
                    GridView1.PageSize = 5;
                    GridView1.PagerSettings.Visible = false;
                    break;
                case 2:
                    GridView1.Sort("sumPoints", SortDirection.Ascending);
                    GridView1.AllowPaging = true;
                    GridView1.PageSize = 5;
                    GridView1.PagerSettings.Visible = false;

                    break;
            }
        }
    }
}