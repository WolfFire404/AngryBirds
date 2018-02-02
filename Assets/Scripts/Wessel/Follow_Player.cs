using UnityEngine;
using System.Collections;

public class Follow_Player : MonoBehaviour {

	public GameObject player;       
	private GameObject camera;
	private Rigidbody rb;

	private Vector3 offset;         

	void Start () 
	{
		camera = Camera.main.gameObject;
		offset = transform.position - player.transform.position;

	}


	void LateUpdate () 
	{
		

		transform.position = player.transform.position + offset;
	}
}