﻿using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.DTO;

namespace WebApplication1.Services
{
    public interface ITeamService
    {
        public Task<TeamModelDTO> GetTeam(int TeamID);
        public Task<int> AddMember(int MemberId, int TeamID);
        public Task<bool> IfTeam(int TeamID);
    }
}