using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class UpdateBar : MonoBehaviour
{
    public float popStat;
    public float honeyStat;
    public float brStat;
    public float flowerStat;
    public float lifeStat;
    public float hapStat;

    public HealthBar popBar;
    public HealthBar honeyBar;
    public HealthBar brBar;
    public HealthBar flowerBar;
    public HealthBar lifeBar;
    public HealthBar hapBar;

    public TMP_Text PopCount;
    public TMP_Text HPCount;
    public TMP_Text BRCount;
    public TMP_Text FDCount;
    public TMP_Text LECount;
    public TMP_Text OHCount;

    // Start is called before the first frame update
    void Start()
    {
        popBar.SetPop(50.0f);
        honeyBar.SetHoney(50.0f);
        brBar.SetBr(50.0f);
        flowerBar.SetFlower(50.0f);
        lifeBar.SetLife(50.0f);
        hapBar.SetHap(50.0f);
        PopCount.text = Map_Behavior.popularity.ToString("0.0");
        HPCount.text = Map_Behavior.honeyProduction.ToString();
        BRCount.text = Map_Behavior.beeRights.ToString();
        FDCount.text = Map_Behavior.flowerDensity.ToString();
        LECount.text = Map_Behavior.lifeExpectancy.ToString();
        OHCount.text = Map_Behavior.happiness.ToString();
    }

    void Update()
    {
        honeyStat = (float)Map_Behavior.honeyProduction;
        honeyBar.SetHoney(honeyStat);

        popStat = (float)Map_Behavior.popularity;
        popBar.SetPop(popStat);

        brStat = (float)Map_Behavior.beeRights;
        brBar.SetBr(brStat);

        flowerStat = (float)Map_Behavior.flowerDensity;
        flowerBar.SetFlower(flowerStat);

        lifeStat = (float)Map_Behavior.lifeExpectancy;
        lifeBar.SetLife(lifeStat);

        hapStat = (float)Map_Behavior.happiness;
        hapBar.SetHap(hapStat);

        PopCount.text = Map_Behavior.popularity.ToString("0.0");
        HPCount.text = Map_Behavior.honeyProduction.ToString();
        BRCount.text = Map_Behavior.beeRights.ToString();
        FDCount.text = Map_Behavior.flowerDensity.ToString();
        LECount.text = Map_Behavior.lifeExpectancy.ToString();
        OHCount.text = Map_Behavior.happiness.ToString();
    }

}
