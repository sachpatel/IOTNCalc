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
            vm.ResultIOTNSpec = "Not Available";

            #region IOTN1 Checks
            if (vm.HasMinimalIrregularity)
            {
                vm.ResultIOTNSpec = "IOTN1";
            }

            if (vm.ContactPointDisplacement > 0 && vm.ContactPointDisplacement <= 1)
            {
                vm.ResultIOTNSpec = "IOTN1";
            }

            #endregion
            #region IOTN2 Checks            
            if (vm.OverJet > 3.5 && vm.OverJet <= 6)
            {
                vm.ResultIOTNSpec = "IOTN2a";
            }

            if (vm.ContactPointDisplacement > 1 && vm.ContactPointDisplacement <= 2)
            {
                vm.ResultIOTNSpec = "IOTN2d";
            }

            if (vm.HasOverbiteIncreased)
            {
                vm.ResultIOTNSpec = "IOTN2f";
            }
            #endregion
            #region IOTN3 Checks
            //if ((vm.HasDeepOverBite && vm.HasTrauma == false) || vm.AnteriorOpenBite > 0 && vm.AnteriorOpenBite < 4)
            //{
            //    vm.ResultIOTN = IOTNResult.IOTN3;
            //}

            if (vm.OverJet > 3.5 && vm.OverJet <= 6 && vm.HasIncompetantLips)
            {
                vm.ResultIOTNSpec = "IOTN3a";
            }

            if ((vm.ReverseOverJet < 0 && vm.ReverseOverJet > -3.5))
            {
                vm.ResultIOTNSpec = "IOTN3b";
            }

            if (vm.CrossbiteDisplacement > 1 && vm.CrossbiteDisplacement <= 2)
            {
                vm.ResultIOTNSpec = "IOTN3c";
            }

            if (vm.ContactPointDisplacement > 2 && vm.ContactPointDisplacement <= 4)
            {
                vm.ResultIOTNSpec = "IOTN3d";
            }

            if (vm.AnteriorOpenBite > 2 && vm.AnteriorOpenBite <= 4)
            {
                vm.ResultIOTNSpec = "IOTN3e";
            }            

            if (vm.HasOverbiteIncreased && vm.IsCompleteToGingiva)
            {
                vm.ResultIOTNSpec = "IOTN3f";
            }
            #endregion
            #region IOTN4 Checks
            //if ((vm.HasDeepOverBite && vm.HasTrauma))
            //{
            //    vm.ResultIOTN = IOTNResult.IOTN4;
            //}

            //if (vm.ContactPointDisplacement > 4)
            //{
            //    vm.ResultIOTN = IOTNResult.IOTN4;
            //}

            if (vm.OverJet > 6 && vm.OverJet < 9)
            {
                vm.ResultIOTNSpec = "IOTN4a";
            }

            if ((vm.ReverseOverJet < 0 && vm.ReverseOverJet <= -3.5))
            {
                vm.ResultIOTNSpec = "IOTN4b";
            }

            if (vm.CrossbiteDisplacement > 2)
            {
                vm.ResultIOTNSpec = "IOTN4c";
            }            

            if (vm.ContactPointDisplacement > 4)
            {
                vm.ResultIOTNSpec = "IOTN4d";
            }

            if(vm.AnteriorOpenBite > 4)
            {
                vm.ResultIOTNSpec = "IOTN4e";
            }

            if (vm.HasOverbiteIncreased && vm.IsCompleteToGingiva && vm.HasTraumaToPalateOrGingiva)
            {
                vm.ResultIOTNSpec = "IOTN4f";
            }

            if (vm.MissingTeeth > 0 && vm.MissingTeeth < 2)
            {
                vm.ResultIOTNSpec = "IOTN4h";
            }

            if (vm.HasPosteriorLingualCrossbite)
            {
                vm.ResultIOTNSpec = "IOTN4l";
            }

            if ((vm.ReverseOverJet < 0 && vm.ReverseOverJet > -3.5) && vm.HasSpeechAndMasticatoryDifficulty)
            {
                vm.ResultIOTNSpec = "IOTN4m";
            }

            if (vm.IsPartiallyEruptedAgainstOtherTeeth)
            {
                vm.ResultIOTNSpec = "IOTN4t";
            }

            if (vm.HasSupernumeries)
            {
                vm.ResultIOTNSpec = "IOTN4x";
            }
            #endregion
            #region IOTN5 Checks
            if (vm.OverJet >= 9)
            {
                vm.ResultIOTNSpec = "IOTN5a";
            }

            if (vm.MissingTeeth > 1)
            {
                vm.ResultIOTNSpec = "IOTN5h";
            }

            if (vm.HasSupernumeries && vm.HasImpedingEruption)
            {
                vm.ResultIOTNSpec = "IOTN5i";
            }

            if (vm.HasImpactedOrEctopicTeeth)
            {
                vm.ResultIOTNSpec = "IOTN5i";
            }
            
            if ((vm.ReverseOverJet < 0 && vm.ReverseOverJet < -3.5) && vm.HasSpeechAndMasticatoryDifficulty)
            {
                vm.ResultIOTNSpec = "IOTN5m";
            }

            if (vm.HasCleftLipPalate)
            {
                vm.ResultIOTNSpec = "IOTN5p";
            }

            if (vm.HasSubmergedDeciduousTeeth)
            {
                vm.ResultIOTNSpec = "IOTN5s";
            }
            
            #endregion
            
            return View(vm);
        }
    }
}