using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTargeter : MonoBehaviour
{
    
     // Whatever is your max distance (remove if not needed). However, it is nice to have a max distance to which your monster can see the player.
    float maxDistance = 4;

 
     void FixedUpdate()
     {
 
         // Will contain the information of which object the raycast hit
        RaycastHit hit;
        Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit, maxDistance) && hit.collider.gameObject.CompareTag("interactive")) {
            Transform objectHit = hit.transform;
            print("hit w " + hit.collider.name);
            if(Input.GetButton("Interact")) {
                print("Klik w " + hit.collider.name);
                hit.collider.gameObject.GetComponent<ObjectSpawner>().spawnObject();
            }
        }
     }
}
