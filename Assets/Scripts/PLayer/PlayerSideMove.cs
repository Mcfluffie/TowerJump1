using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSideMove : MonoBehaviour
{
    private bool dirRight = true;
    private bool dirLeft = false;
    private bool lookR = true;
    private bool lookL = false;
    public float speed = 2.0f;
    public float moveposL = 4f;
    public float moveposR = -4f;

    public float range = 5f;
    public GameObject player;

 

    public void Start()
    {
        
    }


    void Update()
    {
        // this ray cast function is for the right and is responsable for casting out a ray, looking for any object in its way 
        Vector3 direction = Vector3.right;
        Ray theRay = new Ray(transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(transform.position, transform.TransformDirection(direction * range));

        // this raycast draw function is for the left 
        Vector3 Ldirection = Vector3.left;
        Ray theRayL = new Ray(transform.position, transform.TransformDirection(Ldirection * range));
        Debug.DrawRay(transform.position, transform.TransformDirection(Ldirection * range));

        // the function for the players move left and right, this is adding a forced to the object multiplied by speed and updeated every frame 
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (dirLeft)
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (lookR)
            player.transform.rotation = Quaternion.Euler(0, 180, 0);
        if (lookL)
            player.transform.rotation = Quaternion.Euler(0, 0, 0);

        // left movement, this makes the player move left until the moveposL float is hit, once player hits that float the dirright function is called true and dirleft is called false, 
        //the else if raycast function is looking out for the ground tag and should the raycast hit the edge of ground it will bounce the player off giving them a little jump boost 
        if (transform.position.x >= moveposL)
        {
            dirRight = false;
            dirLeft = true;
            
            
        }
        else
        {
            if (Physics.Raycast(theRay, out RaycastHit hit, range))
            {
                if (hit.collider.tag == "Ground")
                {
                    Debug.Log("Turning");
                    dirRight = false;
                    dirLeft = true;
                    lookR = false;
                    lookL = true;
                  
                }
            }
        }
    
     
        // the right is same as the left, however raycast is set different is casted out to left instead of right allowing player to detect both sides and move accordingly 
        if (transform.position.x <= moveposR)
        {
            dirRight = true;
            dirLeft = false;
           
        }
        else
        {
            if (Physics.Raycast(theRayL, out RaycastHit hit, range))
            {
                if (hit.collider.tag == "Ground")
                {
                    Debug.Log("Turning");
                    dirRight = true;
                    dirLeft = false;
                    lookR = true;
                    lookL = false;
                   
                }
            }
        }
    }

    


}






















/*
        Vector3 heading = GameObject.transform.right;

        Ray theRay = new Ray(transform.position, transform.TransformDirection(heading * range));
        if(Physics.Raycast(theRay, out RaycastHit hit, range))
        {
            if (hit.collider.tag == "Ground")
            {
                heading *= -1;
            }
        }
        transform.Translate(heading * speed * Time.deltaTime);
*/

/*      Wall check as function for both directions

        WallCheck(gameObject.transform.right);
        WallCheck(-gameObject.transform.right);
        transform.Translate(heading * speed * Time.deltaTime);
        
void WallCheck(Vector3 heading){
        Ray theRay = new Ray(transform.position, transform.TransformDirection(heading * range));
        if(Physics.Raycast(theRay, out RaycastHit hit, range))
        {
            if (hit.collider.tag == "Ground")
            {
                heading *= -1;
            }
        }
}*/

