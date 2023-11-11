using System;
using System.Collections.Generic;
using UnityEngine;
using FuzzPhyte.Utility.EDU;

namespace FuzzPhyte.Standards.VA.CS
{
    //notes https://www.doe.virginia.gov/home/showpublisheddocument/9950/638026398210130000
    [Serializable]
    [CreateAssetMenu(fileName = "Standard", menuName = "FuzzPhyte/Standards/VAStandard", order = 2)]
    public class FP_Standard : FP_EDU_Data
    {
        public FP_Grade VAStandardGrade;
        public string VAStandardName;
        public string VAStandardIndex;
        public int StatePDFPageRef;
        public List<FP_Objective> Objectives;
    }
}
