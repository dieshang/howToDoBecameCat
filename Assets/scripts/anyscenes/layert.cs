using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layert : MonoBehaviour {

	
	void Start () {
		
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.tag);
        switch (col.tag)
        {
            case "layer":
                gameObject.GetComponent<SpriteRenderer>().sortingOrder = col.GetComponent<layericon>().layer;
               
                break;
        }


    }
	void Update () {
		
	}
}
