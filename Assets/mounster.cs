using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mounster : MonoBehaviour {

	// Use this for initialization

	public GameObject explo;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += new Vector3(0,-0.1f,0);
	}

	void OnTriggerEnter2D(Collider2D col)		
	{
		if(col.tag == "Bullet" || col.tag == "plane"){
			Destroy(col.gameObject);		//如果子彈或飛機本身碰到怪物就讓雙方不見
			Destroy(gameObject);

			Instantiate(explo,transform.position,transform.rotation);
			if(col.tag == "plane"){			//如果怪物碰到飛機就結束
				Instantiate(explo,col.gameObject.transform.position,col.gameObject.transform.rotation);
				gamefunction.Instance.GameOver();
			}

			gamefunction.Instance.AddScore();
		}
	}
}
