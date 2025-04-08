using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishScript : MonoBehaviour
{
    private Animator anim;
    public GameObject finishScreen;

    public TextMeshProUGUI finishText;

    public TimerScript timerScript;
    // Start is called before the first frame update
    void Start()
    {
        anim = finishScreen.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayFinish()
    {
        timerScript.StopTimer();
        finishScreen.SetActive(true);
        anim.SetTrigger("Success");
        finishText.text = "Great job!";
    }

    public void PlayFail()
    {
        finishScreen.SetActive(true);
        anim.SetTrigger("Fail");
        finishText.text = "Better luck next time!";
    }
}
