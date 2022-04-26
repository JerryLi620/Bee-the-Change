using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UpdateBar : MonoBehaviour
{
    public int currentStat;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.SetHealth(50);
    }

    // Update is called once per frame
    void Update()
    {
        if(currentStat != Map_Behavior.honeyProduction)
        {
           healthBar.SetHealth(Map_Behavior.honeyProduction);
        }
   
    }

    void Update()
    {
        currentHealth = Map_Behavior.honeyProduction ;
        healthBar.SetHealth(currentHealth);
    }

}
