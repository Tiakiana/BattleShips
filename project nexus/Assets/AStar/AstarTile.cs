using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class AstarTile : MonoBehaviour {
    public int h;
    public int f;
    public int g;
    public bool walkable = true;
    public bool closed = false;
    public List<GameObject> neighbors = new List<GameObject>();
    public int gridX;
    public int gridY;
    void Start() {

    }

    public void AstarTileSet(int _X, int _Y) {
        gridX = _X;
        gridY = _Y;
    }
    internal void SetColor() {
        gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
    }
	
	void Update () {
	
	}
}
