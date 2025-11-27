using Ems.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Ems.UI.Controllers
{
    public class ReportController : Controller
    {
        private readonly IReportRepository _reportRepository;

        public ReportController(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }
        public async Task<IActionResult>EmsReports()
        {
            var report=await _reportRepository.GetReportAsync();
            return View(report);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
