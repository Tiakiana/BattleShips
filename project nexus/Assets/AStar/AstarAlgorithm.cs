using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AstarAlgorithm : MonoBehaviour {
    List<GameObject> open;
    List<GameObject> closed;

    void Start () {
        open = new List<GameObject>();
        closed = new List<GameObject>();
	}

    internal void SetStartingPoint(GameObject sp) {
        open.Add(sp);
    }
	
	void Update () {
	
	}
}
