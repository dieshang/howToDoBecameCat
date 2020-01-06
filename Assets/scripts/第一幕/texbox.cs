/*对话框*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class texbox : MonoBehaviour {

    Text texcomp;
    /// <summary>
    /// 对话数量
    /// </summary>
   public int num;
    /// <summary>
    /// 对话内容
    /// </summary>
   public List<string> text;
    /// <summary>
    /// 说话人物
    /// </summary>
      public List<string> sayname;
    /// <summary>
    /// 对话是否已经结束
    /// </summary>
   public bool isend;
   
	void Start () {
        texcomp = this.GetComponentInChildren<Text>();

    }
   
	
	void Update () {
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
      //  transform.GetChild(2).gameObject.SetActive(false);

        texcomp.text = text[num];
        if (sayname[num] == "教师") transform.GetChild(0).gameObject.SetActive(true);
            else if (sayname[num] == "魔法师") transform.GetChild(1).gameObject.SetActive(true);
        else if (sayname[num] == "猫") transform.GetChild(2).gameObject.SetActive(true);
        else {
                 transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(false);
         //   transform.GetChild(2).gameObject.SetActive(false);
            }
       
	}
   
    
    public void Updatetext(){
       
        num++;
        if (num > text.Count - 1)
        {
            this.gameObject.SetActive(false);
         
            isend = true;
            return;
        }
       //texcomp.text = text[num];
    }
}
