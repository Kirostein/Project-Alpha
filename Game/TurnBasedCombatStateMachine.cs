using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TurnBasedCombatStateMachine  : MonoBehaviour
{
    public enum BatteStates
    {
        START,
        PLAYERCHOICE,
        ENEMYCHOICE,
        LOSE,
        WIN
    }

    private BattleStates currentState;

    // Use this for initialization
    void Start()
    {
        currentState = BattleStates.START;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentState);
        switch (currentState)
        {
            case (BatteStates.START);
               //SETUP BATTLE FUNCTION
                break;
            case (BatteStates.PLAYERCHOICE);
                break;
            case (BatteStates.ENEMYCHOICE);
                break;
            case (BatteStates.LOSE);
                break;
            case (BatteStates.WIN);
                break;
        }
    }

    void OnGUI()
    {
        if (GUILayout.Button("NEXT STATE"))
        {
            if (currentState == BatteStates.START)
            {
                currentState = BatteStates.PLAYERCHOICE;
            }
            else if (currentState == BatteStates.PLAYERCHOICE)
            {
                currentState = BatteStates.ENEMYCHOICE;
            }
            else if (currentState == BatteStates.ENEMYCHOICE)
            {
                currentState = BatteStates.LOSE;
            }
            else if (currentState == BatteStates.LOSE)
            {
                currentState = BatteStates.WIN;
            }
            else if (currentState == BatteStates.WIN)
            {
                currentState = BatteStates.START;
            }
        }
    }
}