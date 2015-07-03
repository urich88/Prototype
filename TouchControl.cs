using UnityEngine;
using System.Collections;

/* Touch class than would be called in GM, this one ray casts
 * and if hit a collider it will send a message to the proper 
 * class needed in this case */

public class TouchControl : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
  //Despite the mouse, it accepts the touch input

	void Update () {

    //getting input
    if (Input.GetMouseButtonDown(0))
    {
      /*Check if the gameObject its clicked by casting a
       * ray from main camera to the touched position */
      Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
      RaycastHit hit;

      //Cast ray distance 100, check if collider is hit
      if(Physics.Raycast(ray, out hit, 100.0f))
      {
        //checks for tag to see if its player or cpu
        if(hit.collider.CompareTag("CPU1"))
        {
          //call routine
          Debug.Log("touchy");
        }
        if(hit.collider.CompareTag("CPU2"))
        {
          //call rutine
          Debug.Log("touchy2");
        }
        if(hit.collider.CompareTag("CPU3"))
        {
          //call routine
          Debug.Log("touchy3");
        }
        if(hit.collider.CompareTag("P1"))
        {
          //call routine
          Debug.Log("player");
        }
        if(hit.collider.CompareTag("P2"))
        {
          //call routine
          Debug.Log("player2");
        }
        if(hit.collider.CompareTag("P3"))
        {
          //call routine
          Debug.Log("player3");
        }
      }
    }
   
          //pedir el script de donde se sacara damage
     
      //poner la funcion de damage


    
	

}
 

}
