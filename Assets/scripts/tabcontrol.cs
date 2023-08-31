using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class tabcontrol : MonoBehaviour
{

   private bool isPointerOveropentab = false;
   private bool isPointerOverclosetab = false;
   private bool isPointerOverlocalmap = false;
   private bool isPointerOverminimap = false;

   float mainxpos;
   public GameObject camera;

 
   private bool enlarged = false;
   public float distanceFromCamera = 1f; // Distance from the camera that the sprite should be kept at

    public Transform spriteTransform; // Reference to the transform of the sprite
    public Camera mainCamera; 

    public Sprite minimapSprite;
    public Sprite localmapSprite;

    public GameObject tab;
    public GameObject open;
    public GameObject close;
    public GameObject localmap;
    public GameObject minimap;
    public GameObject tabobjects;
    public GameObject mainmap;
    public GameObject cross;

    private float delay = 1.5f;

    public Vector3 rotation = new Vector3(-1.56f, 2.5f, 0f);
    public Vector3 position = new Vector3(-0.0003357682f, 0.003123268f, 0.0769522f);
    public Vector3 p = new Vector3(-0.2372669f, 0.2316242f, 2.400872f);
    public Vector3 mainpositionafterenlarge = new Vector3(-0.43f,0.4f,2f);
    public Vector3 mainscaleafterenlarge = new Vector3(0.22f,0.25f,3.2f);
    


    private SphereCollider tabsphereCollider;
    private SphereCollider opentabsphereCollider;
    private SphereCollider closetabsphereCollider;
    private SphereCollider localmapsphereCollider;
    // private SphereCollider tabobjectssphereCollider;
    private SphereCollider minimapsphereCollider;
    private SphereCollider crosssphereCollider;


    private SpriteRenderer tabRenderer;
    private SpriteRenderer opentabRenderer;
    private SpriteRenderer closetabRenderer;
    private SpriteRenderer localmapRenderer;
    private SpriteRenderer tabobjectsRenderer;
    private SpriteRenderer minimapRenderer;
    private SpriteRenderer mainmapRenderer;
    private SpriteRenderer crossRenderer;

    private Coroutine opentabCoroutine;
    private Coroutine closetabCoroutine;
    private Coroutine enlargetabCoroutine;
    private Coroutine minimapCoroutine;

    private Vector3 tabposition;
    private Vector3 closetabposition;
    private Vector3 localmapposition;
    private Vector3 gameobjectsposition;
    private Vector3 minimapposition;

    private Vector3 taboriginalscale;
    private Vector3 closetaboriginalscale;
    private Vector3 localmaporiginalscale;
    private Vector3 minimaporiginalscale;

    private Transform opentabTransform;
    private Transform tabTransform;
    private Transform closetabTransform;
    private Transform localmapTransform;
    private Transform minimapTransform;




    private void Start()
    {
        // Get a reference to the SphereCollider component of the other sprite GameObject
        tabsphereCollider = tab.GetComponent<SphereCollider>();
        opentabsphereCollider = open.GetComponent<SphereCollider>();
        closetabsphereCollider = close.GetComponent<SphereCollider>();
        localmapsphereCollider = localmap.GetComponent<SphereCollider>();
        // tabobjectssphereCollider = tabobjects.GetComponent<SphereCollider>();
        minimapsphereCollider = minimap.GetComponent<SphereCollider>();
        crosssphereCollider = cross.GetComponent<SphereCollider>();

        
        tabRenderer = tab.GetComponent<SpriteRenderer>();
        opentabRenderer = open.GetComponent<SpriteRenderer>();
        closetabRenderer = close.GetComponent<SpriteRenderer>();
        localmapRenderer = localmap.GetComponent<SpriteRenderer>();
        minimapRenderer =  minimap.GetComponent<SpriteRenderer>();
        crossRenderer =  cross.GetComponent<SpriteRenderer>();
        mainmapRenderer =  mainmap.GetComponent<SpriteRenderer>();

        tabTransform = tab.GetComponent<Transform>();
        opentabTransform = open.GetComponent<Transform>();
        closetabTransform = close.GetComponent<Transform>();
        localmapTransform = localmap.GetComponent<Transform>();
        minimapTransform = minimap.GetComponent<Transform>();

        taboriginalscale = tabRenderer.transform.localScale;
        closetaboriginalscale = closetabRenderer.transform.localScale;
        localmaporiginalscale = localmapRenderer.transform.localScale;
        minimaporiginalscale = minimapRenderer.transform.localScale;

        tabposition = tabRenderer.transform.position;
        closetabposition = closetabRenderer.transform.position;
        localmapposition = localmapRenderer.transform.position;
        minimapposition = minimapRenderer.transform.position;

    }

   

    public void openthetab(){
        isPointerOveropentab = true;
        opentabCoroutine = StartCoroutine(openAfterDelay());
    }

    private IEnumerator openAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        if (isPointerOveropentab)
        {
            Debug.Log("open");
            tabsphereCollider.enabled = false;
            closetabsphereCollider.enabled = true;
            opentabsphereCollider.enabled = false;
            localmapsphereCollider.enabled = true;
            // tabobjectssphereCollider.enabled = false;
            minimapsphereCollider.enabled = false;

            tabRenderer.enabled = true;
            opentabRenderer.enabled = false;
            closetabRenderer.enabled = true;
            localmapRenderer.enabled = true;
            minimapRenderer.enabled = false;

            isPointerOveropentab = false;
            isPointerOverclosetab = false;
            isPointerOverlocalmap = false;
            isPointerOverminimap = false;


        }
    }

    public void pointerexit(){
        isPointerOveropentab = false;
        isPointerOverclosetab = false;
        isPointerOverlocalmap = false;
        isPointerOverminimap = false;
    }

    public void closethetab(){
        isPointerOverclosetab = true;
        closetabCoroutine = StartCoroutine(closeAfterDelay());   
    }

    private IEnumerator closeAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        if (isPointerOverclosetab)
        {
            Debug.Log("close");

            tabsphereCollider.enabled = false;
            closetabsphereCollider.enabled = false;
            opentabsphereCollider.enabled = true;
            localmapsphereCollider.enabled = false;
            // tabobjectssphereCollider.enabled = false;
            minimapsphereCollider.enabled = false;

            localmapRenderer.sprite = localmapSprite;

            tabRenderer.enabled = false;
            opentabRenderer.enabled = true;
            closetabRenderer.enabled = false;
            localmapRenderer.enabled = false;
            minimapRenderer.enabled = false;
            enlarged = false;

            localmap.GetComponent<SpriteRenderer>().enabled = false;
            mainmap.GetComponent<SpriteRenderer>().enabled = false;
            cross.GetComponent<SpriteRenderer>().enabled = false;
            cross.GetComponent<SphereCollider>().enabled = false;
            
            

            tabRenderer.transform.localScale = taboriginalscale ;
            closetabRenderer.transform.localScale =  closetaboriginalscale;
            localmapRenderer.transform.localScale = localmaporiginalscale;


            Vector3 newPosition = tabposition;
            newPosition.y += camera.transform.position.y;
            tabRenderer.transform.position = newPosition ;

            newPosition = closetabposition;
            newPosition.y += camera.transform.position.y;
            closetabRenderer.transform.position =  newPosition;

            newPosition = localmapposition;
            newPosition.y += camera.transform.position.y;
            localmapRenderer.transform.position = newPosition;

            
            isPointerOveropentab = false;
            isPointerOverclosetab = false;
            isPointerOverlocalmap = false;
            isPointerOverminimap = false;

        }
    }

    public void enlarge()
    {
            isPointerOverlocalmap = true;
            enlargetabCoroutine = StartCoroutine(enlargeAfterDelay());
    }



    private IEnumerator enlargeAfterDelay(){
        yield return new WaitForSeconds(delay);
        if (isPointerOverlocalmap && tabRenderer.transform.localScale.z!=3)
        {
            Debug.Log("enlarge");

            Camera.main.transform.rotation = Quaternion.Euler(rotation);
            Camera.main.transform.position = position;

            tabRenderer.enabled = true;
            opentabRenderer.enabled = false;
            closetabRenderer.enabled = true;
            localmapRenderer.enabled = true;
            minimapRenderer.enabled = true;



            tabsphereCollider.enabled = false;
            closetabsphereCollider.enabled = true;
            opentabsphereCollider.enabled = false;
            localmapsphereCollider.enabled = false;
            // tabobjectssphereCollider.enabled = false;
            minimapsphereCollider.enabled = true;
          
            enlarged = true;  
          
            tabRenderer.transform.localScale *= 3f; 
            //Vector3 newScale = new Vector3(0.28f,0.29f,3.2f)

            localmapRenderer.transform.localScale *= 3.2f; 
            closetabRenderer.transform.localScale *= 2f; 


            tabRenderer.transform.rotation = Quaternion.identity;
            closetabRenderer.transform.rotation = Quaternion.identity;
            localmapRenderer.transform.rotation = Quaternion.identity;
            minimapRenderer.transform.rotation = Quaternion.identity;

            mainxpos = camera.transform.position.x;

            Vector3 newPosition = p;
            newPosition.z = 2f;
            newPosition.y = 0f;
            newPosition.x += mainxpos;
            Debug.Log(mainxpos);
            tabRenderer.transform.position = newPosition;

            newPosition = p;
            newPosition.z = 2f;
            newPosition.y = camera.transform.position.y + -0.85f;
            newPosition.x += mainxpos;
            //newPosition.x += 20f;
            closetabRenderer.transform.position = newPosition;

            newPosition = p;
            newPosition.z = 2f;
            newPosition.y = camera.transform.position.y + 0.2f;
            newPosition.x += mainxpos;
            localmapRenderer.transform.position = newPosition;

            //newPosition = minimap.transform.position;
            newPosition = minimapposition;
            newPosition.x += mainxpos;

            minimap.transform.position = newPosition;


            isPointerOveropentab = false;
            isPointerOverclosetab = false;
            isPointerOverlocalmap = false;
            isPointerOverminimap = false;

        }
    }


    private void LateUpdate()
    {
        // Calculate the target position for the sprite
        if(tabRenderer.transform.localScale.z<3){
             
            Vector3 targetPosition = mainCamera.transform.position + mainCamera.transform.forward * distanceFromCamera;

            // Keep the y-position of the sprite the same as its current y-position
            // float y = targetPosition.y;
            // targetPosition.y = camera.transform.position.y +  -0.4683758f;
            // open.transform.position = targetPosition;

            // targetPosition.y = camera.transform.position.y + -0.0113758f;
            // close.transform.position = targetPosition;

            // targetPosition.y = camera.transform.position.y + -0.3883758f;
            // localmap.transform.position = targetPosition;

            // targetPosition.y = camera.transform.position.y + 0.588f;
            // minimap.transform.position = targetPosition;

            // targetPosition.y = camera.transform.position.y + 0.45f;
            // mainmap.transform.position = targetPosition;

            // targetPosition.y = camera.transform.position.y + -0.4683758f;
            // tab.transform.position = targetPosition;





            targetPosition.y =spriteTransform.position.y;            


            // Set the sprite's position to the target position
            spriteTransform.position = targetPosition;

            // targetPosition.y  = camera.transform.position.y + -0.4683758f; 
            // Debug.Log(camera.transform.position.y );
            // open.transform.position = targetPosition;

            //targetPosition.y  = mainCamera.transform.position.y + -0.4683758f; 
            

            // Make the sprite face the camera, while keeping its orientation intact
            spriteTransform.LookAt(mainCamera.transform.position, Vector3.up);
            spriteTransform.Rotate(0, 180, 0); // Rotate the sprite 180 degrees around the y-axis to face the camera


            if(minimapRenderer.enabled || crossRenderer.enabled){
                tabRenderer.transform.localScale = taboriginalscale ;
                closetabRenderer.transform.localScale =  closetaboriginalscale;
                localmapRenderer.transform.localScale = localmaporiginalscale;

                tabRenderer.transform.position = tabposition ;
                closetabRenderer.transform.position =  closetabposition;
                localmapRenderer.transform.position = localmapposition;
                opentabRenderer.enabled = true;

                tabsphereCollider.enabled = false;
                closetabsphereCollider.enabled = false;
                opentabsphereCollider.enabled = true;
                localmapsphereCollider.enabled = false;
                // tabobjectssphereCollider.enabled = false;
                minimapsphereCollider.enabled = false;
                crosssphereCollider.enabled = false;

                tabRenderer.enabled = false;
                opentabRenderer.enabled = true;
                closetabRenderer.enabled = false;
                localmapRenderer.enabled = false;
                minimapRenderer.enabled = false;
                mainmapRenderer.enabled = false;
                crossRenderer.enabled = false;
            }
        }
       
    }
}
