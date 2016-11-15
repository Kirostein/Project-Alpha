using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BasePlayer
{
    private string playerName;
    private int playerLevel;
    private BaseCharacterClass playerClass;
    private int stamina;
    private int dexterity;
    private int strength;
    private int intellect;


    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }

    public int PlayerLevel
    {
        get { return playerLevel; }
        set { playerLevel = value; }
    }
    public BaseCharacterClass PlayerClass
    {
        get { return playerClass; }
        set { playerClass = value; }
    }
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