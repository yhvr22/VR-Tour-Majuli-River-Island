using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrawcontrol : MonoBehaviour
{
    public GameObject front ;
    public GameObject back ;
    public GameObject left ;
    public GameObject right ;

    public GameObject tab;

    float delay = 3f;


    public GameObject camera;

    private bool isPointerOver = false;


    public void gazed()
    {
        isPointerOver = true;
        StartCoroutine(ChangeColorAfterDelay());
    }

    public void ungazed()
    {
        isPointerOver = false;
    }

    private IEnumerator ChangeColorAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        if (isPointerOver)
        {
            Debug.Log("front");
            isPointerOver = false;
            Vector3 currentPosition = camera.transform.position;
            if(transform.position.z>1f){
                if(camera.transform.position.x == 400f){
                    currentPosition.x += 100f;
                }
                else{
                    currentPosition.x += 20f;
                }
            }
            else if(transform.position.z < -1.5f){
                currentPosition.x -= 20f;
            }  
            else if((camera.transform.position.x > transform.position.x)){
                currentPosition.y += 20f;
            }
            else{
                currentPosition.y -= 20f;
            }
            camera.transform.position = currentPosition;

            // targetPosition.y = spriteTransform.position.y;
        }
    }


    void Update()
    {
        float x = camera.transform.position.x;
        float y = camera.transform.position.y;
        Vector3 newPosition;
        Vector3 newRotation;
        if(x==0){
            newPosition = new Vector3(0.041f,-0.372f,3.0011f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;
                
            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled = true;
            }

            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            back.GetComponent<SpriteRenderer>().enabled = false;
            back.GetComponent<SphereCollider>().enabled = false;
        }
        if(x==20f){
            newPosition = new Vector3(20.5f,-0.482f,3.005f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
                back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled= true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }

            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;


            newPosition = new Vector3(19.544f,-0.45f,-3.174f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        if(x==40f){
            newPosition = new Vector3(40.5f,-0.482f,3.005f);
            front.transform.position = newPosition;
            newRotation = new Vector3(-30f,0f,0f);
            //front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
                back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled= true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }

            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;


            newPosition = new Vector3(39f,-0.45f,-3.174f);
            back.transform.position = newPosition;
            newRotation = new Vector3(-30f,0f,0f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        if(x==60f){
            newPosition = new Vector3(59.7f,-0.482f,3.005f);
            front.transform.position = newPosition;
            newRotation = new Vector3(-30f,0f,0f);
            //front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
                back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled= true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }

            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;


            newPosition = new Vector3(60.5f,-0.45f,-3.174f);
            back.transform.position = newPosition;
            newRotation = new Vector3(-30f,0f,0f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }

        if(x==80f){
            newPosition = new Vector3(80.5f,-0.482f,3.005f);
            front.transform.position = newPosition;
            newRotation = new Vector3(-30f,0f,0f);
            //front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
                back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled= true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }

            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;


            newPosition = new Vector3(79.8f,-0.45f,-3.174f);
            back.transform.position = newPosition;
            newRotation = new Vector3(-30f,0f,0f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }

        if(x==100f){
            newPosition = new Vector3(100.5f,-0.482f,3.005f);
            front.transform.position = newPosition;
            newRotation = new Vector3(-30f,0f,0f);
            //front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
                back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled= true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }

            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(100.2f,-0.45f,-3.174f);
            back.transform.position = newPosition;
            newRotation = new Vector3(-30f,0f,-4f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }

        if(x==120f && y==0f){
            newPosition = new Vector3(119.9f,-0.8f,3.005f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;


                left.GetComponent<SpriteRenderer>().enabled = false;
                left.GetComponent<SphereCollider>().enabled = false;

                right.GetComponent<SpriteRenderer>().enabled = false;
                right.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled= true;

                left.GetComponent<SpriteRenderer>().enabled = true;
                left.GetComponent<SphereCollider>().enabled = true;

                right.GetComponent<SpriteRenderer>().enabled = true;
                right.GetComponent<SphereCollider>().enabled = true;
            }

            back.GetComponent<SpriteRenderer>().enabled = false;
            back.GetComponent<SphereCollider>().enabled = false;


            newPosition = new Vector3(117.22f,-0.409f,-0.647f);
            left.transform.position = newPosition;
            newRotation = new Vector3(-45.536f,63.706f,9.203f);
            left.transform.rotation = Quaternion.Euler(newRotation);

            newPosition = new Vector3(122.16f,-0.401f,-0.63f);
            right.transform.position = newPosition;
            newRotation = new Vector3(64.888f,86.296f,-12.79f);
            right.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==120f){
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                if(y==20f){
                    right.GetComponent<SpriteRenderer>().enabled = false;
                    right.GetComponent<SphereCollider>().enabled = false;
                }
                else{
                    left.GetComponent<SpriteRenderer>().enabled = false;
                    left.GetComponent<SphereCollider>().enabled = false;
                }
            }
            else{
                if(y==20f){
                    right.GetComponent<SpriteRenderer>().enabled = true;
                    right.GetComponent<SphereCollider>().enabled = true;
                }
                else{
                    left.GetComponent<SpriteRenderer>().enabled = true;
                    left.GetComponent<SphereCollider>().enabled = true;
                }
            }

            back.GetComponent<SpriteRenderer>().enabled = false;
            back.GetComponent<SphereCollider>().enabled = false;

            front.GetComponent<SpriteRenderer>().enabled = false;
            front.GetComponent<SphereCollider>().enabled = false;

            if(y==20f){
                left.GetComponent<SpriteRenderer>().enabled = false;
                left.GetComponent<SphereCollider>().enabled = false;

                newPosition = new Vector3(122.16f,19.401f,-1f);
                right.transform.position = newPosition;
                newRotation = new Vector3(64.888f,86.296f,-12.79f);
                right.transform.rotation = Quaternion.Euler(newRotation);
            }
            else{
                right.GetComponent<SpriteRenderer>().enabled = false;
                right.GetComponent<SphereCollider>().enabled = false;

                newPosition = new Vector3(117f,-21f,0f);
                left.transform.position = newPosition;
                newRotation = new Vector3(-45.536f,63.706f,9.203f);
                left.transform.rotation = Quaternion.Euler(newRotation);
                
            }



            newPosition = new Vector3(122.16f,19.401f,-1f);
            right.transform.position = newPosition;
            newRotation = new Vector3(64.888f,86.296f,-12.79f);
            right.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==140f){
            newPosition = new Vector3(140.5f,-0.8f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
                back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled= true;

                
                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }


            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(139.6f,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,-4f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==160f){
            newPosition = new Vector3(160.2f,-0.8f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
                back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled= true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }


            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(160.2f,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,-4f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==180f){
            newPosition = new Vector3(181f,-0.8f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
                back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled= true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }

            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(179.5f,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,-4f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==200f){
            newPosition = new Vector3(200.7f,-0.8f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
                back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled= true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }


            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(199.7f,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,-4f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==220f){
            newPosition = new Vector3(220.1f,-0.8f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
                back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled= true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }


            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(220f,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,-4f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==240f){
            newPosition = new Vector3(240.9f,-0.8f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
               back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled= true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }

       

            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(239.5f,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,-4f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==260f){
            newPosition = new Vector3(260.7f,-0.8f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                
            back.GetComponent<SpriteRenderer>().enabled = false;
            back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled= true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }

   

            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(259.8f,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,-4f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==280f){
            newPosition = new Vector3(280.7f,-0.8f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                
            back.GetComponent<SpriteRenderer>().enabled = false;
            back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled= true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }


            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(279.9f,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,-4f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==300f){
            newPosition = new Vector3(299.5f,-0.8f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                
            back.GetComponent<SpriteRenderer>().enabled = false;
            back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled= true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }



            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(299f,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,-4f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==320f){
            newPosition = new Vector3(320.2f,-0.8f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                
            back.GetComponent<SpriteRenderer>().enabled = false;
            back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled= true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }


            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(321f,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,25f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==340f){
            newPosition = new Vector3(340f,-0.8f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled= true;
            }


            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            back.GetComponent<SpriteRenderer>().enabled = false;
            back.GetComponent<SphereCollider>().enabled = false;

         
        }
        else if(x==360f){
            newPosition = new Vector3(359f,-0.8f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
                back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled = true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }


            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(361f,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,0f,0f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==380f){
            newPosition = new Vector3(380f,-0.8f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
                back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled = true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }


            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(381.5f,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,0f,0f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==400f){
            newPosition = new Vector3(399f,-0.7f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
                back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled = true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }


            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(401f,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,0f,0f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==400f){
            newPosition = new Vector3(399f,-0.7f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
                back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled = true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }


            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(401f,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,0f,0f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==420f){
            newPosition = new Vector3(421f,-0.7f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,-15f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
                back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled = true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }


            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(421f,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,0f,25f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==440f){
            newPosition = new Vector3(438f,-0.7f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,0f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
                back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled = true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }


            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(439f,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,0f,30f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==460f){
            newPosition = new Vector3(458f,-0.7f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,172f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
                back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled = true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }


            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(460f,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,0f,0f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x==480f){
            newPosition = new Vector3(480f,-0.7f,3.5f);
            front.transform.position = newPosition;
            newRotation = new Vector3(0f,0f,0f);
            front.transform.rotation = Quaternion.Euler(newRotation);
            if(tab.GetComponent<SpriteRenderer>().transform.localScale.z==3){
                front.GetComponent<SpriteRenderer>().enabled = false;
                front.GetComponent<SphereCollider>().enabled = false;

                back.GetComponent<SpriteRenderer>().enabled = false;
                back.GetComponent<SphereCollider>().enabled = false;

            }
            else{
                front.GetComponent<SpriteRenderer>().enabled = true;
                front.GetComponent<SphereCollider>().enabled = true;

                back.GetComponent<SpriteRenderer>().enabled = true;
                back.GetComponent<SphereCollider>().enabled = true;
            }


            left.GetComponent<SpriteRenderer>().enabled = false;
            left.GetComponent<SphereCollider>().enabled = false;

            right.GetComponent<SpriteRenderer>().enabled = false;
            right.GetComponent<SphereCollider>().enabled = false;

            newPosition = new Vector3(481f,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newRotation = new Vector3(0f,0f,0f);
            back.transform.rotation = Quaternion.Euler(newRotation);
        }
        else if(x>500f){
            newPosition = new Vector3(x,-0.5f,-2.5f);
            back.transform.position = newPosition;
            newPosition = new Vector3(x,-0.7f,3.5f);
            front.transform.position = newPosition;
            

        }
    }
}
