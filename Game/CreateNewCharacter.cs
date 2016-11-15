using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CreateNewCharacter : MonoBehaviour
{
    private BasePlayer newPlayer;
    private bool isMageClass;
    private bool isNomadClass;
    private bool isWarriorClass;
    private bool isKnightClass;
    private bool isArcherClass;
    private bool isRangerClass;
    private string playerName = "Enter_Name";


    //use for initialization 
    void Start()
    {
        newPlayer = new BasePlayer();
    }
    //update once per frame
    void Update()
    {

    }


    void OnGUI()
    {
        playerName = GUILayout.TextArea(playerName, 16);
        isMageClass = GUILayout.Toggle(isMageClass, "Mage Class");
        isNomadClass = GUILayout.Toggle(isNomadClass, "Nomad Class");
        isWarriorClass = GUILayout.Toggle(isWarriorClass, "Warrior Class");
        isKnightClass = GUILayout.Toggle(isKnightClass, "Knight Class");
        isArcherClass = GUILayout.Toggle(isArcherClass, "Archer Class");
        isRangerClass = GUILayout.Toggle(isRangerClass, "Ranger Class");
        if (GUILayout.Button("Create"))
        {
            if (isMageClass)
            {
                newPlayer.PlayerClass = new BaseMageClass();
            }
            else if (isNomadClass)
            {
                newPlayer.PlayerClass = new BaseNomadClass();
            }
            else if (isWarriorClass)
            {
                newPlayer.PlayerClass = new BaseWarriorClass();
            }
            else if (isKnightClass)
            {
                newPlayer.PlayerClass = new BaseKnightClass();
            }
            else if (isArcherClass)
            {
                newPlayer.PlayerClass = new BaseArcherClass();
            }
            else if (isRangerClass)
            {
                newPlayer.PlayerClass = new BaseRangerClass();
            }
            newPlayer.PlayerLevel = 1;
            newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
            newPlayer.Dexterity = newPlayer.PlayerClass.Dexterity;
            newPlayer.Strength = newPlayer.PlayerClass.Strength;
            newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
            newPlayer.PlayerName = playerName;
            Debug.Log("Player Name: " + newPlayer.PlayerName);
            Debug.Log("Player Class: " + newPlayer.PlayerClass.CHaracterClassName);
            Debug.Log("Player Level: " + newPlayer.PlayerClass.PlayerLevel);
            Debug.Log("Player Stamina: " + newPlayer.PlayerClass.Stamina);
            Debug.Log("Player Dexterity: " + newPlayer.PlayerClass.Dexterity);
            Debug.Log("Player Strength: " + newPlayer.PlayerClass.Strength);
            Debug.Log("Player Intellect: " + newPlayer.PlayerClass.Intellect);
        }
    }
}