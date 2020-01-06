using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shezhi : MonoBehaviour {


	void Start () {
		
	}
	
	
	void Update () {
		
	}

    public void tuicuyouxi()
    {
        //退出游戏
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
