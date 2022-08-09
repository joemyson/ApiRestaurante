
using ApiRestaurante.Data.DTOs.FuncionarioDTO;
using ApiRestaurante.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestaurante.Profiles
{
    public class FuncionarioProfile:Profile
    {
        public FuncionarioProfile()
        {
            CreateMap<CreateFuncionarioDTO, Funcionario>();
            CreateMap<Funcionario, ReadFuncionarioDTO>();
            CreateMap<UpDateFuncionarioDTO, Funcionario>();
        }
    }
}
