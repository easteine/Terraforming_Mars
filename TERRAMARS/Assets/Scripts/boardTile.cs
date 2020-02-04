using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boardTile : MonoBehaviour
{

    public GameObject tile;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUp()
    {

        tile.GetComponent<Renderer>().enabled = !(tile.GetComponent<Renderer>().enabled);
    }
}
