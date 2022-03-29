using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Behavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      Camera.main.orthographicSize = 6.0f;
    }

    // Update is called once per frame
    void Update()
    {

      if ((Input.GetMouseButtonDown(0)) && (Camera.main.orthographicSize != 1.3f))
        Camera.main.orthographicSize = 1.3f;
      else if(Input.GetMouseButtonDown(0))
        Camera.main.orthographicSize = 6.0f;
      //if (Input.GetMouseButton(0))
      //{
    	   //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
     	   //RaycastHit hit;
     	// Casts the ray and get the first game object hit
     	  //Physics.Raycast(ray, out hit);
     	  //Debug.Log("This hit at " + hit.point );
      //}
    }
}
