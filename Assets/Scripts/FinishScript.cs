using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishScript : MonoBehaviour
{
    private Animator anim;
    private Animator soundAnim;
    public GameObject finishScreen;

    public TextMeshProUGUI finishText;

    public TimerScript timerScript;
    // Start is called before the first frame update
    void Start()
    {
        anim = finishScreen.gameObject.GetComponent<Animator>();
        soundAnim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayFinish()
    {
        soundAnim.Play("Sound Lower");
        timerScript.StopTimer();
        finishScreen.SetActive(true);
        anim.SetTrigger("Success");
        finishText.text = "Great job!";
    }

    public void PlayFail()
    {
        soundAnim.SetTrigger("Sound Lower");
        finishScreen.SetActive(true);
        anim.SetTrigger("Fail");
        finishText.text = "Better luck next time!";
    }
}
