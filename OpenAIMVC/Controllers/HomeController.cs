using Microsoft.AspNetCore.Mvc;
using OpenAIMVC.Models;
using System.Diagnostics;

namespace OpenAIMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            List<HyperParams> MyList = new List<HyperParams>();
            MyList.Add(new HyperParams { Epochs = 4, Learning_rate_multiplier = 0.01, Batch_size = 32, PromptLossWeight = 0 });
            MyList.Add(new HyperParams { Epochs = 5, Learning_rate_multiplier = 0.21, Batch_size = 16, PromptLossWeight = 2 });
            MyList.Add(new HyperParams { Epochs = 7, Learning_rate_multiplier = 0.41, Batch_size = 4, PromptLossWeight = 100 });

            //ViewBag.HyperParams = MyList;

            List<FineTuneJob> fineTuneJobs= new List<FineTuneJob>
            {
                new FineTuneJob
                {
                    Id = "ft-j_123456",
                    Fine_tuned_model = "exampleModel",
                    Created_at = 1648584000,
                    HyperParams = MyList,
                    Status = "Success",
                    Updated_at = 1648670400,
                    NumberResultFiles = 1,
                    NumberTrainingFiles = 2,
                    NumberValidationFiles = 4
                }
            };

        
            ViewBag.FineTuneJobs = fineTuneJobs;

            return View("Form");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}