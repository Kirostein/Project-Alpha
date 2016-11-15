using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BaseScroll : BaseStatItem
{
    public enum ScrollTypes
    {
        FIRE_ELEMENT,
        FROST_ELEMENT,
        EARTH_ELEMENT,
        WATER_ELEMENT,
        WIND_ELEMENT,
        HOLY_ELEMENT,
        DARK_ELEMENT,
        FORBIDDEN,
        ANCIENT,
        SEALED,
        SUMMONING
    }
    private ScrollTypes scrollType;
    public int spellEffectID;

    public ScrollTypes ScrollType
    {
        get { return scrollType; }
        set { scrollType = value; }
    }
    public int SpellEffectID
    {
        get { return SpellEffectID; }
        set { spellEffectID = value; }
    }
}
