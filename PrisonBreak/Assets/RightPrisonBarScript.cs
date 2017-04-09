using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RightPrisonBarScript : MonoBehaviour {
	
	public Image bars_2;
	public Transform target;
	public float speed;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		//target.position = new Vector3(141, 100, 0);
		bars_2.transform.position = Vector3.MoveTowards(bars_2.transform.position, target.position, step);
	}
}
