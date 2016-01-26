using InstagramMockupFourLayer.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InstagramMockupFourLayer.Presentation.Controllers
{
    public class PostsController : ApiController
    {
        private PostService _postService;

        public PostsController(PostService postService) {
            _postService = postService;
        }

        //Return a list of newsfeed posts
        public IList<PostDTO> Get() {
            //return _postService.GetNewsFeed(User.Identity.Name);
            return _postService.GetNewsFeed("illisian");
        }

        [HttpGet]
        [Route("api/posts/{username}")]
        public IHttpActionResult Get(string username) {

            var posts = _postService.GetPostsForUser(username);

            if (posts != null) {
                return Ok(posts);
            }

            return BadRequest();
        }

    }
}
