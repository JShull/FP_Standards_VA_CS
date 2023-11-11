using System.Collections.Generic;
using UnityEngine;
using FuzzPhyte.Utility.Meta;
using FuzzPhyte.Utility;

namespace FuzzPhyte.Standards.VA.CS
{
    [CreateAssetMenu(fileName = "Card", menuName = "FuzzPhyte/Standards/VAStandard", order = 0)]
    public class FP_CoderCards : FP_Card
    {
        public string NameOfCard;
        public int CardNumber;
        public GameObject CardPrefabRef;
        [TextArea(2, 4)]
        public string BriefDescription;
        [TextArea(4, 10)]
        public string Description;
        [TextArea(4, 10)]
        public string BackCardDescription;
        public Sprite CardIcon;
        public Texture FrontCard;
        public Texture BackCard;
        public FP_Theme CardTheme;
        [Space]
        
        public FP_GameMechanic CardGameMechanics;
        public List<FP_Tag> AssociatedTags;
        public List<FP_Strand> AttachedStrand;
    }
}
