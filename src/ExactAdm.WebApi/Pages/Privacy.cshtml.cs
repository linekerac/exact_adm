using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExactAdm.WebApi.Pages
{
    [ClaimsAuthorize("Setor", "PV")]
    public class PrivacyModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}