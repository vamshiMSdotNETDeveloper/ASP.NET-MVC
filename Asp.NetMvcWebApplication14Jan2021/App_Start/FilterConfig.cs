﻿using System.Web;
using System.Web.Mvc;

namespace Asp.NetMvcWebApplication14Jan2021
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
