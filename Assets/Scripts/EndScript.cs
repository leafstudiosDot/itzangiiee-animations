using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

using Debug = UnityEngine.Debug;

public class EndScript : MonoBehaviour
{
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        WindowTitleChange.ChangeWindowTitleAtEnd("Hey look people, Its kittypop time :D");
        var videoPlayer = camera.GetComponent<UnityEngine.Video.VideoPlayer>();
        videoPlayer.loopPointReached += EndReached;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        Debug.Log("See ya!");
        Application.Quit();
    }

}
