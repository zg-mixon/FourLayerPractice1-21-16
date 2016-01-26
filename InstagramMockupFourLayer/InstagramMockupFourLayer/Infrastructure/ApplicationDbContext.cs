using InstagramMockupFourLayer.Domain;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InstagramMockupFourLayer.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<Category> Categories { get; set; }
        public IDbSet<Location> Locations { get; set; }
        public IDbSet<Post> Posts { get; set; }
        public IDbSet<Picture> Pictures { get; set; }
        

    }
}