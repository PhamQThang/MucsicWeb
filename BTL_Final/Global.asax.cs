using BTL_Final.data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BTL_Final
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Counter"] = 0;



            Application["LMF"] = new ArrayList();
            ArrayListGlobal listMusicFrame = new ArrayListGlobal();
            listMusicFrame.addData();
            ArrayList arrayMusicFrame = new ArrayList(listMusicFrame.arrayList);
            Application["LMF"] = arrayMusicFrame;

            Application["Users"] = new ArrayList();
            ArrayListGlobal users = new ArrayListGlobal();
            users.addUsers();
            ArrayList arrayUsers = new ArrayList(users.arrayList);
            Application["Users"] = arrayUsers;

            Application["History"] = new ArrayList();


            Application["LikeMusic"] = new ArrayList();
            ArrayListGlobal likeMusic = new ArrayListGlobal();
            likeMusic.addLikeMusic();
            ArrayList arrayLikeMusic = new ArrayList(likeMusic.arrayList);
            Application["LikeMusic"] = arrayLikeMusic;


            Application["UserList"] = new ArrayList();
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["PlayMusic"] = new ArrayList();
            Session["User"] = new User();
            Session["Search"] = "";



        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {


        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}