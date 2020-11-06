using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGateOnCollide : MonoBehaviour
{

    public GameObject objectToDestroy;
  
    private void OnTriggerEnter(Collider other) {
        print("W obszarze!");
        if(other.gameObject.CompareTag("draggable")) {
            print("W obszarze przedmiot!");
            Destroy(objectToDestroy);
            GameObject.Find("points").GetComponent<PointAdder>().addPoint();
            Destroy(this);
        }

    }
}
