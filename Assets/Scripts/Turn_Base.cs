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
    public Button Button1;
    public Button Button2;
    public Button Button3;

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

    void PlayerTurn()
    {
        DialogueText.text = "Choose an action:";
        TurnCount.text = "CurrentTurn: " + TurnNumber;
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
            Button1.enabled = false;
            Button2.enabled = false;
            Button3.enabled = false;
        }
    }

    public void OnClickBotton()
    {
        TurnNumber += 1;
        TurnCount.text = "CurrentTurn: " + TurnNumber;
        PlayerAction();

    }
}
