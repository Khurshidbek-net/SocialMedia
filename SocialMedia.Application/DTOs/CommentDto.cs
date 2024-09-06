﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Application.DTOs
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}