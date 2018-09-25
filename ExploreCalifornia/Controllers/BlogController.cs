using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ExploreCalifornia.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            var posts = new[]
            {
                new Post
                {
                    Title = "Post 1",
                    Posted = DateTime.Now + TimeSpan.FromHours(1),
                    Author = "Author 1",
                    Body = "Content body 1"
                },
                new Post
                {
                    Title = "Post 2",
                    Posted = DateTime.Now + TimeSpan.FromHours(2),
                    Author = "Author 2",
                    Body = "Content body 2"
                },
                new Post
                {
                    Title = "Post 3",
                    Posted = DateTime.Now + TimeSpan.FromHours(3),
                    Author = "Author 3",
                    Body = "Content body 3"
                }
            };

            return View(posts);
        }

        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            var post = new Post
            {
                Title = "My blog post",
                Posted = DateTime.Now,
                Author = "Joe Schmoe",
                Body = "This is a great blog post, don't you think?"
            };

            return View(post);
        }
    }
}
