using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExactAdm.WebApi.Pages
{
    [Authorize(Roles = "Gerente")]
    public class GerenteModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}