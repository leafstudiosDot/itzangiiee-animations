using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScript : MonoBehaviour
{
    private int gameShutdown = 27;
    public Text Countdown;
    // Start is called before the first frame update
    void Start()
    {
        WindowTitleChange.ChangeWindowTitleAtEnd("Hey look people, Its kittypop time :D");
        StartCoroutine(countdown());
    }

    // Update is called once per frame
    void Update()
    {
        if (gameShutdown <= 0)
        {
            Debug.Log("See ya later");
            //Application.ForceCrash(1);
            Application.Quit();
        }
    }

    IEnumerator countdown()
    {
        while (true)
        {
            gameShutdown -= 1;
            Countdown.text = "This game will exit in " + gameShutdown;
            Debug.Log(gameShutdown);
            yield return new WaitForSeconds(1);
        }
    }
}
