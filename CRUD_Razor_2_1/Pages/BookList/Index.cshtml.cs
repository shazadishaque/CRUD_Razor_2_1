﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_Razor_2_1.Pages.BookList
{
    public class IndexModel : PageModel
    {
        public string someData { get; set; }

        public void OnGet()
        {
            someData = "This is my first Property!";
        }
    }
}