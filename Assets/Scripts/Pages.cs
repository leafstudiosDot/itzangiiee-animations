using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pages : MonoBehaviour
{
    private int AnimationPage = 1;
    public GameObject PreviousButton;
    public GameObject AnimationObjects1;
    public GameObject AnimationObjects2;
    public GameObject AnimationObjects3;
    public GameObject AnimationObjects4;
    public GameObject Ragdoll;

    // Start is called before the first frame update
    void Start()
    {
        WindowTitleChange.ChangeWindowTitleAtStart("Itz Angiiee");
    }

    // Update is called once per frame
    void Update()
    {
        if (AnimationPage > 1)
        {
            PreviousButton.SetActive(true);
        } else
        {
            PreviousButton.SetActive(false);
        }

        //Animations
        switch (AnimationPage)
        {
            case 1:
                AnimationObjects1.SetActive(true);
                AnimationObjects2.SetActive(false);
                AnimationObjects3.SetActive(false);
                AnimationObjects4.SetActive(false);
                break;
            case 2:
                AnimationObjects1.SetActive(false);
                AnimationObjects2.SetActive(true);
                AnimationObjects3.SetActive(false);
                AnimationObjects4.SetActive(false);
                break;
            case 3:
                AnimationObjects1.SetActive(false);
                AnimationObjects2.SetActive(false);
                AnimationObjects3.SetActive(true);
                AnimationObjects4.SetActive(false);
                break;
            case 4:
                AnimationObjects1.SetActive(false);
                AnimationObjects2.SetActive(false);
                AnimationObjects3.SetActive(false);
                AnimationObjects4.SetActive(true);
                break;
        }

        if (AnimationPage < 4)
        {
            ResetRagdoll();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.ForceCrash(0);
        }

        if (Input.GetKeyDown(KeyCode.F11))
        {
            if (Screen.fullScreen)
            {
                Screen.fullScreen = false;
            } else
            {
                Screen.fullScreen = true;
            }
        }

    }

    public void ResetRagdoll()
    {
        Ragdoll.transform.position = new Vector2(-0.6421853f, -1.36f);
    }

    public void NextPage()
    {
        AnimationPage += 1;
        Debug.Log(AnimationPage);
        if (AnimationPage >= 5)
        {
            SceneManager.LoadScene("finalanim");
        }
    }

    public void PreviousPage()
    {
        AnimationPage -= 1;
        Debug.Log(AnimationPage);
    }
}
