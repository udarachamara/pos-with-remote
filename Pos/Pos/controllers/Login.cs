using BookStore.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Login
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> BirthDay { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
        public string Status { get; set; }
        public byte[] CreateAt { get; set; }
        public bool LoginStatus { get; set; }

        public Login()
        {

        }

        ///<summary>
        ///Returns the true if exist valid user for given username and password other wise false
        ///</summary>
        public bool UserAuthenticate(string username , string password)
        {
            using (var context = new DBEntities())
            {
                try
                {
                    var user = context.Users.Where(u => u.Username == username && u.Password == password).First();
                    if (user.Fname != "")
                    {
                        Fname = user.Fname;
                        Phone = user.Phone;
                        Email = user.Email;
                        UserRole = user.UserRole;
                        LoginStatus = true;
                        return true;
                    }
                    else
                    {
                        LoginStatus = false;
                        return false;
                    }
                }
                catch(Exception)
                {
                    return false;
                }
                
            }
        }

        
    }
}
