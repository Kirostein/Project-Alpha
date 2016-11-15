using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CreateNewWeapon : MonoBehaviour
{
    private BaseWeapon newWeapon;
    //to provide each weapon with a unique name use the code below
    //private string[] weaponNames = new string[#] ("Name");
    void Start()
    {
        CreateWeapon();
        Debug.Log(newWeapon.ItemName);
        Debug.Log(newWeapon.ItemDescription);
        Debug.Log(newWeapon.ItemID.ToString());
        Debug.Log(newWeapon.WeaponType.ToString());
        Debug.Log(newWeapon.Stamina.ToString());
        Debug.Log(newWeapon.Dexterity.ToString());
        Debug.Log(newWeapon.Strength.ToString());
        Debug.Log(newWeapon.Intellect.ToString());
    }
    public void CreateWeapon()
    {

        newWeapon = new BaseWeapon();

        //assign name
        newWeapon.ItemName = "W" + Random.Range(1, 200); //Randomize name
        //create description
        newWeapon.ItemDescription = "This is a weapon.";
        //weapon id
        newWeapon.ItemID = Random.Range(1, 200);
        //stats
        newWeapon.Stamina = Random.Range(1, 15);
        newWeapon.Endurance = Random.Range(1, 15);
        newWeapon.Strength = Random.Range(1, 15);
        newWeapon.Intellect = Random.Range(1, 15);
        //choose type
        ChooseWeaponType();
        //spell effect id
        newWeapon.SpellEffectID = Random.Range(1, 300);
    }

    private void ChooseWeaponType()
    {
        int randomTemp = Random.Range(1, 8);
        if(randomTemp = 1)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
        }else if (randomTemp == 2)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
        }
        else if (randomTemp == 3)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
        }
        else if (randomTemp == 4)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
        }
        else if (randomTemp == 5)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD;
        }
        else if (randomTemp == 6)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.POLEARM;
        }
        else if (randomTemp == 7)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.KNUCKLE;
        }
        else if (randomTemp == 8)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.ORB;
        }
    }
}