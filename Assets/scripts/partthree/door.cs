using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {
    public UImanager uimanager;
	void Start () {
		
	}
	
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.tag);
        switch (col.tag)
        {
               
            case "npc":
                col.gameObject.SetActive(false);
                break;
            case "Player":
                 uimanager.showui(2);
            uimanager.getui(2).GetComponent<Animator>().SetBool("blak", true);
                break;
        }
    }
}
