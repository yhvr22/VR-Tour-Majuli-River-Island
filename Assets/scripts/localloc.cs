using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class localloc : MonoBehaviour
{
    public GameObject local;
    public GameObject camera;
    public GameObject minimap;

    public float localposition;
    // Update is called once per frame
    void Update()
    {
        if(camera.transform.position.x==localposition && minimap.GetComponent<SphereCollider>().enabled){
            GetComponent<SpriteRenderer>().enabled = true;
            float temp = camera.transform.position.x;
            Vector3 newPosition ;
            if(temp==0f){
                newPosition =  new Vector3(-0.89f,0f,1.6f);;
                local.transform.position = newPosition;
                
            }
            else if(temp==20f){
                newPosition =  new Vector3(19.385f,0.01f,1.6f);;
                local.transform.position = newPosition;
            }
        }
        else{
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
