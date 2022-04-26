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

    public void SetMaxHealth(float stat)
    {
        honeySlider.maxValue = stat;
        honeySlider.value = stat / 2.0f;

        popSlider.maxValue = stat;
        popSlider.value = stat / 2.0f;

        brSlider.maxValue = stat;
        brSlider.value = stat / 2.0f;

        flowerSlider.maxValue = stat;
        flowerSlider.value = stat / 2.0f;

        lifeSlider.maxValue = stat;
        lifeSlider.value = stat / 2.0f;

        hapSlider.maxValue = stat;
        hapSlider.value = stat / 2.0f;

        fill.color = gradient.Evaluate(1f);
    }

    public void Start()
    {
        SetMaxHealth(100.0f);
    }

    public void SetHoney(float stat)
    {
        honeySlider.value = stat;
        fill.color = gradient.Evaluate(honeySlider.normalizedValue);
    }
    public void SetPop(float stat)
    {
        popSlider.value = stat;
        fill.color = gradient.Evaluate(popSlider.normalizedValue);
    }
    public void SetBr(float stat)
    {
        brSlider.value = stat;
        fill.color = gradient.Evaluate(brSlider.normalizedValue);
    }
    public void SetFlower(float stat)
    {
        flowerSlider.value = stat;
        fill.color = gradient.Evaluate(flowerSlider.normalizedValue);
    }
    public void SetLife(float stat)
    {
        lifeSlider.value = stat;
        fill.color = gradient.Evaluate(lifeSlider.normalizedValue);
    }
    public void SetHap(float stat)
    {
        hapSlider.value = stat;
        fill.color = gradient.Evaluate(hapSlider.normalizedValue);
    }
}
