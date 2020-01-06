using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class part3contro : MonoBehaviour {
    public AudioSource music;
    public UImanager uimanager;
    public GameObject player;
    public GameObject xu;
    public TextManager textmanager;
    public npc[] npceven;
    //计时器
    float time = 0;
    bool shangke = true;
	void Start () {
        DontDestroyOnLoad(player);
        DontDestroyOnLoad(xu);
       // npceven = new npc[6];
	}
    /// <summary>
    /// 下一个目标切换场景
    /// </summary>
    public void loadScene()
    {
        player.transform.GetChild(0).gameObject.SetActive(false);

        SceneManager.LoadScene("fourAndFive");
    }
	// Update is called once per frame
	void Update () {
        if (shangke)
        time += Time.deltaTime;
        if (time > 5)
        {
            shangke = false;
            time = 0;
            //下课铃响
            if (!music.isPlaying)
            {
                //播放音乐
                music.Play();
            }
            //老师说话
            teachersay();

        }

        //对话是否结束
        if (textmanager.boxIsEnd)
        { 
            //npc离开教室
            for (int i = 0; i < 6;i++ )
                npceven[i].leaveClassroom();

        }

        if (Input.GetKey(KeyCode.Escape))
        {
            uimanager.showui(0);
        }
	}

    //显示对话
    void teachersay()
    {
       
        textmanager.cleartext();
        textmanager.addtext("已经下课了，同学们下节课再见。", "教师");
        textmanager.addtext("……");
        textmanager.loadtext();
        uimanager.showui(1);
    }
}
