using InstaWeb.Application.Drivers;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InstaWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IDriversService driversService;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(IDriversService driversService, ILogger<IndexModel> logger)
        {
            this.driversService = driversService;
            _logger = logger;
        }

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostCreateDriver()
        {
            await driversService.CreateDriver("Zbyszek", "Zbyszowski");
            return RedirectToPage("./Index");
        }
        
    }
}
