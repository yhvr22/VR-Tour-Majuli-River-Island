using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SphereVisibility : MonoBehaviour
{
    private Camera mainCamera;
    private MeshRenderer sphereRenderer;

    private void Start()
    {
        mainCamera = Camera.main;
        sphereRenderer = GetComponent<MeshRenderer>(); 
    }

    private void Update()
    {
        //Debug.Log(Mathf.Abs(mainCamera.transform.position.x - transform.position.x));
        // Debug.Log(Mathf.Abs(transform.position.x));
        if (Mathf.Abs(mainCamera.transform.position.x - transform.position.x) < 5 && Mathf.Abs(mainCamera.transform.position.y - transform.position.y) < 5 )
        {
            sphereRenderer.enabled = true;
        }
        else
        {
            sphereRenderer.enabled = false;
        }
    }
}

