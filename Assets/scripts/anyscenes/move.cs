using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public Transform xu;
    public int speed = 10;
    public float xmin=9999;
    public float xmax=9999;
    public float ymin=9999;
    public float ymax=9999;
	// Use this for initialization
	void Start () {
		
	}
	
	
	void Update () {
		  float xm = 0, ym = 0;
          if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
           
            ym += speed * Time.deltaTime;
          
        }
        else if (Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.DownArrow))
        {
          
            ym -= speed * Time.deltaTime;
          
        }

          if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
           
            xm -= speed * Time.deltaTime;
           
        }
          else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
          
            xm += speed * Time.deltaTime;
           
        }
     
        //防越界
        xu.Translate(new Vector2(xm, ym), Space.Self);

        if (xu.position.x > xmin && xu.position.x < xmax && xu.position.y > ymin && xu.position.y < ymax) {
            this.transform.Translate(new Vector2(xm, ym), Space.Self);
        }
        xu.position = this.transform.position;
        
	}
	
}
