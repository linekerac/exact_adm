using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExactAdm.WebApi.Pages
{
    [Authorize(Roles = "PreVendedor")]
    public class PvModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}