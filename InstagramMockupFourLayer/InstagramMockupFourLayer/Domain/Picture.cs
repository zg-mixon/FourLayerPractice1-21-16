using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InstagramMockupFourLayer.Domain
{
    public class Picture : IDbEntity, IActivatable
    {
        public int Id { get; set; }

        //Allows you to specify the inverse property to grab Id from
        [InverseProperty("Pictures")]
        public ApplicationUser Owner { get; set; }

        public string Url { get; set; }

        public bool Active { get; set; } = true;
    }
}