using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider honeySlider;
    public Gradient gradient;
    public Image fill;

    public void SetMaxHealth(int stat)
    {
        honeySlider.maxValue = stat;
        honeySlider.value = stat;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int stat)
    {
        honeySlider.value = stat;
        fill.color = gradient.Evaluate(honeySlider.normalizedValue);
    }

}
