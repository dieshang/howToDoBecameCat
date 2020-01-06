using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour {

	void Start () {
		
	}
	
    public GameObject caidanglang;
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            caidanglang.SetActive(true);
        }
	}
    public GameObject rengwulang;
    public void closerengwulang()
    {
        rengwulang.SetActive(false);
    }
    public void openrengwulang()
    {
        rengwulang.SetActive(true);
    }
    public void closecaidanglang()
    {
        caidanglang.SetActive(false);
    }
    public void openchangku()
    {
        caidanglang.GetComponent<Transform>().GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("物品面板");
        shezhi.SetActive(false);
    }
    public GameObject shezhi;
    public void openshezhi()
    {
        caidanglang.GetComponent<Transform>().GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("设置面板");
        shezhi.SetActive(true);
    }
    public void openshouji()
    {
        caidanglang.GetComponent<Transform>().GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("物品收集面板");
        shezhi.SetActive(false);
    }
    public void opengongneng()
    {
        caidanglang.GetComponent<Transform>().GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("功能面板");
        shezhi.SetActive(false);
    }
    public void haogang()
    {
        caidanglang.GetComponent<Transform>().GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("好感度面板");
        shezhi.SetActive(false);
    }
    int mapative = 1;
    public GameObject map;
    public void Map()
    {
        if (mapative==1)
        {
        map.SetActive(true);
        }
        else
        {
            map.SetActive(false);
        }
        mapative = -mapative;
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
