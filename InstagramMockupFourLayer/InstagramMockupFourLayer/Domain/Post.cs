using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InstagramMockupFourLayer.Domain
{
    public class Post : IActivatable, IDbEntity
    {
        public int Id { get; set; }

        public ApplicationUser Owner { get; set; }

        public IList<Category> Categories { get; set; }

        public Location Location { get; set; }

        public Picture Picture { get; set; }

        public string Message { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public bool Active { get; set; } = true;

    }
}