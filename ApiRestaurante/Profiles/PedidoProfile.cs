using ApiRestaurante.Data.DTOs.PedidoDTO;
using ApiRestaurante.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestaurante.Profiles
{
    public class PedidoProfile : Profile
    {
        public PedidoProfile()
        {
            CreateMap<CreatePedidoDTO, Pedido>();
            CreateMap<Pedido, ReadPedidoDTO>();
            CreateMap<UpdatePedidoDTO, Pedido>();
        }
    }
}
