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

        public IList<ApplicationUser> GetFollowings(string username)
        {
            return (from u in _db.Users
                    from following in u.Following
                    where u.UserName == username
                    select following).ToList();


        }
    }
}