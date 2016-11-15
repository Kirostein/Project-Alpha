using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BaseStatItem : BaseItem
{
    private int stamina;
    private int dexterity;
    private int strength;
    private int intellect;

    public int Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }
    public int Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }
    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }
    public int Intellect
    {
        get { return intellect; }
        set { intellect = value; }
    }
}