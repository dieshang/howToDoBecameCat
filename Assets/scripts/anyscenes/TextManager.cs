using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TextManager : MonoBehaviour {
List<string> text = new List<string>();
public bool boxIsEnd=false;
  public texbox box;
  public List<string> sayname=new List<string>();
	void Start () {
   
       
	}

    public void addtext(string t,string sayname1="")
    {
        text.Add(t);
        sayname.Add(sayname1);
    }
    public void cleartext()
    {
        text.Clear();
        sayname.Clear();
    }

    public void loadtext()
    {
        box.num = 0;
        box.text = text;
        box.isend = false;
        box.sayname = sayname;
    }
	void Update () {
        boxIsEnd = box.isend;
	}
}
