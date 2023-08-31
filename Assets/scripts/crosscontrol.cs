using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosscontrol : MonoBehaviour
{
    public GameObject camera;

    // Update is called once per frame
    void Update()
    {
            Vector3 newPosition = new Vector3(0.966f,0.673f,1.5f);
            newPosition.x += camera.transform.position.x;
            transform.position = newPosition;
            //Debug.Log(cross.transform.position);
    }
}
