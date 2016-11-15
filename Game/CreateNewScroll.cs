using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CreateNewScroll : MonoBehaviour
{
    private BaseScroll newScroll;

    //Use this for initialization
    void Start ()
    {
        CreateScroll();
        Debug.Log(newScroll.ItemName);
        Debug.Log(newScroll.ItemDescription);
        Debug.Log(newScroll.ItemID.ToString);
        Debug.Log(newScroll.SpellEffectID.ToString);
    }

    private void CreateScroll()
    {
        newScroll = new BaseScroll();
        newScroll.ItemName = "Scroll";
        newScroll.ItemDescription = "This is a scroll.";
        newScroll.ItemID = Random.Range(1, 200);
        newScroll.SpellEffectID = "Damage: " + Random.Range(500, 1000);
    }
}