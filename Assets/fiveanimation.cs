using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fiveanimation : MonoBehaviour {
    public UImanager uimanager;
    public TextManager textmanager;
    bool a = false;
    bool b = false;
    float time = 0;
	// Use this for initialization
	void Start () {
		
	}
	


   public void stopeven()
    {
        textmanager.cleartext();
        textmanager.addtext("这只外表看起来有些雍容华贵的黑色长毛猫，有着一双可怕的猩红色眼眸。");
        textmanager.addtext("它在用着这双眼眸直视着我的时候，我感受到的是比刚刚幽静时候所感受到恐惧的更甚的恐惧。");
        textmanager.addtext("虽然记忆中从未有过这只猫的身影，但是心头不知为何却涌出了一种似曾相识的感觉……");
        textmanager.addtext("残破不堪的身体，支离破碎的内脏，四周的鲜血随着雨水肆意流溢在草地之上。这样非人的虐待，确实令人感到震惊。");
        textmanager.addtext("这简直就像是——");
        textmanager.addtext("——恶魔的使魔。");
        textmanager.addtext("这种想法使我浑身一颤。");
        textmanager.addtext("……赶紧回去吧。");
        textmanager.addtext("但是……");
        textmanager.addtext("……动不了……这是怎么回事？！");
        textmanager.addtext("……为什么？？");
        textmanager.addtext("不管如何牵扯自己身上的肌肉，都无法移动一步。");
        textmanager.addtext("这并不是因为恐惧而身体僵直才导致的无法移动，而是单纯的“动不了”。");
        textmanager.addtext("就像被什么外力钳制住了一样。");
        textmanager.addtext("四周的空气也跟我的身体一样，仿佛凝固住了一般。");
        textmanager.addtext("我也无法发出声音，感觉声带也被停滞了。");
        textmanager.addtext("……");
        textmanager.addtext("即便我的内心此时因恐惧而扭曲、咆哮着，但没有人能听得见。");
        textmanager.addtext("在这种无法动弹的情况下，我只得将唯一能移动的视线移向了刚刚出现在面前的那只长毛黑猫……");
        textmanager.addtext("让人更意想不到的事情发生了。");
        textmanager.addtext("眼前的这只长毛黑猫，脸孔上浮现了诡异的神情。");
        textmanager.addtext("虽然不知该如何形容猫的表情！但是、现在它的脸孔上确实出现了这种诡异的变化！");
        textmanager.addtext("黑猫脸上的诡异神情与稀稀疏疏的清冷月色重合在一起，显得异常惊悚。");
        textmanager.addtext("……虽然现在这个情况就已经够惊悚了。");
        textmanager.addtext("！！！");
        textmanager.addtext("思考的刹那间，这只长毛的黑猫慢步朝我这边走来。");
        textmanager.addtext("每走一步，我内心的恐惧就增添一分，它眼中的神情也随着变化一分。");
        textmanager.addtext("我在它的眼中看到的只有仇恨。");
        textmanager.addtext("它的猩红色眼眸像是在诉说着什么一样。虽然四周依旧寂静，但我仍然从它的眼神中感受到了它那逐渐浓厚的无尽恨意。");
        textmanager.addtext("而且，它的这种恨意，很明显是冲着我来的！");
        textmanager.addtext("……这到底是怎么回事啊！！！");
        textmanager.addtext("如果现在能动能发出声音的话，估计我已经眼泪鼻涕横流然后大叫着逃跑了吧。");
        textmanager.addtext("深陷于恐惧之中的我既无法动弹也无法开口说话，但是我感觉到了自己浑身上下的每一块肌肉都在不停地颤抖。");
        textmanager.addtext("最终，这只猫走到了我的面前，朝着我张开了嘴——");
        textmanager.addtext("——它想把我撕碎");
        textmanager.addtext("我是真的感觉到它流露出了能将我撕碎的恨意。甚至有了它身上即将涌出的若隐若现的黑色气息幻觉。");
        textmanager.addtext("它的眼瞳中的色彩比刚刚更加复杂了一些，夹杂着像是快要涌出来的悲伤。但是最后恨意还是扑灭了其他所有的情感，化身成为了它身上仅有的情感——");
        textmanager.addtext("它扑了上来，像是恶魔一样咬住了我的喉咙。");
        textmanager.loadtext();
        uimanager.showui("textbox");
        a = true;
    }

   void Update()
   {
       if (a = true && textmanager.boxIsEnd)
       {
          GameObject.Find("player").GetComponent<Animator>().SetBool("die",true);
        
          textmanager.addtext("根本无法反抗，只得任由摆布……");
          textmanager.addtext("然后感受到了逐渐加深的疼痛——");
          textmanager.addtext("感受到了喉管被咬破之后鲜血喷涌而出的感觉……感受到了脸部以及五官被咬烂划烂的感觉……感受到了肚子被咬穿后内容物流遍整个身体的感觉……感受到了肚肠被扯出然后撕碎的感觉……感受到了还活着却渐渐被对方撕咬下肚慢慢蚕食的恶心感觉……");
          textmanager.addtext("残破不堪的身体，支离破碎的内脏，四周的鲜血随着雨水肆意流溢在草地之上。这样非人的虐待，确实令人感到震惊。");
          textmanager.addtext("一切都像是噩梦一般，不断地重复往返——");
          textmanager.addtext("直到我的身体破碎到无法再继续蚕食……");
          textmanager.loadtext();
          uimanager.showui("textbox");
          textmanager.boxIsEnd = false;
          a = false;
          b = true;
       }
   
       if (b == true )
       { time += Time.deltaTime;
       if (time > 60)
       {
           uimanager.showui("black");
           uimanager.getui("black").GetComponent<Animator>().SetBool("blak", true);
       }
       }
   }
}
