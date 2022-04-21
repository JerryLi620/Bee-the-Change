using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BuildManager : MonoBehaviour
{
  private Building BuildingToPlace;
  public GameObject grid;
  public CustomCursor CusCursor;
  public Tile[] tiles;

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
        Instantiate(BuildingToPlace, NearestTile.transform.position + new Vector3(0.05f,0.05f,0.1f), Quaternion.identity);
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

  private int HCimprove;
  private int BRimprove;
  private int PSimprove;
  private int BHimprove;
  private int DCimprove;

  public void BuildHC(){
    
  }

}
