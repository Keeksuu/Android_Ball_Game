using UnityEngine;
using System.Collections;

public class CameraFollowChar : MonoBehaviour {
	public Transform player;
	public Vector3 offset;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.position.x + offset.x, player.position.y + offset.y, offset.z); // Camera follows the player with specified offset position
	}
}
