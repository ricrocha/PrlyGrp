using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PrlyGrp.CountryCatalog.WebMvcRzr.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("You requested the index page.");

            try
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i == 56)
                    {
                        throw new Exception("This is our demo exception");
                    }
                    else
                    {
                        _logger.LogInformation("The value of i is {LoopCountValue}", i);
                    }
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "We caught this exepction in the index get call");
                //throw ex;
            }
        }
    }
}
