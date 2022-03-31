using AutoMapper;
using WebApiCommander.Dtos;
using WebApiCommander.Models;

namespace WebApiCommander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
        }
    }
}
