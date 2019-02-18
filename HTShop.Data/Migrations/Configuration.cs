﻿namespace HTShop.Data.Migrations
{
    using HTShop.Model.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HTShop.Data.HTShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HTShop.Data.HTShopDbContext context)
        {
            CreateProductCategorySample(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new HTShopDbContext()));
            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new HTShopDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "hoangtien",
            //    Email = "hoangtien103@gmail.com",
            //    EmailConfirmed = true,
            //    BirthDay = DateTime.Now,
            //    FullName = "Trần Nguyễn Hoàng Tiến"
            //};

            //manager.Create(user, "123654");

            //if (!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByEmail("hoangtien103@gmail.com");
            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }

        private void CreateProductCategorySample(HTShop.Data.HTShopDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listproductCategory = new List<ProductCategory>()
            {
                new ProductCategory(){Name = "Điện lạnh", Alias = "dien-lanh", Status= true},
                new ProductCategory(){Name = "Điện gia dụng", Alias = "dien-gia-dung", Status= true},
                new ProductCategory(){Name = "Mỹ phẩm", Alias = "my-pham", Status= true},
                new ProductCategory(){Name = "Điện thoại", Alias = "dien-thoai", Status= true},
                new ProductCategory(){Name = "Tủ lạnh", Alias = "tu-lanh", Status= true},
            };
                context.ProductCategories.AddRange(listproductCategory);
                context.SaveChanges();
            }
        }
    }
}
