using UnityEngine;
using System.Collections;

public class Follow_Player : MonoBehaviour {

    public GameObject Sphere;     //Public variable to store a reference to the player game object

	private Vector3 offset;         //Private variable to store the offset distance between the player and camera


    ProjectileDraggingScript projectiledraggingscript;

    bool DragStatus
    {
        get { return PROJECTILEDRAGGINGSCRIPT.BeenShot; }
        set { PROJECTILEDRAGGINGSCRIPT.BeenShot = value; }
    }

    public ProjectileDraggingScript PROJECTILEDRAGGINGSCRIPT
    {
        get { return projectiledraggingscript ?? (projectiledraggingscript = GetComponent<ProjectileDraggingScript>()); }
    }

    // Use this for initialization
    void Start () 
	{
        offset = transform.position - Sphere.transform.position;
        projectiledraggingscript = GameObject.FindGameObjectWithTag("Player").GetComponent<ProjectileDraggingScript>();
    }

	// LateUpdate is called after Update each frame
	void Update () 
	{
            //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        if(projectiledraggingscript.BeenShot)
        {
           // Debug.Log("Oh Fuck Off");
            transform.position = Sphere.transform.position + offset;
        }
            
    }
}