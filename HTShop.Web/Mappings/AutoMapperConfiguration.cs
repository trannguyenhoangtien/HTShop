using AutoMapper;
using HTShop.Model.Models;
using HTShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg => {
                //cfg.RecognizePrefixes("frm");
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                cfg.CreateMap<PostTag, PostTagViewModel>();
                cfg.CreateMap<Tag, TagViewModel>();

            });
            Mapper.AssertConfigurationIsValid();
        }
    }
}