using _24Assignment.Models;
using _24Assignment.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _24Assignment.WebAPI.ListController
{
    public class LikeController : ApiController
    {
        public IHttpActionResult Get()
        {
            LikeService likeService = CreateLikeService();
            var likes = likeService.GetLikes();
            return Ok(likes);
        }

        public IHttpActionResult Post(LikeCreate like)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateLikeService();

            if (!service.CreateLike(like))
                return InternalServerError();
            return Ok();
        }
        private LikeService CreateLikeService()
        {
            var ownerId = Guid.Parse(User.Identity.GetUserId());
            var likeService = new LikeService(ownerId);
            return likeService;
        }
    }
}
