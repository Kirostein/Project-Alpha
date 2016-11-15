using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BaseEquipment : BaseStatItem
{
    public enum EquipmentTypes
    {
        HELMET,
        CHEST,
        SHOULDER,
        GAUNTLET,
        BRACELET,
        RING,
        LEGGING,
        FOOT,
        CAPE
    }

    private EquipmentTypes equipmentType;
    private int spellEffectID;
    public EquipmentTypes EquipmentType
    {
        get { return equipmentType; }
        set { equipmentType = value; }
    }
    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
