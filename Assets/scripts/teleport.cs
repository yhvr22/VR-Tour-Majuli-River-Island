using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class teleport : MonoBehaviour
{

    public GameObject camera;
    public GameObject minimap;
    public GameObject tab;
    private float delay = 2f;
    public float strpos;
    public float endpos;

    public float targetposition;

    bool isPointerOver = false;

    private Vector3 taboriginalscale;
    private Vector3 originalposition;


    private void Start()
    {
        isPointerOver = false;
        taboriginalscale = tab.GetComponent<SpriteRenderer>().transform.localScale;
        originalposition = GetComponent<Transform>().position;
    }
    
    public void teleportnow(){
        isPointerOver = true;
        StartCoroutine(teleportAfterDelay());
    }

    private IEnumerator teleportAfterDelay(){
        yield return new WaitForSeconds(delay);
        if(isPointerOver){
            isPointerOver = false;
            Vector3 pos = camera.transform.position;
            pos.x = targetposition;
            Debug.Log(pos);
            camera.transform.position = pos;
            tab.GetComponent<SpriteRenderer>().transform.localScale = taboriginalscale;
            tab.GetComponent<SphereCollider>().enabled = false;
        }
    }

    public void pointerexit(){
        isPointerOver = false;
    }

    public void Update(){
        if(camera.transform.position.x >= strpos && camera.transform.position.x <= endpos && minimap.GetComponent<SphereCollider>().enabled){
            GetComponent<SphereCollider>().enabled = true;
            Vector3 pos = originalposition;
            pos.x += camera.GetComponent<Transform>().position.x;
            transform.position = pos;
        }
        else{
            GetComponent<SphereCollider>().enabled = false;
        }
    }
}
