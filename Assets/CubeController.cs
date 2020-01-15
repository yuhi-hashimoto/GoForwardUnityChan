using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	//キューブの移動速度
	private float speed = -12;

	//消滅位置
	private float deadline = -10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//キューブを移動させる
		transform.Translate (this.speed* Time.deltaTime, 0, 0);

		//画面外に出たら破棄する
		if (transform.position.x < this.deadline) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "ground" || coll.gameObject.tag == "cube") {
			GetComponent<AudioSource> ().Play ();
		}
	}
}
