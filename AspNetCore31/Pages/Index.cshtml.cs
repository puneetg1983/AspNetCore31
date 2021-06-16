using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore31.Pages
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
            var list = new List<string>();
            foreach (DictionaryEntry env in System.Environment.GetEnvironmentVariables())
            {
                list.Add($"{env.Key}={env.Value}");
            }

            ViewData["EnvVars"] = list.OrderBy(x => x).ToList();
        }
    }
}
