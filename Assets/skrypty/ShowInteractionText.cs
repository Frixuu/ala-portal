using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class ShowInteractionText : MonoBehaviour
{
     [Tooltip("Dzwiek po otwarciu")]
    public AudioSource audioSource;
    public AudioClip clipToPlay;
    public string interactionValue = "Otwórz";
    public TextMeshProUGUI interationText;
    public Light scaryLight;
    public TextMeshProUGUI healthTextComponent;
    public int health = 10;
    private bool pressing;
    public GameObject objectToDestroy;
    // Start is called before the first frame update
    void Start()
    {
        healthTextComponent.text = "Zdrowie: " + health;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButton("Interact")) {
            if(!pressing) {
                audioSource.Stop();
                pressing = true;
                health--;
                Destroy(objectToDestroy);
                interationText.text = "";
            } 
            
            audioSource.PlayOneShot(clipToPlay);
            scaryLight.enabled = true;
            if(health <= 0) {
                SceneManager.LoadScene("first");
            } else
            {
                healthTextComponent.text = "Zdrowie: " + health;
            }
            
        } else {
            pressing = false;
        }
    }

    //When the Primitive collides with the walls, it will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        interationText.text = interactionValue;
    }

    private void OnTriggerExit(Collider other)
    {
        interationText.text = "";
        if(scaryLight.enabled) {
            scaryLight.enabled = false;
        }
    }
}
