using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PopUpSystemBuild : MonoBehaviour
{
  public Canvas canvas;
  public bool Activated = false;
  public Button BuildBotton;
  
  public void PopUp(){
    if (Activated == false){
      Activated = true;
      canvas.enabled = true;
    }
    else if(Activated == true){
      Activated = false;
      canvas.enabled = false;
      BuildBotton.enabled = false;

    }
}
}
