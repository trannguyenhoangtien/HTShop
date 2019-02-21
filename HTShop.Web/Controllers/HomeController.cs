﻿using AutoMapper;
using HTShop.Model.Models;
using HTShop.Service;
using HTShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTShop.Web.Controllers
{
    public class HomeController : Controller
    {
        IProductCategoryService _productCategoryService;

        public HomeController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult Footer()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult Header()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult LeftMenu()
        {
            var model = _productCategoryService.GetAll();
            var listProductCategoryViewModel = Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(model);
            return PartialView(listProductCategoryViewModel);
        }
    }
}