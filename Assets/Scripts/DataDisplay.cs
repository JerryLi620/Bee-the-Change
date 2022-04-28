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
        honeyText.text = "Honey Productivity: ";
        beeText.text = "Bee Rights: ";
        flowerText.text = "Flower Density: ";
        lifeText.text = "Life Expectancy: ";
        happinessText.text = "Overall Happiness: ";
        popularityText.text = "Popularity: ";
    }
}
