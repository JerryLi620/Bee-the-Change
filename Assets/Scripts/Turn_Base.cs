using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public enum TurnState {START, POLICY, BUILD, NEXT, WON, LOST}
public class Turn_Base: MonoBehaviour
{
    public TurnState state;
    public Text DialogueText;
    public Text TurnCount;
    public int TurnNumber = 1;
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public TMP_Text Policy1;
    public TMP_Text Policy2;
    public TMP_Text Accident;
    public TMP_Text News;

    public RandomEvent re;
    void Start()
    {

        re.SetUpEvents();
        state = TurnState.START;
        re.GenerateRandomEvent();
        SetupGame();

    }

    void SetupGame()
    {
        Button1.gameObject.SetActive(false);
        Button2.gameObject.SetActive(false);
        Button3.gameObject.SetActive(false);
        Button4.gameObject.SetActive(false);
        state = TurnState.POLICY;
        PlayerTurn();
    }
    public void Policy()
    {
        state = TurnState.BUILD;
        PlayerTurn();
    }

    public void Build()
    {
        state = TurnState.NEXT;
        PlayerTurn();
    }
    public void NextRound()
    {
        TurnNumber += 1;
        TurnCount.text = "Current Turn: " + TurnNumber;
        Button1.enabled = true;
        Button2.enabled = true;
        state = TurnState.POLICY;
        PlayerTurn();
        re.GenerateRandomEvent();
    }

    public void ResetScene()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void PlayerTurn()
    {
        TurnCount.text = "Current Turn: " + TurnNumber;
        if (state == TurnState.POLICY){
            DialogueText.text = "Something just happened!";
            Button1.gameObject.SetActive(true);
            Button2.gameObject.SetActive(false);
            Button3.gameObject.SetActive(false);
        }
        else if (state == TurnState.BUILD){
            DialogueText.text = "You probably want to build something!";
            Button1.gameObject.SetActive(false);
            Button2.gameObject.SetActive(true);
            Button3.gameObject.SetActive(false);
        }
        else if (state == TurnState.NEXT){
            DialogueText.text = "Click to start the next round.";
            Button1.gameObject.SetActive(false);
            Button2.gameObject.SetActive(false);
            Button3.gameObject.SetActive(true);
        }
        if (TurnNumber == 10 && Map_Behavior.popularity >= 55)
        {
            state = TurnState.WON;
            EndGame();
        }
        else if (TurnNumber == 10 && Map_Behavior.popularity < 55)
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
            Button1.gameObject.SetActive(false);
            Button2.gameObject.SetActive(false);
            Button3.gameObject.SetActive(false);
            Button4.gameObject.SetActive(true);
        }
        else if (state == TurnState.LOST)
        {
          DialogueText.text = "You lost.";
          Button1.gameObject.SetActive(false);
          Button2.gameObject.SetActive(false);
          Button3.gameObject.SetActive(false);
          Button4.gameObject.SetActive(true);
        }
    }


}
