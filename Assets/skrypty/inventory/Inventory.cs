using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Inventory : MonoBehaviour
{
    public List<Item> itemList = new List<Item>();
    public GameObject eqElement;
    private Transform initialPosition;
    private GameObject parent;
     // Start is called before the first frame update
    void Start()
    {
       parent = GameObject.Find("eq-list");
       initialPosition = eqElement.transform;
     }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addItem(Item pickedItem) { 
        itemList.Add(pickedItem);
        GameObject added = Instantiate(eqElement, new Vector3(parent.transform.position.x + 400, parent.transform.position.y + 50 - itemList.Count * 30,parent.transform.position.z), Quaternion.identity);
        TextMeshProUGUI textGui = added.GetComponent<TextMeshProUGUI>();
        textGui.text = pickedItem.itemName;
        
        added.transform.SetParent(parent.transform);
    }
}
