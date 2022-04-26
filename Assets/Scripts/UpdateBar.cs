using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UpdateBar : MonoBehaviour
{
    public double popStat;
    public double honeyStat;
    public double brStat;
    public double flowerStat;
    public double lifeStat;
    public double hapStat;

    public HealthBar popBar;
    public HealthBar honeyBar;
    public HealthBar brBar;
    public HealthBar flowerBar;
    public HealthBar lifeBar;
    public HealthBar hapBar;

    // Start is called before the first frame update
    void Start()
    {
        popBar.SetHealth(50.0d);
        honeyBar.SetHealth(50.0d);
        brBar.SetHealth(50.0d);
        flowerBar.SetHealth(50.0d);
        lifeBar.SetHealth(50.0d);
        hapBar.SetHealth(50.0d);
    }

    void Update()
    {
        honeyStat = Map_Behavior.honeyProduction;
        honeyBar.SetHealth(honeyStat);

        popStat = Map_Behavior.popularity;
        popBar.SetHealth(popStat);

        brStat = Map_Behavior.beeRights;
        brBar.SetHealth(brStat);

        flowerStat = Map_Behavior.flowerDensity;
        flowerBar.SetHealth(flowerStat);

        lifeStat = Map_Behavior.lifeExpectancy;
        lifeBar.SetHealth(lifeStat);

        hapStat = Map_Behavior.happiness;
        hapBar.SetHealth(hapStat);
    }

}
