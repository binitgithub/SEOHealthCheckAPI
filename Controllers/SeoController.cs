using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SEOHealthCheckAPI.Data;
using SEOHealthCheckAPI.Models;

namespace SEOHealthCheckAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeoController : ControllerBase
    {
        private readonly SeoDbContext _context;

        public SeoController(SeoDbContext context)
        {
            _context = context;
        }

    //Analyze Website Report
    [HttpPost("analyze")]
    public async Task<IActionResult>AnalyzeUrl([FromBody] string url)
    {
        // Simulated analysis (add real logic with SEO tools)
        var report = new SeoReport
        {
            Url = url,
            PageSpeed = new Random().Next(50, 100),
            MetaTagIssues = new Random().Next(0, 10),
            BrokenLinks = new Random().Next(0, 5),
            Recommendations = "Fix meta tags and increase page speed."
        };

         _context.SeoReports.Add(report);
        await _context.SaveChangesAsync();
        return Ok(report);

    }

    [HttpGet]
    public async Task<IActionResult> GetReports() => Ok(await _context.SeoReports.ToListAsync());
    }
}