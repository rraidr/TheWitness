using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndOfGame : MonoBehaviour
{

    public GameObject blackScreenCanvas;
    public Animation blackScreen;
    public IEnumerator screenTimer;
    public void OnTriggerEnter(Collider other)
    {

        blackScreenCanvas.GetComponent<Animation>().Play();
        StartCoroutine(LevelEnd()); 
    }

    IEnumerator LevelEnd()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
}
