﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _24Assignment.Data;
using _24Assignment.Models;

namespace _24Assignment.Services
{
    public class PostService
    {
        private readonly Guid _userId;
        private ApplicationDbContext _context = new ApplicationDbContext();
        public PostService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreatePost(PostCreate model)
        {
            var entity = new Post()
                {
                    AuthorId = _userId,
                    Title = model.Title,
                    Text = model.Text,
                };
            _context.Posts.Add(entity);
            return _context.SaveChanges() == 1;
                
        }

        public IEnumerable<PostListItem> GetPosts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Posts.Where(e => e.AuthorId == _userId).Select(e => new PostListItem { PostId = e.PostId, Title = e.Title});
                return query.ToArray();
            }
        }

        public IEnumerable<LikeListItem> LikeListItems()
        {
            var service = new LikeService(_userId);
            IEnumerable<LikeListItem> likeLists = service.GetLikes();
            return likeLists;
        }


        public PostDetail GetPostById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Posts.Single(e => e.PostId == id && e.AuthorId == _userId);

                var commentService = new CommentService(_userId);
                IEnumerable<CommentListItem> commentList = commentService.GetCommentsById(entity.PostId);

                var likeLists = LikeListItems();

                return new PostDetail
                {
                    PostId = entity.PostId,
                    Title = entity.Title,
                    Text = entity.Text,
                    AuthorId = entity.AuthorId,
                    Likes = likeLists.Count(),
                    CommentsList = (List<CommentListItem>) commentList,
                };
            }
        }

        public bool UpdatePost(PostEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Posts.Single(e => e.PostId == model.PostId && e.AuthorId == _userId);

                entity.Title = model.Title;
                entity.Text = model.Text;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeletePost(int postId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Posts.Single(e => e.PostId == postId && e.AuthorId == _userId);

                ctx.Posts.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
