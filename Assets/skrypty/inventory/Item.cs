using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;
    private bool isNearPlayer;
    private GameObject exactCollidedGameObject;
// Start is called before the    first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isNearPlayer) {
            return;
        }
        if(Input.GetButton("Interact")) {
            Destroy(exactCollidedGameObject);
            Inventory inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
            inventory.addItem(this);
            Debug.Log ("Dodano przedmiot!");
        }
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.name != "hand") { 
            return;
        }
        isNearPlayer = true;
        exactCollidedGameObject = gameObject;
        Debug.Log ("wszedl");
    }

    void OnTriggerExit(Collider other) {
        if(other.gameObject.name != "hand") { 
            return;
        }
        isNearPlayer = false;
        exactCollidedGameObject = null;
        Debug.Log ("wyszedl");
    }
}
