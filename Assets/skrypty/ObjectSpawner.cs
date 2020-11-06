using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject spawnPlace;


    public void spawnObject() {
        Instantiate(objectToSpawn, new Vector3(spawnPlace.transform.position.x, spawnPlace.transform.position.y, spawnPlace.transform.position.z), Quaternion.identity);
    }
}
