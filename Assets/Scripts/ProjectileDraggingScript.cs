using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDraggingScript : MonoBehaviour
{
    private bool Clicked;

    private void Start()
    {
        Clicked = false;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("I'm down");
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = (pos);
            Clicked = true;
        }
        else if (Clicked)
        {
            Debug.Log("I'm up");
            GetComponent<SpringJoint2D>().enabled = false;
        }
    }

}
