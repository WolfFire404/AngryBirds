using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDraggingScript : MonoBehaviour
{

    private Vector2 screenPoint;
    private Vector2 offset;

    /*public float maxStretch = 3.0f;
    //public LineRenderer Katapult_achterkant;
    //public LineRenderer Katapult_voorkant;

    private SpringJoint2D spring;

    private void Awake()
    {
        spring = GetComponent<SpringJoint2D>();
    }

    // Use this for initialization
    void Start () {
        //joint = GetComponent<HingeJoint>();
    }
	
	// Update is called once per frame
	void Update () {
        //joint.breakForce = 10;
    }*/

    void OnMouseDown()
    {
        Debug.Log("I'm down");
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = (pos);
    }

}
