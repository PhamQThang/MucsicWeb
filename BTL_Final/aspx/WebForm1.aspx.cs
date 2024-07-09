using BTL_Final.data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace BTL_Final.aspx
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ArrayList arrUser;
        User user;
        ArrayList newarrUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            arrUser = Application["Users"] as ArrayList;
            newarrUser = new ArrayList();
            user = (User)Session["User"] as User;
            newarrUser = Application["UserList"] as ArrayList;
            newarrUser.Add(user);
            if (!IsPostBack)
            {
                if (user.nameUser == null)
                {

                }
                else
                {
                    btnSignUp.Text = user.nameUser;
                    btnSignIn.Text = "Đăng xuất";

                }
                loadForm();
            }
        }

        public void loadForm()
        {
            HtmlGenericControl parentDiv = (HtmlGenericControl)FindControl("list_music");
            string innerHTML = @"<div class=""data"">
                        <table id=""dataTable"" class=""center"">
                            <tr style=""text-align: center;"">
                                <td class=""border-column"">STT</td>
                                <td class=""border-column"">Tên Đăng Nhập</td>
                                <td class=""border-column"">Email</td>
                                <td class=""border-column"">Mật Khẩu</td>
                                <td class=""border-column"">Họ Tên</td>
                                <td class=""border-column"">MST</td>

                            </tr>
                        ";
            string endDiv = @" </table>  </div>";
            int dem = 0;
            foreach(User user  in newarrUser)
            {
                string htmlContent = string.Format(@"
                            <tr style=""text-align: center;"">
                                <td class=""border-column"">{0}</td>
                                <td class=""border-column"">{1}</td>
                                <td class=""border-column"">{2}</td>
                                <td class=""border-column"">{3}</td>
                                <td class=""border-column"">{4}</td>
                                <td class=""border-column"">{5}</td>
                            </tr>
                ", dem, user.nameAccount, user.email, user.password, user.nameUser, user.mst
                );
                dem++;
                innerHTML = innerHTML + htmlContent;
            }
            innerHTML = innerHTML + endDiv;

            parentDiv.InnerHtml = innerHTML;
        }
    }
}