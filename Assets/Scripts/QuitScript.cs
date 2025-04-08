using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitApplitaion()
    {
        audioSource.Stop();
        Application.OpenURL("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        Application.Quit();
    }
}
