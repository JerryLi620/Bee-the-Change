using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAppearance : MonoBehaviour
{
    public GameObject Option_1;

    IEnumerator Start()
    {
        Option_1.SetActive(false);
        yield return new WaitForSeconds(12f);
        Option_1.SetActive(true);
    }
}
