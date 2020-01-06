using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class uicontro : MonoBehaviour {

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void startgame()
    {
        SceneManager.LoadScene("one");
    }
    public void exitgame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void updatestyle(int index){
        this.GetComponent<Animator>().SetInteger("style", index);
    }
}
