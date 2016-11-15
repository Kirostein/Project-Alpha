using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CreateNewPotion : Monobehaviour
{
    private BasePotion newPotion;
    //string that several names for potions

    //Use this for initialization
    void Start()
    {
        CreatePotion();
        Debug.Log(newPotion.ItemName);
        Debug.Log(newPotion.ItemDescription);
        Debug.Log(newPotion.ItemID.ToString());
        Debug.Log(newPotion.PotionType.ToString());
    }

    private void CreatePotion()
    {
        newPotion = new BasePotion();
        newPotion.ItemName = "Potion";
        newPotion.ItemDescription = "This is a potion.";
        newPotion.ItemID = "Recovers: " + Random.Range(1, 200);
        ChoosePotionType();

    }

    private void ChoosePotionType()
    {
        int randomTemp = Random.Range(0, 7);
        Debug.Log(randomTemp);
        if(randomTemp == 0)
        {
            newPotion.PotionType = BasePotion.PotionTypes.HEALTH;
        }else if(randomTemp == 1)
        {
            newPotion.PotionType = BasePotion.PotionTypes.MANA;
        }else if (randomTemp == 2)
        {
            newPotion.PotionType = BasePotion.PotionTypes.STAMINA;
        }else if (randomTemp == 3)
        {
            newPotion.PotionType = BasePotion.PotionTypes.SPEED;
        }else if (randomTemp == 4)
        {
            newPotion.PotionType = BasePotion.PotionTypes.ATTACK;
        }else if (randomTemp == 5)
        {
            newPotion.PotionType = BasePotion.PotionTypes.DEFENCE;
        }else if (randomTemp == 6)
        {
            newPotion.PotionType = BasePotion.PotionTypes.TRANSFORMATION;
        }else if (randomTemp == 7)
        {
            newPotion.PotionType = BasePotion.PotionTypes.SPECIAL_RANDOM;
        }
    }
}
