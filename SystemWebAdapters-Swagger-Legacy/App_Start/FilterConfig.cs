﻿using System.Web;
using System.Web.Mvc;

namespace SystemWebAdapters_Swagger_Legacy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
