using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Behavior : MonoBehaviour
{
  public static int popularity = 50;
  public static int honeyProduction = 50;
  public static int beeRights = 50;
  public static int flowerDensity = 50;
  public static int lifeExpectancy = 50;
  public static int happiness = 50;
  public static int popularityBonus = 0;


    void Update()
    {
      popularity = ((honeyProduction + beeRights + flowerDensity + lifeExpectancy + happiness)/5)+popularityBonus;
    }
}
