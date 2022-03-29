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

    }
}
