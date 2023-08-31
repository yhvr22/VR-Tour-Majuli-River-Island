using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class minimapscript : MonoBehaviour
{
    float delay = 2f;

    float mainmapxpos = -0.2f;
    float crossxpos = 0.366f;

    private bool isPointerOverminimap = false;
    private bool isPointerOvercross = false;

    private Coroutine mainmapCoroutine;
    private Coroutine backCoroutine;

    public GameObject localmap;
    public GameObject camera;
    public GameObject minimap;
    public GameObject mainmap;
    public SpriteRenderer cross;


    private SphereCollider minimapsphereCollider;
    // Start is called before the first frame update
    void Start()
    {
        minimapsphereCollider = GetComponent<SphereCollider>();
        
    }

    public void showmainmap(){
        isPointerOverminimap = true;
        mainmapCoroutine = StartCoroutine(mainmapAfterDelay()); 
        
    }

    private IEnumerator mainmapAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        if (isPointerOverminimap)
        {
            isPointerOverminimap = false;
            localmap.GetComponent<SpriteRenderer>().enabled = false;
            mainmap.GetComponent<SpriteRenderer>().enabled = true;
            minimap.GetComponent<SpriteRenderer>().enabled = false;
            cross.GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<SpriteRenderer>().enabled = false;

            Vector3 newPosition = mainmap.transform.position;
            newPosition.x = mainmapxpos + camera.transform.position.x;
            mainmap.transform.position = newPosition;



            cross.GetComponent<SphereCollider>().enabled = true;
            minimap.GetComponent<SphereCollider>().enabled = false;

        }
    }

    public void pointerexit(){
        isPointerOverminimap = false;
        isPointerOvercross = false;
    }

    public void backtolocalmap(){
        isPointerOvercross = true;
        Debug.Log("cross");
        backCoroutine = StartCoroutine(backAfterDelay()); 
        
    }

    private IEnumerator backAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        if (isPointerOvercross)
        {
            Debug.Log("cross");
            isPointerOvercross = false;
            localmap.GetComponent<SpriteRenderer>().enabled = true;
            minimap.GetComponent<SpriteRenderer>().enabled = true;
            mainmap.GetComponent<SpriteRenderer>().enabled = false;
            cross.GetComponent<SpriteRenderer>().enabled = false;

            

            cross.GetComponent<SphereCollider>().enabled = false;
            minimap.GetComponent<SphereCollider>().enabled = true;
        }
    }
}
