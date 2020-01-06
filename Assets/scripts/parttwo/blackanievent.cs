using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackanievent : MonoBehaviour {
    public GameObject scenecontro;
	
	void Start () {
		
	}
	
	public void tonewscene(){
        scenecontro.SendMessage("loadScene");
   
    }
	void Update () {
		
	}
}
