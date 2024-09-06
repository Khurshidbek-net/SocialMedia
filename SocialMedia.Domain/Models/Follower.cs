using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Domain.Models
{
    public class Follower
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FollowerId { get; set; }
        public User User { get; set; }
        public User FollowerUser { get; set; }
    }   
}
