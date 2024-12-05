using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEOHealthCheckAPI.Models
{
    public class SeoReport
    {
    public int Id { get; set; }
    public string Url { get; set; }
    public double PageSpeed { get; set; }
    public int MetaTagIssues { get; set; }
    public int BrokenLinks { get; set; }
    public string Recommendations { get; set; }
    }
}