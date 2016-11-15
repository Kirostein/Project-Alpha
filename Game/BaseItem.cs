using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BaseItem
{
    private string itemName;
    private string itemDescription;
    private int itemID;
    public enum ItemTypes
    {
        EQUIPMENT,
        WEAPON,
        SCROLL,
        POTION,
        INGREDIENT,
        QUEST_STARTER,
        MONSTER_DROP,
        COSTUME,
    }
    private ItemTypes itemType;

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }
    public string ItemDescription
    {
        get { return itemDescription; }
        set { itemDescription = value; }
    }
    public int ItemID
    {
        get { return itemID; }
        set { itemID = value; }
    }
    public ItemTypes Itemtype
    {
        get { return itemType; }
        set { itemType = value; }
    }

}
