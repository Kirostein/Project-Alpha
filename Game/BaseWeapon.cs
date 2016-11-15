using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BaseWeapon : BaseStatItem
{ //BaseWeapon <- BaseStation <- BaseItem

    public enum WeaponTypes
    {
        SWORD,
        STAFF,
        DAGGER,
        BOW,
        SHIELD,
        POLEARM,
        KNUCKLE,
        ORB
    }
    private WeaponTypes weaponType;
    private int damage;
    public WeaponTypes WeaponType
    {
        get { return weaponType; }
        set { weaponType = value; }
    }
    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }
}