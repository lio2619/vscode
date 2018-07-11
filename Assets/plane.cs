using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class plane : MonoBehaviour {

	// Use this for initialization
	public GameObject Bullet;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.RightArrow)){		//控制飛機向右
			gameObject.transform.position += new Vector3(0.1f,0,0);
		}

		if(Input.GetKey(KeyCode.LeftArrow)){		//控制飛機向左
			gameObject.transform.position += new Vector3(-0.1f,0,0);
		}

		if(Input.GetKey(KeyCode.UpArrow)){			//控制飛機向上
			gameObject.transform.position += new Vector3(0,0.1f,0);
		}

		if(Input.GetKey(KeyCode.DownArrow)){		//控制飛機向下
			gameObject.transform.position += new Vector3(0,-0.1f,0);
		}

		if(Input.GetKeyDown(KeyCode.Space)){		//子彈是否發出
			Vector3 pos = gameObject.transform.position + new Vector3(0,0.6f,0);
			Instantiate(Bullet,pos,gameObject.transform.rotation);
			/*Instantiate(物件,初始位置,初始角度) */
		}
	}
}
