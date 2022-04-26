using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider popSlider;
    public Slider honeySlider;
    public Slider brSlider;
    public Slider flowerSlider;
    public Slider lifeSlider;
    public Slider hapSlider;
    public Gradient gradient;
    public Image fill;

    public void SetMaxHealth(double stat)
    {
        honeySlider.maxValue = stat;
        honeySlider.value = stat / 2;

        popSlider.maxValue = stat;
        popSlider.value = stat / 2;

        brSlider.maxValue = stat;
        brSlider.value = stat / 2;

        flowerSlider.maxValue = stat;
        flowerSlider.value = stat / 2;

        lifeSlider.maxValue = stat;
        lifeSlider.value = stat / 2;

        hapSlider.maxValue = stat;
        hapSlider.value = stat / 2;

        fill.color = gradient.Evaluate(1f);
    }

    public void Start()
    {
        SetMaxHealth(100.0);
    }

    public void SetHealth(double stat)
    {
        honeySlider.value = stat;
        fill.color = gradient.Evaluate(honeySlider.normalizedValue);

        popSlider.value = stat;
        fill.color = gradient.Evaluate(popSlider.normalizedValue);

        brSlider.value = stat;
        fill.color = gradient.Evaluate(brSlider.normalizedValue);

        flowerSlider.value = stat;
        fill.color = gradient.Evaluate(flowerSlider.normalizedValue);

        lifeSlider.value = stat;
        fill.color = gradient.Evaluate(lifeSlider.normalizedValue);

        hapSlider.value = stat;
        fill.color = gradient.Evaluate(hapSlider.normalizedValue);

    }

}
