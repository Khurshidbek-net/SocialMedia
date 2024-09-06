using Microsoft.EntityFrameworkCore;
using SocialMedia.Application.Interfaces;
using SocialMedia.Domain.Models;
using SocialMedia.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Application.Services
{
    public class CommentService : ICommentService
    {

        private readonly SocialMediaDbContext _context;

        public CommentService(SocialMediaDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateCommentAsync(Comment comment)
        {
            _context.Comments.Add(comment);
            int result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task DeleteCommentAsync(int id)
        {
            var com = await _context.Comments.FindAsync(id);
            _context.Comments.Remove(com);
            await _context.SaveChangesAsync();
        }

        public async Task<Comment> GetCommentByIdAsync(int id)
        {
            return await _context.Comments.FindAsync(id);
        }

        public async Task<IEnumerable<Comment>> GetCommentsAsync()
        {
            return await _context.Comments.ToListAsync();
        }

        public async Task<bool> UpdateCommentAsync(Comment comment)
        {
            _context.Comments.Update(comment);
            int result = await _context.SaveChangesAsync();
            return result > 0;
        }
    }
}
