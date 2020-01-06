using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour {
    public int num=1;
    Animator npcanimator;
    void Start()
    {
     
        npcanimator = this.GetComponent<Animator>();
      
    }
  //播放向上走动画
    void walkup()
    {
        npcanimator.SetBool("walkup", true);
        npcanimator.SetBool("walkright", false);
    }
    //播放向右走动画
    void walkright()
    {

        npcanimator.SetBool("walkup", false);
        npcanimator.SetBool("walkright", true);
        if (this.gameObject.transform.localScale.x < 0)
            this.gameObject.transform.localScale = new Vector2(-this.gameObject.transform.localScale.x, this.gameObject.transform.localScale.y);
    }
    //播放向左走动画
    void walkleft()
    {
        npcanimator.SetBool("walkup", false);
        npcanimator.SetBool("walkright", true);
        if (this.gameObject.transform.localScale.x>0)
        this.gameObject.transform.localScale = new Vector2(-this.gameObject.transform.localScale.x, this.gameObject.transform.localScale.y);
    }
    //离开教室
    public void leaveClassroom(){
        npcanimator.SetInteger("index", num);
    }
	void Update () {
	
	
	}
}
