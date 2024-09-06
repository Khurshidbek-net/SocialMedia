using SocialMedia.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Application.Interfaces
{
    public interface IFollowerService
    {
        Task<IEnumerable<Follower>> GetFollowers();
        Task<bool> AddFollower(Follower newFollower);
        Task<Follower> GetFollowerById(int id);
        Task DeleteFollower(int id);
        Task<bool> UpdateFollower(Follower newFollower);
    }
}
