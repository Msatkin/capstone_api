using Capstone_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Capstone_Api.Apis
{
    public class RegisterController : ApiController
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        [HttpPost]
        public string Post(string username, string password, string email)
        {
            if (CheckUsername(username) && CheckEmail(email))
            {
                CreateUser(username, password, email);
                return "success";
            }
            if (!CheckEmail(email))
            {
                return "email";
            }
            if (!CheckUsername(username))
            {
                return "username";
            }
        }

        private void CreateUser(string username, string password, string email)
        {
            int salt = GetSalt(username);
            
        }

        private bool CheckUsername(string username)
        {

        }

        private bool CheckEmail(string email)
        {

        }

        private int GetSalt(string username)
        {

        }
    }
}