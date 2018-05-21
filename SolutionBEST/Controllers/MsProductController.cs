﻿using MicroServiceNet;
using Service;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Web.Mvc;

namespace SolutionBEST.Controllers
{
    public class MsProductController : Controller
    {
        IMsProductControllerService _productService;

        public ActionResult GetAll()
        {
            var requestParams = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username", "Elena"),
                new KeyValuePair<string, string>("password", "mest")
            };


            var request = MicroServiceNet.MicroServiceNet.Execute(_productService.GetAll, requestParams);
            var r = request.Result;

            return View();
        }
    }
}