using UnityEngine;
using System.Collections;

public class SmallBullet : Bullet {

	// Use this for initialization
	protected override void Start () {
		base.Start();
		speed = 2;
	}
	
	// Update is called once per frame
	protected override void Update () {
		base.Update();
	}
}