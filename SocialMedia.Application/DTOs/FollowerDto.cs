using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Application.DTOs
{
    public class FollowerDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FollowerId { get; set; }
    }
}
