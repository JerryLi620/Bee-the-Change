using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Behavior : MonoBehaviour
{
  public static double popularity = 50;
  public static int honeyProduction = 50;
  public static int beeRights = 50;
  public static int flowerDensity = 50;
  public static int lifeExpectancy = 50;
  public static int happiness = 50;
  public static int popularityBonus = 0;
  private double multiplier1;
  private double multiplier2;
  private double multiplier3;
  private double multiplier4;
  private double multiplier5;

    void Update()
    {
      multiplier1 = 0.02*(honeyProduction-50)+1;
      multiplier2 = 0.02*(beeRights-50)+1;
      multiplier3 = 0.02*(flowerDensity-50)+1;
      multiplier4 = 0.02*(lifeExpectancy-50)+1;
      multiplier5 = 0.02*(happiness-50)+1;
      popularity = ((multiplier1*honeyProduction + multiplier2*beeRights + multiplier3*flowerDensity + multiplier4*lifeExpectancy + multiplier5*happiness)/5.0)+popularityBonus;
    }
}
