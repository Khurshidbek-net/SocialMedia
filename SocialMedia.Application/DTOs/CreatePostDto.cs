using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Application.DTOs
{
    public class CreatePostDto
    {
        public string Content { get; set; }
        public int UserId { get; set;}
    }
}
