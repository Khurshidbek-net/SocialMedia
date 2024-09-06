using AutoMapper;
using SocialMedia.Application.DTOs;
using SocialMedia.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserCreateDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<UpdateUserDTO, User>().ReverseMap();

            CreateMap<Post, CreatePostDto>().ReverseMap();
            CreateMap<User, PostDto>().ReverseMap();
            CreateMap<UpdatePostDto, Post>().ReverseMap();

            CreateMap<Comment, CommentDto>().ReverseMap();
            CreateMap<CreateCommentDto, Comment>().ReverseMap();
            CreateMap<Comment, UpdateCommentDto>().ReverseMap();

            CreateMap<Follower, FollowerDto>().ReverseMap();
            CreateMap<Follower, CreateFollowerDto>().ReverseMap();

        }
    }
}
