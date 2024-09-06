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
    public class FollowerService : IFollowerService
    {

        private readonly SocialMediaDbContext _context;

        public FollowerService(SocialMediaDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddFollower(Follower newFollower)
        {
            _context.Followers.Add(newFollower);
            int result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task DeleteFollower(int id)
        {
            var follower = await _context.Followers.FindAsync(id);
            if (follower != null)
                _context.Followers.Remove(follower);
            _context.SaveChangesAsync();
                
        }

        public async Task<IEnumerable<Follower>> GetFollowers()
        {
            return await _context.Followers.ToListAsync();
        }

        public async Task<Follower> GetFollowerById(int id)
        {
            return await _context.Followers.FindAsync(id);
        }

        public async Task<bool> UpdateFollower(Follower newFollower)
        {
            _context.Followers.Update(newFollower);
            int result = await _context.SaveChangesAsync();
            return result > 0;
        }
    }
}
