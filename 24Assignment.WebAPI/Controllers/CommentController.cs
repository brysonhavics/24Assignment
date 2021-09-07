using _24Assignment.Models;
using _24Assignment.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _24Assignment.WebAPI.Controllers
{
    [Authorize]
    public class CommentController : ApiController
    {
        [HttpPost]
        public IHttpActionResult CreateComment(CommentCreate comment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCommentService();

            if (!service.CreateComment(comment))
                return InternalServerError();

            return Ok();
        }

        
        [HttpGet]
        public IHttpActionResult GetCommentByPostId(int Postid)
        {
            CommentService commentService = CreateCommentService();
            var comments = commentService.
        }
        
        private CommentService CreateCommentService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var commentService = new CommentService(userId);
            return commentService;
        }
    }
}
