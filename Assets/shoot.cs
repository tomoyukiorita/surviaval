using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
	public GameObject bullet;
	GameObject bulletClone;

	// 武器の先端
	public Transform tip;

	// 弾速
	public float speed = 5000;

	// 連射時設定
	private float time = 0f;
	public float interval = 0.3f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		time += Time.deltaTime;

		// 左クリック押下かつ設定した連射間隔より経過時間が大きければ発射可能
		if (Input .GetButton("Fire1") && time >= interval)
		{
			Shoot();
			time = 0f;

	}
	
	}

	void Shoot()
	{
		// 弾の角度位置を設定し、弾を生成する
		bulletClone = GameObject.Instantiate(bullet, tip.position, tip.rotation)as GameObject ;
		bulletClone.GetComponent< Rigidbody>().AddForce(tip.forward * speed);
	}


}
