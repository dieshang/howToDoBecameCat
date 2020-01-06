using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mmagiciananievent : MonoBehaviour
{
     public bool isMmagicianNearCat = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MmagicianNearCat()
    {
        isMmagicianNearCat = true;
        this.GetComponent<Animator>().SetBool("stop", true);
    }
}
