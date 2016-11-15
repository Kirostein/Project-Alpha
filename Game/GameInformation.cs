using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GameInformation : MonoBehaviour
{
    void Awake()
    {
        DontDestoryOnLoad(transform.gameObject);
    }

    public static string PlayerName { get; set; }
    public static int PlayerLevel { get; set; }
    public static BaseCharacterClass PlayerClass { get; set; }
    public static int Stamina { get; set; }
    public static int Dexterity { get; set; }
    public static int Strength { get; set; }
    public static int Intellect { get; set; }
}

