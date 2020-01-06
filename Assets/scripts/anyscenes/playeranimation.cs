using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeranimation : MonoBehaviour {
 Animator ani;

	void Start () {
        ani = this.GetComponent<Animator>();
	}
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            ani.SetInteger("direction", 1);
            ani.SetBool("isstop", false);

        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {

            ani.SetInteger("direction", 3);
            ani.SetBool("isstop", false);
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ani.SetInteger("direction", 4);
            ani.SetBool("isstop", false);

        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {

            ani.SetInteger("direction", 2);
            ani.SetBool("isstop", false);
        }
        else if( Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow)||Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow)||Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow)||Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            ani.SetInteger("direction", 0);
            ani.SetBool("isstop", true);
        }

	}
}
