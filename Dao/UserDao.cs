using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestGithub.Models;

namespace TestGithub.Dao
{
    public  static class UserDao
    {
        private static ConnectionDataContext db = new ConnectionDataContext();

        public static List<user> getUserById ()
        {
            return db.users.ToList();
        }
    }
}