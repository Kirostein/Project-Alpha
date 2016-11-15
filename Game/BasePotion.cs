using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BasePotion : BaseStatItem
{
    public enum PotionType
    {
        HEALTH,
        MANA,
        STAMINA,
        SPEED,
        ATTACK,
        DEFENCE,
        TRANFORMATION,
        SPECIAL_RANDOM
    }

    private PotionTypes potionType;
    private int spellEffectID; 

    public PotionTypes PotionType
    {
        get { return potionType; }
        set { potionType = value; }
    }
    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
