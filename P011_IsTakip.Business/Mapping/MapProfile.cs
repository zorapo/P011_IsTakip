using AutoMapper;
using P011_IsTakip.Entities.Classes;
using P011_IsTakip.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Business.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Kullanici, LoginDto>().ReverseMap();
        }
      
    }
}
