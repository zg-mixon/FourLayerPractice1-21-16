
using InstagramMockupFourLayer.Infrastructure;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InstagramMockupFourLayer.Services.Models
{
    public class PostService 
    {
        private PostRepository _postRepo;
        private UserRepository _userRepo;

        public PostService(PostRepository postRepo, UserRepository userRepo)
        {
            _postRepo = postRepo;
            _userRepo = userRepo;
        }


        /// <summary>
        /// News Feed contains all of our posts and our 
        /// friend's posts
        /// </summary>
        /// <returns>A list of posts</returns>
        public IList<PostDTO> GetNewsFeed(string currentUser)
        {
            var followings = (from u in _userRepo.GetFollowings(currentUser)
                              select u.UserName).ToList();
            followings.Add(currentUser);
            

            return (from p in _postRepo.GetPostsForUsers(followings.ToArray())
                    select new PostDTO()
                    {
                        Location = p.Location?.City + ", " + p.Location?.State,
                        Message = p.Message,
                        CreatedDate = p.CreatedDate,
                        PictureUrl = p.Picture?.Url,
                        Categories = (from c in p.Categories
                                      select c.Name).ToList(),
                        Owner = new ApplicationUserDTO() {
                            UserName = p.Owner.UserName
                        }
                    }).ToList();
        }
    }
}