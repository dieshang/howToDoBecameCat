using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class part2contro : MonoBehaviour {
   public UImanager uimanager;
   public TextManager textmanager;

	// Use this for initialization
	void Start () {
        if (!uimanager) uimanager = this.GetComponent<UImanager>();
        if (!textmanager) textmanager = this.GetComponent<TextManager>();
        textmanager.cleartext();
        textmanager.addtext("在这黑暗之中——");
        textmanager.addtext("一只奄奄一息的猫，正静静地躺在冰冷的草地上");
        textmanager.addtext("仿佛放弃了挣扎一般，只剩最后一口气，或许还残存有一丝意识，但思绪早已陷入了往事的走马灯。");
        textmanager.addtext("残破不堪的身体，支离破碎的内脏，四周的鲜血随着雨水肆意流溢在草地之上。这样非人的虐待，确实令人感到震惊。");
        textmanager.addtext("但是少女却丝毫不以为意。");
        textmanager.addtext("“可怜的猫啊……”");
        textmanager.addtext("少女的嘴角吐露出了惋惜的话语。");
        textmanager.addtext("但是她的话语中，却完全感受不到一丝惋惜之情。");
        textmanager.addtext("她，不存在“悲伤”这一感情。");
        textmanager.addtext("映照在她漂亮眼眸之中的猫，身上缠绕着无名的黑色之气。");
        textmanager.addtext("这令猫的呼吸更加的困难，仿佛是要夺走它最后的一口气一般。");
        textmanager.addtext("“呐，我们做一场交易如何——");
        textmanager.addtext("要么现在马上死掉，要么永远不会死去……”");
        textmanager.addtext("她的脸庞突然清晰。");
        textmanager.addtext("少女，露出了可怕的笑容。");
        textmanager.loadtext();
        uimanager.showui(1);
	}
    /// <summary>
    /// 下一个目标切换场景
    /// </summary>
    public void loadScene(){
             SceneManager.LoadScene("three");
    }
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            uimanager.showui(0);
        }
        //如果对话结束
        if (textmanager.boxIsEnd)
        {
            uimanager.showui(2);
            uimanager.getui(2).GetComponent<Animator>().SetBool("blak", true);
          
        }
	}
}
