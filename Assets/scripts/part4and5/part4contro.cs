using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class part4contro : MonoBehaviour {
   UImanager uimanager;
   TextManager textmanager;
   public GameObject cat;
    //记录当前剧情的进展
   int nowtextnum;
	void Start () {
        nowtextnum = 0;
        if (!uimanager) uimanager = this.GetComponent<UImanager>();
        if (!textmanager) textmanager = this.GetComponent<TextManager>();
        //设置主角出生点
        GameObject.Find("player").transform.position = transform.position;
        GameObject.Find("player").GetComponent<move>().xmax = 63.5f;
        GameObject.Find("player").GetComponent<move>().ymax = -0.74f;
        GameObject.Find("player").GetComponent<move>().xmin = 0.44f;
        GameObject.Find("player").GetComponent<move>().ymin = -45.1f;
        //显示剧情一
        showtext(1);
        nowtextnum += 1;
     

	}
    //显示剧情
    void showtext(int num)
    {
        textmanager.cleartext();
        if (num == 1)
        {
            textmanager.addtext("今晚是满月啊……");
            textmanager.loadtext();
            uimanager.showui("textbox");
        }
        if (num == 2)
        {
            textmanager.addtext("稍微有点冷呢……明明已经春天了。");
            textmanager.addtext("……而且还一直是大雾天，坐在教室里面都感觉得到潮湿啊。哎。");
            textmanager.addtext("这所学校名叫软农大学，是我正在上的大学。");
            textmanager.addtext("虽然身为这所学校的学生这么说有点不好意思，但它确实是一所名字奇怪的大学。");
            textmanager.addtext("我在一年前考上了这所大学，现在在中文系就读中，过着近似独行侠的生活。");
            textmanager.addtext("今天那几条路都在整修啊……看来只能走湖边的路了。");
            textmanager.addtext("总感觉今天会碰见猫……得想办法避开了。");
            textmanager.addtext("这所学校什么都还过得去……只是校园里面的猫咪有点多过头了。");
            textmanager.addtext("当然我并不是厌恶猫……只是因为以前的一些事有些阴影，导致我现在非常害怕猫。");
            textmanager.addtext("今晚是晚课，所以必定会在路上遇到趁着夜色出来活动的猫们。");
            textmanager.addtext("唔……还是赶紧回宿舍吧。");
            textmanager.loadtext();
            uimanager.showui("textbox");
        }

        if (num == 3)
        {
            textmanager.addtext("……？");
            textmanager.addtext("……？？！！！");
            textmanager.addtext("不对劲。");
            textmanager.addtext("很不对劲。");
            textmanager.addtext("这里是……体育馆？！");
            textmanager.addtext("刚刚走在湖边时，感到了一阵类似于中暑的短暂的晕眩。");
            textmanager.addtext("结果现在回过神来时，发现自己走在了与宿舍截然相反的方向上的道路上。");
            textmanager.addtext("大脑还没完全清醒，但隐隐约约感到了一阵不妙。");
            textmanager.addtext("奇怪……");
            textmanager.addtext("这条路应该是通往女生的宿舍。但其他人都去哪了？");
            textmanager.addtext("按道理来说，现在这个时候正好是下课时间，理应会有很多女生成群结队地走在这条路上。");
            textmanager.addtext("但四周的氛围却异常寂静。让人有种方圆几里都没有人存在的感觉。");
            textmanager.addtext("有点不对劲啊……");
            textmanager.addtext("当试着往回走的时候，身后的路突然传来了一声猫叫。");
            textmanager.addtext("这声猫叫很诡异。");
            textmanager.addtext("！！！");
            textmanager.loadtext();
            uimanager.showui("textbox");
        }
    }
	
	void Update () {
        //剧情二
        if (textmanager.boxIsEnd && nowtextnum==1)
        {
            nowtextnum += 1;
            //显示星空CG
            uimanager.showui("xingkong");
            //显示剧情二
            showtext(2);
            textmanager.boxIsEnd = false;
        }

        if (textmanager.boxIsEnd && nowtextnum == 2)
        {
            //隐藏星空CG
            uimanager.closeui("xingkong");
            nowtextnum += 1;
            textmanager.boxIsEnd = false;
        }
      
        //if (textmanager.boxIsEnd && nowtextnum == 4)
        //{
        //    cat.SetActive(true);
        //    cat.GetComponent<Animation>().Play();
        //    textmanager.boxIsEnd = false;
        //}
       
	}
    public void loadScene()
    {
        SceneManager.LoadScene("six");
    }
}
