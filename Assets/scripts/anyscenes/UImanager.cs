/*UI管理类，保存场景中所有的UI*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour {

    public List<GameObject> allUi = new List<GameObject>();

	void Start () {
		
	}
    /// <summary>
    /// 显示UI
    /// </summary>
    /// <param name="Name">UI名称</param>
    public void showui(string Name)
    {
        for (int i = 0; i < allUi.Count; i++)
        {
            if (allUi[i].name == Name)
            {
                allUi[i].SetActive(true);
            }
        }
    }
    /// <summary>
    /// 显示UI
    /// </summary>
    /// <param name="index">UI下标</param>
    public void showui(int index)
    {
        
        allUi[index].SetActive(true);
       
    }
    /// <summary>
    /// 隐藏UI
    /// </summary>
    /// <param name="Name">UI名称</param>
    public void closeui(string Name)
    {
        for (int i = 0; i < allUi.Count; i++)
        {
            if (allUi[i].name == Name)
            {
                allUi[i].SetActive(false);
            }
        }
    }
    /// <summary>
    /// 关闭UI
    /// </summary>
    /// <param name="index">UI下标</param>
    public void closeui(int index)
    {
        allUi[index].SetActive(false);
    }
    /// <summary>
    /// 获取UI
    /// </summary>
    /// <param name="Name">名称</param>
    /// <returns></returns>
    public GameObject getui(string Name)
    {
        for (int i = 0; i < allUi.Count; i++)
        {
            if (allUi[i].name == Name)
            {
                return allUi[i];
            }
        }
        return null;
    }
    /// <summary>
    /// 获取UI
    /// </summary>
    /// <param name="index">下标</param>
    /// <returns></returns>
    public GameObject getui(int index)
    {
        return allUi[index];
        
    }
	void Update () {
      
	}
}
