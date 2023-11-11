using System.Collections.Generic;
using UnityEngine;
using FuzzPhyte.Utility;
using FuzzPhyte.Utility.EDU;
namespace FuzzPhyte.Standards.VA.CS
{
    [CreateAssetMenu(fileName = "Strand", menuName = "FuzzPhyte/Standards/VAStandard", order = 10)]
    public class FP_Strand : FP_EDU_Data
    {
        
        public string StrandName;
        [TextArea(3, 10)]
        public string StrandDescription;
        public StrandType Strand;
        public FP_Theme StrandTheme;
        [Tooltip("Exact Scene Name we are using this")]
        public string GameSceneName;        
        [Tooltip("List of Standards for this strand in this scene")]
        public List<FP_Standard> Standards;
    }
}
