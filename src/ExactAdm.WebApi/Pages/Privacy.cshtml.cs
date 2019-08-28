using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExactAdm.WebApi.Pages
{
    [ClaimsAuthorize("Setor", "Setor_Teste")]
    public class PrivacyModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}