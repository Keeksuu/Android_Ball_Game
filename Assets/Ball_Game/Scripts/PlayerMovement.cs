using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 1f;

	void Start () {
	}
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.D))
			transform.position  += new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
		if (Input.GetKey (KeyCode.A))
			transform.position -= new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);	
	}		
}