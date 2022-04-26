using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateBar : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    void Update()
    {
        currentHealth = Map_Behavior.honeyProduction ;
        healthBar.SetHealth(currentHealth);
    }
}
