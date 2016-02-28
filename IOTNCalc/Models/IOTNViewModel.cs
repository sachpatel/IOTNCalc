using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTNCalc.Models
{
    public enum IOTNResult
    {
        IOTN1, IOTN2, IOTN3, IOTN4, IOTN5
    }

    public class IOTNViewModel
    {
        public double OverJet { get; set; }
        public double ReverseOverJet { get; set; }
        public double CrossbiteDisplacement { get; set; }
        public double ContactPointDisplacement { get; set; }
        public double AnteriorOpenBite { get; set; }
        public int MissingTeeth { get; set; } // Per Quadrant

        public bool HasCleftLipPalate { get; set; }
        public bool HasIncompetantLips { get; set; }
        public bool HasSpeechAndMasticatoryDifficulty { get; set; }
        public bool HasSubmergedDeciduousTeeth { get; set; }


        public bool HasPosteriorLingualCrossbite { get; set; }

        public bool HasMinimalIrregularity { get; set; }
        //public bool HasTrauma { get; set; }
        public bool HasDeepOverBite { get; set; }
        public bool HasSupernumeries { get; set; }
        public bool HasImpedingEruption { get; set; }
        public bool HasImpactedOrEctopicTeeth { get; set; }
        public bool IsPartiallyEruptedAgainstOtherTeeth { get; set; }

        public bool IsCompleteToGingiva { get; set; }
        public bool HasOverbiteIncreased { get; set; }
        public bool HasTraumaToPalateOrGingiva { get; set; }

        public IOTNResult ResultIOTN { get; set; }
        public string ResultIOTNSpec { get; set; }
        
    }
}