using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestGithub.Dao
{
    public class UserDao
    {
        private ConectionDataContext db = new ConectionDataContext();

        public user getUserById (int id)
        {
            return db.users.FirstOrDefault(user => user.id == id);
        }
    }
}