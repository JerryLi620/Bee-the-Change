using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DataDisplay : MonoBehaviour
{
    private int honeyProductivity = 10;
    private int beeRights = 10;
    private int flowerDensity = 10;
    private int lifeExpectancy = 10;
    private int overallHappiness = 10;
    private int popularity = 100;

    public TMP_Text honeyText;
    public TMP_Text beeText;
    public TMP_Text flowerText;
    public TMP_Text lifeText;
    public TMP_Text happinessText;
    public TMP_Text popularityText;

    // Update is called once per frame
    void Update()
    {
        honeyText.text = "Honey Productivity : " + honeyProductivity;
        beeText.text = "Bee Rights : " + beeRights;
        flowerText.text = "Flower Density : " + flowerDensity;
        lifeText.text = "Life Expectancy : " + lifeExpectancy;
        happinessText.text = "Overall Happiness : " + overallHappiness;
        popularityText.text = "Popularity : " + popularity;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            honeyProductivity--;
            beeRights--;
            flowerDensity--;
            lifeExpectancy--;
            overallHappiness--;
            popularity--;
        }
    }
}
