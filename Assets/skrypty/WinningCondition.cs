using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinningCondition : MonoBehaviour
{
    public int pointsToWin = 3;
    [Tooltip("Nazwa sceny dodana w buildSettings")]
    public string sceneToLoad;
    public AudioClip winSound;
    private int points = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addPoint() {
        points++;
        verifyWinCondition();
    }
    private void verifyWinCondition() {
        if(points >= pointsToWin) {
            GameObject.Find("win text").GetComponent<TextMeshProUGUI>().enabled = true;
            GetComponent<AudioSource>().PlayOneShot(winSound);
            StartCoroutine(waitSeconds(5.0f));
            
        }
    }

    IEnumerator waitSeconds(float num)
    {
        Debug.Log("waitSeconds created");
        yield return new WaitForSeconds(num);
        SceneManager.LoadScene(sceneToLoad);
    }
}
