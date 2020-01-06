using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class part5 : MonoBehaviour {
    public GameObject scenecontro;
    public GameObject cat;
	// Use this for initialization
	void Start () {
		
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.tag)
        {
            case "Player":
                scenecontro.SendMessage("showtext",3);
                 cat.SetActive(true);

                 cat.GetComponent<Animator>().Play("catlefttor");
                break;
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
