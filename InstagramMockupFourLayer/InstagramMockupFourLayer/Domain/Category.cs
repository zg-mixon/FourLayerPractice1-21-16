using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InstagramMockupFourLayer.Domain
{
    public class Category : IDbEntity, IActivatable
    {
        public int Id { get; set; }

        public IList<Post> Posts { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; } = true;
    }
}