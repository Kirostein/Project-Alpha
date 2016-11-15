using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CreateNewEquipment : MonoBehaviour
{
    private BaseEquipment newEquipment;
    private string[] itemNames = new string[7]("Common", "Greater", "Holy", "Dark", "Epic", "King", "God");
    private string[] itemDes = new string[2]("This is a crafted item.", "This is a dropped item.");

    // Use this for initialization
    void Start()
    {
        Debug.Log(newEquipment.ItemName);
        Debug.Log(newEquipment.ItemDescription);
        Debug.Log(newEquipment.ItemID.ToString);
        Debug.Log(newEquipment.EquipmentType.ToString);
        Debug.Log(newEquipment.Stamina.ToString);
        Debug.Log(newEquipment.Dexterity.ToString);
        Debug.Log(newEquipment.Strength.ToString);
        Debug.Log(newEquipment.Intellect.ToString);
    }

    private void CreateEquipment()
    {
        newEquipment = new BaseEquipment();
        newEquipment.ItemName = itemNames[Random.Range(0, 6)] + " item";
        newEquipment.ItemID = Random.Range(1, 1000);
        ChooseItemType();
        newEquipment.ItemDescription = itemDes(Random.Range(0, item.Length));
        newEquipment.Stamina = Random.Range(1, 15);
        newEquipment.Dexterity = Random.Range(1, 15);
        newEquipment.Strength = Random.Range(1, 15);
        newEquipment.Intellect = Random.Range(1, 15);
    }

    private void ChooseItemType()
    {
        int randomTemp = Random.Range(1, 10);
        if(randomTemp == 1)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HELMET;
        }else if (randomTemp == 2)
        {
            newEquipment.EquipmentTypes = BaseEquipment.EquipmentTypes.CHEST;
        }
        else if (randomTemp == 3)
        {
            newEquipment.EquipmentTypes = BaseEquipment.EquipmentTypes.SHOULDER;
        }
        else if (randomTemp == 4)
        {
            newEquipment.EquipmentTypes = BaseEquipment.EquipmentTypes.GAUNTLET;
        }
        else if (randomTemp == 5)
        {
            newEquipment.EquipmentTypes = BaseEquipment.EquipmentTypes.BRACELET;
        }
        else if (randomTemp == 6)
        {
            newEquipment.EquipmentTypes = BaseEquipment.EquipmentTypes.BRACELET;
        }
        else if (randomTemp == 7)
        {
            newEquipment.EquipmentTypes = BaseEquipment.EquipmentTypes.RING;
        }
        else if (randomTemp == 8)
        {
            newEquipment.EquipmentTypes = BaseEquipment.EquipmentTypes.LEGGING;
        }
        else if (randomTemp == 9)
        {
            newEquipment.EquipmentTypes = BaseEquipment.EquipmentTypes.FOOT;
        }
        else if (randomTemp == 10)
        {
            newEquipment.EquipmentTypes = BaseEquipment.EquipmentTypes.CAPE;
        }
    }

    //Update is called once per frame
    void Update (){

    }
}
