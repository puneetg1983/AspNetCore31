using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCore31.Pages
{
    public class ProfilingVarsModel : PageModel
    {
        public void OnGet()
        {
            var list = new List<string>();
            foreach (DictionaryEntry env in System.Environment.GetEnvironmentVariables())
            {
                if (env.Key.ToString().Contains("profile", StringComparison.OrdinalIgnoreCase))
                    list.Add($"{env.Key}={env.Value}");
            }

            ViewData["EnvVars"] = list.OrderBy(x => x).ToList();
        }
    }
}
