using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DataDisplay : MonoBehaviour
{
    public TMP_Text honeyText;
    public TMP_Text beeText;
    public TMP_Text flowerText;
    public TMP_Text lifeText;
    public TMP_Text happinessText;
    public TMP_Text popularityText;
    // Update is called once per frame
    void Update()
    {
        honeyText.text = "Honey Productivity : " + Map_Behavior.honeyProduction;
        beeText.text = "Bee Rights : " + Map_Behavior.beeRights;
        flowerText.text = "Flower Density : " + Map_Behavior.flowerDensity;
        lifeText.text = "Life Expectancy : " + Map_Behavior.lifeExpectancy;
        happinessText.text = "Overall Happiness : " + Map_Behavior.happiness;
        popularityText.text = "Popularity : " + Map_Behavior.popularity;
    }
}
