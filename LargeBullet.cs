using UnityEngine;
using System.Collections;

public class LargeBullet : Bullet {

	// Use this for initialization
	protected override void Start () {
		base.Start();
		speed = 0.5f;
	}
	
	// Update is called once per frame
	protected override void Update () {
		base.Update();
	}
}