using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class part1control : MonoBehaviour {
   public UImanager uimanager;
   public TextManager textmanager;
 public Mmagiciananievent magiciananievent;
	// Use this for initialization
	void Start () {
        if (!uimanager) uimanager = this.GetComponent<UImanager>();
        if (!textmanager) textmanager = this.GetComponent<TextManager>();
        textmanager.addtext("少女优雅地漫步于这片荒废的草丛之中。");
        textmanager.addtext("冰冷的草地，充斥着名为“死”的气息。");
        textmanager.addtext("生硬的泥土夹杂着血色的腥味，慢慢融入了这茫茫的雨水中。");
        textmanager.addtext("虽然看似只是一场令人颇感凄清的小雨。");
        textmanager.addtext("然而在这之中，却有着她极其熟悉的味道——");
        textmanager.addtext("“啊啦~瘫在地上的孩子，你怎么了？”");
        textmanager.addtext("少女向着那“死”之气息的中心悄然走去。");
        textmanager.addtext("优雅的洋伞，沉稳的步伐，一身华美的洋装。");
        textmanager.addtext("但是异样的是她的面貌，宛如被一层薄雾笼罩一般，无法清晰目睹其真容，仿佛这份容颜不存在于世一般。");
        textmanager.addtext("但是毫无疑问，那份与常人不符合的强烈违和感，即使是普通人也能清晰地感受到。");
        textmanager.addtext("这个人，绝非泛泛之辈。");
        textmanager.addtext("神秘的少女，迈向那被黑暗掩盖的草丛深处。");
        textmanager.loadtext();
        uimanager.showui(1);
	}

    void loadScene()
    {
        SceneManager.LoadScene("two");
    }
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            uimanager.showui(0);
        }
        //转场
        if (textmanager.boxIsEnd && magiciananievent.isMmagicianNearCat)
        {
            uimanager.showui(2);
            uimanager.getui(2).GetComponent<Animator>().SetBool("blak", true);
        }
	}
}
