using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Automapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMapping()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ViewModelToDomainProfile());
                cfg.AddProfile(new DomainToViewModelProfile());
            });
        }
    }
}
