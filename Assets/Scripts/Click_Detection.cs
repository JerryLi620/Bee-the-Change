using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Detection : MonoBehaviour
{
  public bool zoomedIn;

  void Start(){
    zoomedIn = false;
  }

  void Update(){
    if (Input.GetMouseButtonDown (0)) {
      if(zoomedIn==false){
             var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             RaycastHit hit;

             if (Physics.Raycast(ray, out hit, 100)) {
                 Camera.main.transform.position = hit.collider.gameObject.transform.parent.position;
                 Camera.main.transform.position= Camera.main.transform.position + Vector3.up;
                 Camera.main.orthographicSize = 1.3f;
                 zoomedIn=true;
             }
         }
         else{
           Camera.main.orthographicSize = 6.0f;
           Camera.main.transform.position = Vector3.up;
           zoomedIn=false;
      }
      }
  }
}
