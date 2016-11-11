using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	System.TimeSpan ts;

	// Use this for initialization
	void Start () {
		ts = new System.TimeSpan(1,1,2,3,0);
	}

	// Update is called once per frame
	void Update () {

		ts -= new System.TimeSpan(0,0,0,0,1000);

		Debug.Log( ts.ToString() );
		GetComponent<Text> ().text = ts.ToString();
	}
}
