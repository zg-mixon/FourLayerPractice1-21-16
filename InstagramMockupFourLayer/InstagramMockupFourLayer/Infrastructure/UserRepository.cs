using InstagramMockupFourLayer.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InstagramMockupFourLayer.Infrastructure
{
    public class UserRepository
    {

        private ApplicationDbContext _db;

        public UserRepository(DbContext db)
        {
            _db = (ApplicationDbContext)db;
        }

        public IQueryable<ApplicationUser> GetFollowings(string username)
        {
            return from u in _db.Users
                    from following in u.Following
                    where u.UserName == username
                    select following;
        }




        public bool UserExistsCheck(string userName)
        {
            return _db.Users.Any(u => u.UserName == userName);
        }
    }
}