﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularJSDemo.Controllers
{
    public class CountryController : ApiController
    {
        // GET api/country
        public IEnumerable<System.Web.Mvc.SelectListItem> Get()
        {
            List<System.Web.Mvc.SelectListItem> countries = new List<System.Web.Mvc.SelectListItem>
            {
                new System.Web.Mvc.SelectListItem { Text = "Brasil", Value="BR" },
            };

            return countries;
        }

        // GET api/country/5
        public IEnumerable<System.Web.Mvc.SelectListItem> Get(string id)
        {
            List<System.Web.Mvc.SelectListItem> states = new List<System.Web.Mvc.SelectListItem>();

            switch (id)
            {
                
                case "BR":
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "Pernambuco", Value = "PE" });
                    states.Add(new System.Web.Mvc.SelectListItem { Text = "São Paulo", Value = "SP" });
                    break;
                
            }

            return states;
        }
    }
}
