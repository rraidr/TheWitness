using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public Text denialText;
    public Animation textAnimation;
    public string[] denialVersions;
    public int textValue;

    private void Start()
    {
        denialVersions = new string [6];
        denialVersions[0] = "What are you doing?";
        denialVersions[1] = "You can't leave.";
        denialVersions[2] = "You must stay.";
        denialVersions[3] = "Please don't leave us.";
        denialVersions[4] = "We won't let you leave.";
        denialVersions[5] = "No, you're staying here.";
        textValue = 0;
 
    }

    private void Update()
    {
        Cursor.visible = false;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
                 Denial();

        }


    }



    void Denial()
    {
        if (textValue == 5)
        {
            textValue = 0;
        } else
        {
            textValue++;
            textAnimation.GetComponent<Animation>().Play();
            denialText.text = denialVersions[textValue];
            StartCoroutine(RemoveWidget());
        }

    }

    IEnumerator RemoveWidget()
    {
        yield return new WaitForSeconds(2f);

 
    }

}
