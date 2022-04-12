using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpSystemPolicy: MonoBehaviour
{
  public Canvas canvas;
  public bool Activated = false;
  public Button PolicyBotton;

  public void PopUp(){
    if (Activated == false){
      Activated = true;
      canvas.enabled = true;
    }
    else if(Activated == true){
      Activated = false;
      canvas.enabled = false;
      PolicyBotton.enabled = false;
    }
  }
}
