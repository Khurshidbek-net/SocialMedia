using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Application.DTOs;
using SocialMedia.Application.Interfaces;
using SocialMedia.Domain.Models;

namespace SocialMedia.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowerController : ControllerBase
    {
        private readonly IFollowerService _followerService;
        private readonly IMapper _mapper;

        public FollowerController(IFollowerService followerService, IMapper mapper)
        {
            _followerService = followerService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllFollowers()
        {
            var followers = await _followerService.GetFollowers();
            return Ok(followers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var follower = await _followerService.GetFollowerById(id);
            if (follower == null)
                return NotFound();
            return Ok(follower);
        }

        [HttpPost]
        public async Task<IActionResult> CreataFollower([FromBody] CreateFollowerDto createFollowerDto)
        {
            var follower = _mapper.Map<Follower>(createFollowerDto);
            await _followerService.AddFollower(follower);
            return Ok(follower);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody]FollowerDto followerDto)
        {
            if (id != followerDto.Id)
                return BadRequest("Id dismatch");

            var follower = _mapper.Map<Follower>(followerDto);
            await _followerService.UpdateFollower(follower);

            return Ok("Updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var follower = await _followerService.GetFollowerById(id);
            if (follower == null)
                return NotFound();

            await _followerService.DeleteFollower(id);
            return Ok("Deleted");
        }
    }
}
