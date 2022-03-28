using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum TurnState {START, PLAYERTURN, WON, LOST}
public class Turn_Base: MonoBehaviour
{
    public TurnState state;
    public Text DialogueText;
    public Text TurnCount;
    public int TurnNumber = 0;
    void Start()
    {
        state = TurnState.START;
        SetupGame();
    }

    void SetupGame()
    {
        Debug.Log("start");
        state = TurnState.PLAYERTURN;
        PlayerTurn();
    }

    void PlayerAction()
    {
        DialogueText.text = "This is an action.";
        if (TurnNumber == 5)
        {
            state = TurnState.WON;
            EndGame();
        }
    }

    void EndGame()
    {
        if (state == TurnState.WON)
        {
            DialogueText.text = "You won!";
        }
    }
    void PlayerTurn()
    {
        DialogueText.text = "Choose an action:";
        TurnCount.text = "CurrentTurn: " + TurnNumber;
    }

    public void OnClickBotton()
    {
        TurnNumber += 1;
        TurnCount.text = "CurrentTurn: " + TurnNumber;
        PlayerAction();

    }
}
