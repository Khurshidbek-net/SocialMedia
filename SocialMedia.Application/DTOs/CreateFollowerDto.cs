using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Application.DTOs
{
    public class CreateFollowerDto
    {
        public int UserId { get; set; }
        public int FollowerId { get; set; }
    }
}
