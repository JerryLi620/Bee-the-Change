using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class BuildManager : MonoBehaviour
{
  private Building BuildingToPlace;
  public GameObject grid;
  public CustomCursor CusCursor;
  public Tile[] tiles;
  public TMP_Text News;

  private void Update()
  {
    if(Input.GetMouseButtonDown(0) && BuildingToPlace != null){
      Tile NearestTile = null;
      float ShortestDistance = float.MaxValue;
      foreach(Tile tile in tiles){
        float dist = Vector2.Distance(tile.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
        if(dist < ShortestDistance){
          ShortestDistance = dist;
          NearestTile = tile;
        }
      }
      if (NearestTile.isOccupied == false){
        Instantiate(BuildingToPlace, NearestTile.transform.position + new Vector3(0.07f,0.07f,0.5f), Quaternion.identity);
        BuildingToPlace = null;
        NearestTile.isOccupied = true;
        CusCursor.gameObject.SetActive(false);
        Cursor.visible = true;
      }
    }

  }

  public void BuildBuilding(Building building){
    CusCursor.gameObject.SetActive(true);
    CusCursor.GetComponent<SpriteRenderer>().sprite  = building.GetComponent<SpriteRenderer>().sprite;
    Cursor.visible = false;
    BuildingToPlace = building;
  }

  public void BuildHC(){
    Map_Behavior.honeyProduction+=2;
    News.text = "The honey production of your country increased!";
  }

  public void BuildBR(){
    Map_Behavior.beeRights+=2;
    News.text = "The bee citizens felt they are respected by the government!";
  }

  public void BuildPS(){
    Map_Behavior.flowerDensity+=2;
    News.text = "The flower begins to blossom!";
  }

  public void BuildBH(){
    Map_Behavior.lifeExpectancy+=2;
    News.text = "More bee citizens can enjoy the health care provided by the government.";
  }

  public void BuildDC(){
    Map_Behavior.happiness+=2;
    News.text = "Bee citizens are having fun in the dance club.";
  }
}
