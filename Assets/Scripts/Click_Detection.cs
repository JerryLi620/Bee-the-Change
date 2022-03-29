using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Detection : MonoBehaviour
{
  void Update(){
    if (Input.GetMouseButtonDown (0)) {
             var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             RaycastHit hit;

             if (Physics.Raycast(ray, out hit, 100)) {
                 Debug.Log(hit.collider.gameObject.transform.parent.name);
             }
         }
  }
}
