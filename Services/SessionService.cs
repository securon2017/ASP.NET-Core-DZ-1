using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZ_1.Services
{
    public class SessionService 
    {
        public Dictionary<string, int> Counters { get; set; } = new Dictionary<string, int>(3);
        private readonly IHttpContextAccessor _httpContextAccessor;
        public SessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public void CounterReset()
        {
            if (Counters.Count == 0)
            {
                Counters.Clear();
                Counters.Add("", 0);
                Counters.Add("About", 0);
                Counters.Add("Contacts", 0);
            }
        }
        public void Counter()
        {
            string query = _httpContextAccessor.HttpContext.Request.Path;
            string[] words = query.Split('/');
            var length = words.Length;
            string pattern = words[length-1];
            if (Counters.ContainsKey(pattern))
            {
                Counters[pattern]++;
            }
        }
    }
}
