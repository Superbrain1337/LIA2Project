using System;
using System.Collections.Generic;
using System.Linq;
using LIA2Project.Models;
using LIA2Project.Models.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.DirectoryServices;
using System.Net.Mail;
using System.Net;

namespace LIA2Project.Controllers
{
    public class UserController : Controller
    {
        UserDataAccessLayer objUser = new UserDataAccessLayer();

        [HttpGet]
        [Route("api/Users/Index")]
        public IEnumerable<Users> Index()
        {
            return objUser.GetAllUsers();
        }

        [HttpGet]
        [Route("api/Users/Login")]
        public bool Login(Guid id, string userName, string password, string email)
        {
            var thisUser = objUser.GetUserDataById(id);
            if(thisUser == null && userName != "")
            {
                thisUser = objUser.GetUserDataByName(userName);
            }
            if (thisUser != null)
            {
                if (AuthenticateAD(thisUser.UserGroupName, thisUser.UserLoginName, thisUser.UserAuthPassword) == true)
                {
                    return true;
                }
            }
            return false;
        }

        [HttpPost]
        [Route("api/Users/Create")]
        public int Create([Bind("UserId")]Users usr)
        {
            return objUser.AddUser(usr);
        }

        [HttpGet]
        [Route("api/Users/Details/{id}")]
        public Users Details(Guid id)
        {
            return objUser.GetUserDataById(id);
        }

        [HttpPut]
        [Route("api/Users/Edit")]
        public int Edit(Users usr)
        {
            return objUser.UpdateUser(usr);
        }

        [HttpDelete]
        [Route("api/Users/Delete/{id}")]
        public int Delete(int id)
        {
            return objUser.DeleteUser(id);
        }

        [HttpGet]
        [Route("api/Users/AuthenticateAD")]
        private bool AuthenticateAD(string userGroupName, string userLoginName, string Password)
        {
            try
            {
                // Kolla om det finns ett entry som pekar vart autentisering ska ske
                //NameValueCollection ldapSettings = (NameValueCollection)ConfigurationManager.GetSection("DuoSTATIONSettings/ldapSettings");
                //string ldapHost = ldapSettings[userGroupName];
                //if (string.IsNullOrEmpty(ldapHost))
                string ldapHost = userGroupName;

                DirectoryEntry entry = new DirectoryEntry("LDAP://" + ldapHost)
                {
                    Username = userGroupName + "\\" + userLoginName,
                    Password = Password
                };
                object obj = entry.NativeObject;
                entry.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpGet]
        [Route("api/Users/SendMail")]
        public bool SendMail(string message, string userMail, string password)
        {
            try
            {
                string sender = "samuel@programduon.se";
                string reciever = "knut@programduon.se";
                var smtp = new SmtpClient
                {
                    Host = sender,
                    Port = 50115,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("sg", "Teddy294" )
                };

                var mess = new MailMessage(sender, reciever)
                {
                    Subject = "Helpdesk ProgramduonAB",
                    Body = message
                };

                smtp.Send(mess);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}