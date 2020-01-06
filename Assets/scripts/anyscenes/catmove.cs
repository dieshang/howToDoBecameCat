using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catmove : MonoBehaviour {
    public int speed=10;
    Animator ani;
	// Use this for initialization
	void Start () {
        ani = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float xm = 0, ym = 0;
        if (Input.GetKey(KeyCode.W))
        {
            ym += speed * Time.deltaTime;
            ani.Play("walk_up");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            ym -= speed * Time.deltaTime;
            ani.Play("walk_down");
        }

        if (Input.GetKey(KeyCode.A))
        {
            xm -= speed * Time.deltaTime;
            ani.Play("walk_left");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            xm += speed * Time.deltaTime;
            ani.Play("walk_right");
        }

        this.transform.Translate(new Vector2(xm, ym), Space.Self);
	}
}
