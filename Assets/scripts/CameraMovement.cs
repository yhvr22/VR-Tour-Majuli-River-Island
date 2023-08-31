// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;
// using System;
// using UnityEngine.UI;

// public class CameraMovement : MonoBehaviour
// {
//     public float speed = 0.01f;
    
    
//     public string sceneName ; 

   

//     private bool isMoving = false;
//     public RawImage guide;

//     void Start()
//     {
//         Scene currentScene = SceneManager.GetActiveScene();
//         string sceneName = currentScene.name;
//         Debug.Log("Current scene name is " + sceneName);
//     }

// 	// Update is called once per frame
// 	void Update () {
//         if (Input.GetMouseButtonDown(0)){
//             RectTransform guideRectTransform = guide.rectTransform;
//             Vector2 position = Input.mousePosition;
//             if (RectTransformUtility.RectangleContainsScreenPoint(guideRectTransform, position))
//             {
//                 StartMoving();
//             }
//         }

//         if(isMoving){
//             transform.Translate(Vector3.forward * speed * Time.deltaTime);
//         }
		    
//         if (Input.GetKey(KeyCode.UpArrow))
//         {
//             transform.position += transform.forward * speed * Time.deltaTime;
//         }
//         else if (Input.GetKey(KeyCode.DownArrow))
//         {
//             transform.position -= transform.forward * speed * Time.deltaTime;
//         }
//         else if (Input.GetKey(KeyCode.RightArrow))
//         {
//             transform.Rotate(0, 0.8f, 0, Space.World);
//         }
//         else if (Input.GetKey(KeyCode.LeftArrow))
//         {
//             transform.Rotate(0, -0.8f, 0, Space.World);
//         }
//     }

//     void StartMoving()
//     {
//         isMoving = true;
//     }
// }

using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float rotationSpeed = 0.1f;

    private bool isRotating = false;
    private Vector3 lastMousePosition;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetMouseButton(0))
        {
            if (!isRotating)
            {
                isRotating = true;
                lastMousePosition = Input.mousePosition;
            }
            else
            {
                Vector3 delta = Input.mousePosition - lastMousePosition;
                transform.RotateAround(transform.position, Vector3.up, delta.x * rotationSpeed);
                transform.RotateAround(transform.position, transform.right, -delta.y * rotationSpeed);
                lastMousePosition = Input.mousePosition;
            }
        }
        else
        {
            isRotating = false;
        }
    }
}


