using IOTNCalc.Models;
using System.Web.Mvc;

namespace IOTNCalc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new IOTNViewModel());
        }

        [HttpPost]
        public ActionResult Result(IOTNViewModel vm)
        {
            #region IOTN1 Checks
            if (vm.HasMinimalIrregularity)
            {
                vm.ResultIOTN = IOTNResult.IOTN1;
            } 
            #endregion
            #region IOTN2 Checks
            if (vm.OverJet > 2 || (vm.ContactPointDisplacement > 0 && vm.ContactPointDisplacement < 2))
            {
                vm.ResultIOTN = IOTNResult.IOTN2;
            }
            #endregion
            #region IOTN3 Checks
            if ((vm.HasDeepOverBite && vm.HasTrauma == false) || vm.AnteriorOpenBite > 0 && vm.AnteriorOpenBite < 4)
            {
                vm.ResultIOTN = IOTNResult.IOTN3;
            }

            if (vm.ContactPointDisplacement > 0 && vm.ContactPointDisplacement < 4)
            {
                vm.ResultIOTN = IOTNResult.IOTN3;
            }
            
            if (vm.CrossbiteDisplacement > 1)
            {
                vm.ResultIOTN = IOTNResult.IOTN3;
            }

            if (vm.OverJet > 4 || (vm.ReverseOverJet < 0 && vm.ReverseOverJet > -2))
            {
                vm.ResultIOTN = IOTNResult.IOTN3;
            }
            #endregion
            #region IOTN4 Checks
            if ((vm.HasDeepOverBite && vm.HasTrauma) || vm.AnteriorOpenBite > 4)
            {
                vm.ResultIOTN = IOTNResult.IOTN4;
            }

            if (vm.ContactPointDisplacement > 4)
            {
                vm.ResultIOTN = IOTNResult.IOTN4;
            }

            if (vm.CrossbiteDisplacement > 2)
            {
                vm.ResultIOTN = IOTNResult.IOTN4;
            }

            if (vm.OverJet > 6 || (vm.ReverseOverJet <= -2 && vm.ReverseOverJet > -3.5))
            {
                vm.ResultIOTN = IOTNResult.IOTN4;
            }

            if (vm.HasSupernumeries && vm.MissingTeeth < 4)
            {
                vm.ResultIOTN = IOTNResult.IOTN4;
            }
            #endregion
            #region IOTN5 Checks
            if (vm.HasCleftLipPalate || vm.HasImpactedOrEctopicTeeth || vm.MissingTeeth > 4)
            {
                vm.ResultIOTN = IOTNResult.IOTN5;
            }

            if (vm.OverJet > 9 || (vm.ReverseOverJet < 0 && vm.ReverseOverJet < -3.5))
            {
                vm.ResultIOTN = IOTNResult.IOTN5;
            }
            #endregion
            
            return View(vm);
        }
    }
}