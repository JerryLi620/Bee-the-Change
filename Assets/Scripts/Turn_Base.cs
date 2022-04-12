using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
    public TMP_Text Policy1;
    public TMP_Text Policy2;
    public TMP_Text Accident;
    public TMP_Text News;

    void Start()
    {
        state = TurnState.START;
        Policy1.text = "Wait it out and hope it passes quickly";
        Policy2.text = "Prepare flood materials for 1 honeycomb";
        Accident.text = "A rainstorm is expected to last for an unknown number of days, flooding the western side of the honeycomb.";
        News.text = "A rainstorm is expected to last for an unknown number of days, flooding the western side of the honeycomb.";
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
        if (TurnNumber == 5 && Map_Behavior.popularity >= 55)
        {
            state = TurnState.WON;
            EndGame();
        }
        else if (TurnNumber == 5 && Map_Behavior.popularity < 55)
        {
            state = TurnState.LOST;
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
        else if (state == TurnState.LOST)
        {
          DialogueText.text = "You lost";
          Button1.enabled = false;
          Button2.enabled = false;
          Button3.enabled = false;
        }
    }

    public void NextRound()
    {
        TurnNumber += 1;
        TurnCount.text = "CurrentTurn: " + TurnNumber;

        Map_Behavior.honeyProduction += Random.Range(-5, 5);
        Map_Behavior.beeRights += Random.Range(-5, 5);
        Map_Behavior.flowerDensity += Random.Range(-5, 5);
        Map_Behavior.lifeExpectancy += Random.Range(-5, 5);
        Map_Behavior.happiness += Random.Range(-5, 5);
        Button1.enabled = true;
        Button2.enabled = true;
        PlayerAction();

    }
}
