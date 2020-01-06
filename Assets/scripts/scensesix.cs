using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scensesix : MonoBehaviour {
    public UImanager uimanager;
    public TextManager textmanager;
    int nowtextnum;
	// Use this for initialization
	void Start () {
        textmanager.cleartext();
        textmanager.addtext("感觉自己像是做了一个长梦。");
        textmanager.addtext("梦到了许多不明所以的东西，也在梦中看到了许多似曾相识的东西。");
        textmanager.addtext("然后，眼前出现了微弱的亮光——");
        textmanager.addtext("……","猫");
        textmanager.addtext("像是从沉睡中醒来一般，大脑在那一瞬间恢复了还尚模糊的意识。");
        textmanager.addtext("眼皮没有睁开。但似乎感受到了来自外界的些许亮光。");
        textmanager.addtext("那种微弱而朦胧的感觉，促使我机械式地动了动自己的肩膀……");
        textmanager.addtext("随着触感越来越清晰，我的意识也渐渐地恢复。");
        textmanager.addtext("……我……还活着？","猫");
        textmanager.addtext("大脑中划过的话语，下意识地从口中说了出来。");
        textmanager.addtext("……我应该……是被杀了……被那只猫咬碎了……","猫");
      textmanager.addtext( "慢慢地将眼皮睁开，刺眼的光线涌入视野，确实感受到了还活着的实感。");
textmanager.addtext("但是眼前出现的光景，有些出乎意料。");
textmanager.addtext( "我似乎正斜躺在地板上，因为眼中的所有事物都颠倒了大概九十度左右。");
textmanager.addtext( "但是这不是重点……");
textmanager.addtext( "……好大！！","猫");
textmanager.addtext( "出现在我面前的这些看似普通的家具以及书架，整个被放大了数倍。");
textmanager.addtext( "随处可见的大桌子，此时在我的眼中却像是大山一样高大。书架就更不用说了。我觉得我甚至没有其中的一层那么高。");
textmanager.addtext( "就连普通的板凳，也超过了我的身体大小。");
textmanager.addtext( "有一瞬间我真的以为自己是来到了《杰克与豆径》中的巨人国世界。");
textmanager.addtext( "但是不是的。");
textmanager.addtext( "这里既不是格列佛游记里的巨人国，也不是杰克攀登着豆苗到达的巨人世界。而是我原本就生活着的现实世界。");
textmanager.addtext( "我尝试着坐起身体，同时又意识到了更不对劲的事情。");
textmanager.addtext( "不是周围的环境变了……而是我自己的身体变了！");
textmanager.addtext( "我无法用以前的坐姿坐起来，因为——");
textmanager.addtext( "——我变成了一只猫。");
textmanager.addtext( "……咦咦咦？？？！","猫");
textmanager.addtext( "我目瞪口呆地环视着自己的身体。");
textmanager.addtext( "黑灰色的短毛发覆盖着整个身体。肉团一样的手脚中的锋利爪子伸缩自如。长长的尾巴因为不适应的缘故显得有些僵直。");
textmanager.addtext( "猫？？！","猫");
textmanager.addtext( "在意识到自己现在变成了一只猫的瞬间，甚至感觉自己的听觉与嗅觉比从前更加灵敏了许多。");
textmanager.addtext("这不是错觉……", "猫");
textmanager.addtext( "我震惊地无法说话。");
textmanager.addtext( "我甚至想伸出手拍拍自己的脸颊，以试探这到底是梦境还是现实。");
textmanager.addtext( "……但是我现在只能用四只手爪的肉球拍挠自己的脸。");
textmanager.addtext("……毫无疑问，这是现实。", "猫");
textmanager.addtext( "耷拉着耳朵，嘴里喃喃的吐出了这句不知道问过多少次的句子：");
textmanager.addtext("这到底是怎么回事啊……", "猫");
textmanager.addtext( "哦，终于醒过来了吗？");
textmanager.addtext( "一个女人的声音从我的头脑上方传了过来。");
textmanager.addtext( "我抬起头，看到了声音的主人。");
textmanager.addtext( "这个女人坐在我身后的那把华贵椅子上，优雅地翘着腿。不知为何，我看不清她的脸，但是明显感觉得出她在看着我笑。");
textmanager.addtext( "她身穿着我平时不常见到的洋装，留着一头灰金色的头发。很明显是来自远方的异国之人。");
textmanager.addtext("你……是谁？", "猫");
textmanager.addtext( "别着急。你还记得昨晚发生的事吗？","魔法师");
textmanager.addtext( "在她的提醒下，我瞬间想起了昨晚发生在自己身上的可怕的事情。");
textmanager.addtext("我……被一只黑色的长毛猫杀了。", "猫");
textmanager.addtext("还有呢？","魔法师");
textmanager.addtext("那时不知道为什么我动不了。", "猫");
textmanager.addtext("而且我确实应该死了……为什么我现在会在这里？那之后到底发生了什么？这……这到底是怎么回事？", "猫");
textmanager.addtext("是吗~你想知道到底发生了什么吗？", "魔法师");
textmanager.addtext("麻烦你告诉我这是怎么回事……", "猫");
textmanager.addtext( "女人模糊的脸上似乎（？）是卷起了玩味的笑容。她将手指抵在了我毛茸茸的额头上。");
textmanager.addtext( "一瞬间，无数的画面接连涌入了大脑——");
          nowtextnum += 1;
        textmanager.loadtext();
        uimanager.showui("textbox");
	}
    void showtext(int num)
    {
        textmanager.cleartext();
  
        if (num == 1)
        {
            textmanager.addtext("——浮现于屋顶的巨大而华丽的魔法阵。");
            textmanager.addtext("难以形容的颜色与光芒，绚丽而又带着一种神秘。");
            textmanager.addtext("在魔法阵的光辉之下，屋内的角落处摆放着许多燃烧正艳并且呈现奇异的蓝色火焰的蜡烛。");
            textmanager.addtext("漂浮于这二者的光芒之间的黑色小点……是一只猫。");
            textmanager.addtext("站在一旁的女人的口中似乎吟唱着什么，然后将手静静挥下……");
            
            textmanager.loadtext();
            uimanager.showui("textbox");
        }

        if (num == 2)
        {
            textmanager.addtext("这……！", "猫");
            textmanager.addtext("这简直就像是以前读过的童话书里写的“复活”啊！", "猫");
            textmanager.addtext("淹没在光芒之中的“猫”似乎就是现在的我。");
            textmanager.addtext("身旁正好有一块不大不小的立式镜，让我能看清自己现在的容貌。");
            textmanager.addtext("……果然是猫。", "猫");
textmanager.addtext("我将肉球拍在了自己的脸上。女人看着我，收回了自己的手指。");
textmanager.addtext("情况就是这样。你被艾达杀掉了，然后我发现了你，于是就把你带了回来。", "魔法师");
textmanager.addtext("等等等……", "猫");
textmanager.addtext("她似乎用轻松悠闲的语气陈述了什么不得了的事情。");
textmanager.addtext("你你你、你莫非是、是魔法师吗？？！", "猫");
textmanager.addtext("不用这么慌张，小黑猫。", "魔法师");
textmanager.addtext("我名叫梅莉恩。就像你所看到的那样，我确实是魔法师没错。", "魔法师");
textmanager.addtext("不管你相信与否，这都是事实。", "魔法师");
textmanager.addtext("你现在还能站在这里，就是最好的证明。", "魔法师");
textmanager.addtext("这个自称名叫做“梅莉恩”的女人的语气毋庸置疑是平静的，就像是在阐述普通的日常一样。");
textmanager.addtext("确实，我现在以猫的姿态站在这里，以及刚刚看到的画面，都是确确实实正在经历的“现实”。");
textmanager.addtext("魔法……原来真的存在的吗……", "猫");
textmanager.addtext("当然。你最好不要追根溯源，小黑猫。魔法可是个一言两语难以解释的东西。我只能告诉你，确实存在这个事实。", "魔法师");
textmanager.addtext("或许你以后会知道有关魔法的事情。但不是现在~", "魔法师");
textmanager.addtext("她又说了一次“事实”，然后再次伸出手指。只不过这次是弹了弹我的额头。");
textmanager.addtext("虽然感觉自己被敷衍过去了，但是慑于她身上散发出的不可思议的气场，我没有再追问有关魔法的事情。");
textmanager.addtext("毕竟，似乎真的是事实。再难以置信，也是真的。");
textmanager.addtext("艾达，是指昨晚那只黑猫吗？长长毛发的那只。", "猫");
textmanager.addtext("是的。", "魔法师");
textmanager.addtext("为什么你知道它的名字……说回来那只猫居然有名字？！还、还有，魔法又是什么？我是真的被复活了吗？这这这……", "猫");
textmanager.addtext("我的思绪非常混乱，以至于不知道该从什么地方开始问起。");
textmanager.addtext("按道理来说我应该先问的是为什么那只长毛的黑猫要杀我……但是一开口却是其他的问题。");
textmanager.addtext("我当然知道她的名字。因为这个名字就是我取的啊~", "魔法师");
textmanager.addtext("什……！", "猫");
textmanager.addtext("她就像是能看透我在想什么一样，将这个问题继续接了下去。");
textmanager.addtext("你是想问，为什么艾达要杀你吧？", "魔法师");
textmanager.addtext("是的……", "猫");
textmanager.addtext("关于这个问题，我只能告诉你，我也不知道~", "魔法师");
textmanager.addtext("这个回答有些出乎意料。我还以为这个看上去什么都知道的神秘女人能解答我所有的问题。");
textmanager.addtext("还有为什么看不清她的脸呢……明明没有遮盖什么东西。");
textmanager.addtext("那，能先告诉我昨晚那只长毛黑猫……艾达的事吗？", "猫");
textmanager.addtext("虽然不知道为什么要杀我，但总得先问清楚那只名叫艾达的猫的来历。");
textmanager.addtext("因为我并不记得自己什么时候有接触过黑色的长毛猫。自己在这个学校似乎也没有做过什么不好的事情。");
textmanager.addtext("但是一想到这只猫……不知道为什么头就开始疼了起来。");
textmanager.addtext("艾达是我的使魔。其实，她跟你一样，也是濒死之时被我带回来的孩子。", "魔法师");
textmanager.addtext("忘了是几年前了，总之那孩子那时不知经历了什么，肚破肠流地倒在草地中，于是我就把她带回来了。", "魔法师");
textmanager.addtext("这些年她一直跟在我身边。艾达是个很好的孩子呢~既不会惹事，性格也很温驯。", "魔法师");
textmanager.addtext("所以，在昨晚看到你的样子时候，我也很是惊讶呢~", "魔法师");
textmanager.addtext("……！！", "猫");
textmanager.addtext("不知为何，梅莉恩在提到“肚破肠流”这个词时，我的大脑又抽搐了起来。");
textmanager.addtext("那……那艾达现在在哪？", "猫");
textmanager.addtext("我也不知道。那个孩子在杀掉你之后，就再也没回来过。", "魔法师");
textmanager.addtext("我感觉得出，她应该是不会再回到我身边了。", "魔法师");
textmanager.addtext("不过，按照当时的契约内容，她是离不开这个学校的~", "魔法师");
textmanager.addtext("她的语气跟刚刚一样悠闲而且带着一丝玩味。从她的话中几乎听不出她对这件事以及艾达抱有担心或者其他的感情。");
textmanager.addtext("这种感觉很不妙……");
textmanager.addtext("虽然事情很复杂……但总之先谢谢你，梅莉恩小姐。", "猫");
textmanager.addtext("还有……你为什么要把我带回来呢？", "猫");
textmanager.addtext("总感觉不可能单纯只是出于好心。");
textmanager.addtext("啊~昨天晚上没有工作，所以闲着。而且……很有趣啊~", "魔法师");
textmanager.addtext("啊？？闲着？", "猫");
textmanager.addtext("我张大了自己的猫嘴巴。闲、闲着所以就出来了？");
textmanager.addtext("还有，她的最后一句话我没听清楚。");
textmanager.addtext("嘛~闲着只是理由之一。其实，", "魔法师");
textmanager.addtext("我想让你帮忙找一下艾达。", "魔法师");
textmanager.addtext("找她？", "猫");
textmanager.addtext("是的。那个孩子在离开之后使用不知道什么方法将自己的气息消去了许多。虽然我能感觉到那孩子还在这个学校里，但是似乎感觉不到具体的位置呢。", "魔法师");
textmanager.addtext("那个孩子现在的状态有些糟糕。她的身上有一股不太好的气息。", "魔法师");
textmanager.addtext("不太好的气息？", "猫");
textmanager.addtext("嗯……怎么说呢？像是内心的一部分感情变质了吧？那个孩子要是再这样下去，说不定会堕落成什么可怕的东西在学校内袭击生物呢~", "魔法师");
textmanager.addtext("梅莉恩用手指点了点自己的脸，歪了歪头，似乎很难形容艾达现在的状态。");
textmanager.addtext("所以呢，我希望你能把她找出来。反正你现在是一只猫，应该很容易吧~", "魔法师");
textmanager.addtext("……", "猫");
textmanager.addtext("……她不是为了找艾达才把我复活成猫的样子吧？");
textmanager.addtext("我有些犹豫与纠结。");
textmanager.addtext("我并不怎么擅长对付猫。也不知道该怎么去面对一只把我杀了的猫。");
textmanager.addtext("但是……");
textmanager.addtext("……", "猫");
textmanager.addtext("我似乎确实有想见她的想法。");
textmanager.addtext("虽然这样似乎有些奇怪。");
textmanager.addtext("但是想法似乎并不是复仇……也不能说没有这个意思，但总觉得不是这个意图。");
textmanager.addtext("或许只是想见见这只长毛猫，了解清楚她为什么会杀我？");
textmanager.addtext("虽然不知道可不可信……但在梅莉恩的口中，艾达是个温驯的猫咪。为什么这只温驯的猫咪会露出昨晚那副模样然后将我杀死呢？");
textmanager.addtext("而且……在思考这个问题的时候，不知为什么我的脑袋总是会开始抽搐起来，心也有些慌。");
textmanager.addtext("这很奇怪。");
textmanager.addtext("你会答应的吧？小黑猫？", "魔法师");
textmanager.addtext("毕竟是我救了你~帮帮这个小忙应该没问题吧？", "魔法师");
textmanager.addtext("这个仿佛能看穿我的一切的魔法师伸手挠了挠我的下巴，又补充了一句。");
textmanager.addtext("安全问题你不用担心~你是以我的使魔重生的，所以你遇到艾达时如果有危险的话，我就会出现。", "魔法师");
textmanager.addtext("我似乎无法拒绝……");
textmanager.addtext("好吧。我答应你。", "猫");
textmanager.addtext("最后还是答应了。");
textmanager.addtext("虽然谜团重重，但毕竟是搭救了自己的恩人。");
textmanager.addtext("谢谢了~小猫咪~", "魔法师");
textmanager.addtext("在我答应之后，梅莉恩似乎很开心，然后擅自将“小黑猫”这个称呼改成了“小猫咪”。她将我抱起，捏了捏我前爪上的肉垫。");
textmanager.addtext("说起来，小猫咪你还没有名字对吧？", "魔法师");
textmanager.addtext("我有身为人类的名字……", "猫");
textmanager.addtext("那可不行~你以及作为我的使魔重生了，自然不能用之前的名字~", "魔法师");
textmanager.addtext("艾达也是一样的哦~虽然她重生前本来就是猫~", "魔法师");
textmanager.addtext("虽然语气像是在开玩笑，但莫名其妙的魄力让我不敢反对……");
textmanager.addtext("说起来这个女人从刚见面的时候就给人这种感觉了。像是在玩什么娱乐游戏一样，总觉得有些可怕。");
textmanager.addtext("小猫咪，你还是人类时的爱好是？", "魔法师");
textmanager.addtext("读、读书……", "猫");
textmanager.addtext("诶……喜欢读哪个类型的书？", "魔法师");
textmanager.addtext("现代文学……还有德国文学以及诗剧……", "猫");
textmanager.addtext("我不知道她问这些有什么意义，只能战战兢兢地照实回答。");
textmanager.addtext("哦？那……", "魔法师");
textmanager.addtext("她似乎想到了什么。梅莉恩戳着我的鼻子，然后说道：");
textmanager.addtext("你就叫“浮士德”吧~", "魔法师");
textmanager.addtext("……为为为什么是歌德？", "猫");
textmanager.addtext("因为你说你喜欢德国文学啊~", "魔法师");
textmanager.addtext("就因为这种理由……", "猫");
textmanager.addtext("虽然嘴上这么说，但说实话……我还挺喜欢这个名字的。");
textmanager.addtext("就跟她说的一样，我确实喜欢德国文学，而且歌德尤甚，《浮士德》更是难得的经典。");
textmanager.addtext("有时候真的怀疑梅莉恩是不是真的能读透别人的心。");
textmanager.addtext("我要是浮士德的话，梅莉恩你岂不是成了恶魔梅菲斯特了……", "猫");
textmanager.addtext("魔法师说不定就是恶魔哦？", "魔法师");
textmanager.addtext("……", "猫");
textmanager.addtext("梅莉恩的话语中带着笑意。");
textmanager.addtext("而我却有点打寒颤。看来这个话题还是别继续下去为好。");
textmanager.addtext("有些不该问的事情还是少问哦，小猫咪~", "魔法师");
textmanager.addtext("你现在也清醒了吧？那么马上出去熟悉一下新的身体吧~", "魔法师");
textmanager.addtext("这所学校的体育馆的河对面是一座教学楼，这座教学楼旁边是雕塑室，似乎有一只年长一些的猫住在那儿。你可以先去找找他了解了解这所学校里猫群的情况哦~", "魔法师");
textmanager.addtext("就是一只黑白斑颜色的猫哦~记得身上的花纹像是穿了西装一样？而且腰部以下都是黑色的哦~", "魔法师");
textmanager.addtext("……我知道了。", "猫");
   textmanager.addtext(" 总之，现在的我，被赠与了“浮士德”之名，即将作为一只名叫“浮士德”的猫生活在这个校园里。");
textmanager.addtext("不管是梅莉恩的话语，还是那只名叫做艾达的猫，都像是雾中的一角一样，既模糊不清又充满着危险。");
textmanager.addtext("还有我自己……提起艾达过去的事情，为什么我会头疼？");
textmanager.addtext("我现在什么都不知道，像是被蒙在了鼓里一样。");
textmanager.addtext("……希望有一天能理清楚这一切。", "猫");
textmanager.addtext("毕竟，不管是浮士德，还是梅菲斯特，或者其他人，最后无一例外都会有一个了结。即使当下的时光再美妙，时间也不可能是永远停滞的。");
textmanager.addtext("为了解决这些谜团，我决定在此时踏出第一步。");
            textmanager.loadtext();
            uimanager.showui("textbox");
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (textmanager.boxIsEnd && nowtextnum == 1)
        {
            nowtextnum += 1;
          
            uimanager.showui(3);

            uimanager.showui("textbox");
            showtext(1);
            textmanager.boxIsEnd = false;
        }
        if (textmanager.boxIsEnd && nowtextnum == 2)
        {
          
            uimanager.closeui(3);
            nowtextnum += 1;
            showtext(2);
            textmanager.boxIsEnd = false;
        }

    
        if (textmanager.boxIsEnd && nowtextnum == 3)
        {
            uimanager.showui(4);
            uimanager.getui(4).GetComponent<Animator>().SetBool("blak", true);
          
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            uimanager.showui(1);
        }
	}
    void loadScene()
    {
        uimanager.showui(5);
    }
}
