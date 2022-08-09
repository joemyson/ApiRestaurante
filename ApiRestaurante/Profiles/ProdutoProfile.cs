using ApiRestaurante.Data.DTOs.ProdutoDTO;
using ApiRestaurante.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestaurante.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {

            CreateMap<CreateProdutoDTO, Produto>();
            CreateMap<Produto, ReadProdutoDTO>();
            CreateMap<UpDateProdutoDTO, Produto>();
        }
    }
}
