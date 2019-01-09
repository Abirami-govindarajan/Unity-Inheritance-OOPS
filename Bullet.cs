using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	protected float speed;
	
	// Use this for initialization
	protected virtual void Start () {
		speed = 1;
	}
	
	// Update is called once per frame
	protected virtual void Update () {
		transform.Translate(0, speed * Time.deltaTime, 0);
	}
}