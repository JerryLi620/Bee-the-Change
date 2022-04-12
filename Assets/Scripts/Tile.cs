using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
  public bool isOccupied;

  private SpriteRenderer rend;

  private void start()
  {
    rend = GetComponent<SpriteRenderer>();
  }

}
