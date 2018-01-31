using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDraggingScript : MonoBehaviour
{
    private bool Clicked;
    public bool BeenShot;
    private bool IsSelected;
    public bool freezeRotation;

    private void Start()
    {
        Clicked = false;
        BeenShot = false;
        IsSelected = false;
    }

    void Update()
    {
        if (!IsSelected)
        {
            if (!BeenShot)
            {
                if (Input.GetMouseButton(0))
                {
                    Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    transform.position = (pos);
                    Clicked = true;
                }
                else if (Clicked)
                {
                    GetComponent<SpringJoint2D>().enabled = false;
                    Clicked = false;
                    BeenShot = true;
                }
            }
            else
            {
                //UnFreeze rigidbody rotation

            }
        }
    }
}
