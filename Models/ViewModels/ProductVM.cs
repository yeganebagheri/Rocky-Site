using Microsoft.AspNetCore.Mvc.Rendering;
using Rocky2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky2.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }

        public IEnumerable<SelectListItem> CategorySelectList { get; set; }

        public IEnumerable<SelectListItem> ApplicationTypeSelectList { get; set; }
    }
}
