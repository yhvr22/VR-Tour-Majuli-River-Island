using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalloc : MonoBehaviour
{
    public GameObject global;
    public float start;
    public float end;
    public GameObject camera;
    public GameObject cross;

    void Update()
    {
        if(camera.transform.position.x>=start && camera.transform.position.x<=end && cross.GetComponent<SphereCollider>().enabled){
            GetComponent<SpriteRenderer>().enabled = true;
            Vector3 newPosition ;
            newPosition =  new Vector3(-0.07f,0.5f,1.6f);;
            global.transform.position = newPosition;
        }
        else{
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}

