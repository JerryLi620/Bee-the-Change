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

  public Image ArrowHP1;
  public Image ArrowHP2;
  public Image ArrowBR1;
  public Image ArrowBR2;
  public Image ArrowFD1;
  public Image ArrowFD2;
  public Image ArrowLE1;
  public Image ArrowLE2;
  public Image ArrowOH1;
  public Image ArrowOH2;

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
    ArrowOH1.enabled = false;
    ArrowOH2.enabled = false;
    ArrowHP1.enabled = true;
    ArrowHP2.enabled = false;
    ArrowBR1.enabled = false;
    ArrowBR2.enabled = false;
    ArrowFD1.enabled = false;
    ArrowFD2.enabled = false;
    ArrowLE1.enabled = false;
    ArrowLE2.enabled = false;
  }

  public void BuildBR(){
    Map_Behavior.beeRights+=2;
    News.text = "The bee citizens felt they are respected by the government!";
    ArrowOH1.enabled = false;
    ArrowOH2.enabled = false;
    ArrowHP1.enabled = false;
    ArrowHP2.enabled = false;
    ArrowBR1.enabled = true;
    ArrowBR2.enabled = false;
    ArrowFD1.enabled = false;
    ArrowFD2.enabled = false;
    ArrowLE1.enabled = false;
    ArrowLE2.enabled = false;
  }

  public void BuildPS(){
    Map_Behavior.flowerDensity+=2;
    News.text = "The flower begins to blossom!";
    ArrowOH1.enabled = false;
    ArrowOH2.enabled = false;
    ArrowHP1.enabled = false;
    ArrowHP2.enabled = false;
    ArrowBR1.enabled = false;
    ArrowBR2.enabled = false;
    ArrowFD1.enabled = true;
    ArrowFD2.enabled = false;
    ArrowLE1.enabled = false;
    ArrowLE2.enabled = false;
  }

  public void BuildBH(){
    Map_Behavior.lifeExpectancy+=2;
    News.text = "More bee citizens can enjoy the health care provided by the government.";
    ArrowOH1.enabled = false;
    ArrowOH2.enabled = false;
    ArrowHP1.enabled = false;
    ArrowHP2.enabled = false;
    ArrowBR1.enabled = false;
    ArrowBR2.enabled = false;
    ArrowFD1.enabled = false;
    ArrowFD2.enabled = false;
    ArrowLE1.enabled = true;
    ArrowLE2.enabled = false;
  }

  public void BuildDC(){
    Map_Behavior.happiness+=2;
    News.text = "Bee citizens are having fun in the dance club.";
    ArrowOH1.enabled = true;
    ArrowOH2.enabled = false;
    ArrowHP1.enabled = false;
    ArrowHP2.enabled = false;
    ArrowBR1.enabled = false;
    ArrowBR2.enabled = false;
    ArrowFD1.enabled = false;
    ArrowFD2.enabled = false;
    ArrowLE1.enabled = false;
    ArrowLE2.enabled = false;
  }
}
