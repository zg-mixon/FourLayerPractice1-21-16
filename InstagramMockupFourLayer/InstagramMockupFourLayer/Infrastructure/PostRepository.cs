
using InstagramMockupFourLayer.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InstagramMockupFourLayer.Infrastructure
{
        public class PostRepository : GenericRepository<Post>
        {
            public PostRepository(DbContext db) : base(db) { }

            public IList<Post> GetPostsForUsers(params string[] usernames)
            {
            
                return (from p in Table
                            .Include(p => p.Owner)
                            .Include(p => p.Categories)
                            .Include(p => p.Location)
                            .Include(p => p.Picture)
                        where p.Active && (usernames.Contains(p.Owner.UserName))
                        orderby p.CreatedDate descending
                        select p).ToList();

            }
        }
    }
