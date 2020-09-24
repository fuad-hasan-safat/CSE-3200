using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AustOldBook
{
    class LoginInformation
    {
        public static string loginUserId;
        public static string nameofUser;
        public static string emailOfUser;
        public static string addressOfUser;
        public static string contactOfUser;


        public static void setUser( string loginUserId_,  string nameofUser_, string emailOfUser_,string addressOfUser_, string contactOfUser_)
        {
            loginUserId = loginUserId_;
            nameofUser = nameofUser_;
            emailOfUser = emailOfUser_;
            addressOfUser = addressOfUser_;
            contactOfUser = contactOfUser_;

        }

        //static LogInCheck lgInmodel = new LogInCheck();



        /* public static void logInCheckEnable(UserInfo user)
         {

             AustOldBookDBEntities3 odb = new AustOldBookDBEntities3();
             bool _checkLogin = false;
             foreach (var logIn in odb.LogInChecks)
             {

                 if (user.userId != logIn.userId)
                 {

                 }
                 else
                 {
                     _checkLogin = true;
                     break;

                 }
             }
             if (_checkLogin)
             {
                 var context = new AustOldBook.AustOldBookDBEntities3();



                 foreach (var lg in odb.LogInChecks)
                 {
                     if (user.userId != lg.userId)
                     {
                         lg.isLogIn = "on";

                         // context.LogInChecks.Add(_logIn);

                         context.SaveChanges();
                     }


                 }

             }
             else
             {
                 var context = new AustOldBook.AustOldBookDBEntities3();

                 var _logIn = new AustOldBook.LogInCheck()
                 {
                     loginId = user.userId + DateTime.Now,
                     userId = user.userId,
                     isLogIn = "on"

                 };

                 context.LogInChecks.Add(_logIn);
                 context.SaveChanges();
             }
         }

         //========================================
         public static void logInCheckDisable()
         {


             lgInmodel.loginId = loginUserId;

             using(AustOldBookDBEntities3 odb = new AustOldBookDBEntities3())
             {
                 lgInmodel = odb.LogInChecks.Where(x => x.loginId == lgInmodel.loginId).FirstOrDefault();


                 lgInmodel.isLogIn = LoginInformation.loginUserId;
                 lgInmodel.userId = 
                 lgInmodel.isLogIn = "off";

                 odb.Entry(lgInmodel).State = System.Data.Entity.EntityState.Modified;

                 odb.SaveChanges();
             }


         }*/

    }


}
