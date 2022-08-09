using ApiRestaurante.Data.DTOs.ClienteDTO;
using ApiRestaurante.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestaurante.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<CreateClienteDTO, Cliente>();
            CreateMap<Cliente, ReadClienteDTO>();
            CreateMap<UpdateClienteDTO, Cliente>();
        }
    }
}
