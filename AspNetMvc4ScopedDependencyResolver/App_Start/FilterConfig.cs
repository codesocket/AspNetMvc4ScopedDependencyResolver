﻿using System.Web;
using System.Web.Mvc;

namespace AspNetMvc4ScopedDependencyResolver
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
