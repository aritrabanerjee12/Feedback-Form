using Microsoft.AspNetCore.Mvc;

namespace ASPCoreWebAppWithAPI.Controllers
{
    public class FeedbackController : Controller
    {
        CustomerDB customerDB;



        public FeedbackController(CustomerDB custDb)
        {
           this.customerDB = custDb;    
        }
        public IActionResult Index()
        {
            var allFeedbacks = this.customerDB.Feedbacks;
            return View(allFeedbacks);
        }

        public IActionResult Submit()
        {
            return View();
        }


    }
}
