using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex_Data : MonoBehaviour
{
    public string topTrait;

void Start()
{
int random_number = Random.Range(1, 7);
  if(random_number == 1){
    topTrait = "honeyProduction";
  }
  if(random_number == 2){
    topTrait = "beeRights";
  }
  if(random_number == 3){
    topTrait = "flowerDensity";
  }
  if(random_number == 4){
    topTrait = "lifeExpectancy";
  }
  if(random_number == 5){
    topTrait = "happiness";
  }
  DontDestroyOnLoad(this.gameObject);
}

}
