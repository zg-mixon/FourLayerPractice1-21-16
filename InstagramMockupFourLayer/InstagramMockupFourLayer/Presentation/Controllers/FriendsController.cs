using InstagramMockupFourLayer.Services;
using InstagramMockupFourLayer.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InstagramMockupFourLayer.Presentation.Controllers
{
    public class FriendsController : ApiController
    {
        private FriendService _friendService;

        public FriendsController(FriendService friendService)
        {
            _friendService = friendService;
        }

        public IList<ApplicationUserDTO> Get() {
            return _friendService.GetFriendsList("illisian");
        }
    }
}
