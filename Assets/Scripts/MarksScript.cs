using System.Collections;
using System.Collections.Generic;
using Coffee.UIExtensions;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class MarksScript : MonoBehaviour
{
    private GameObject mark;
    public FinishScript finishScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlusOne(int num, GameObject particleSystem)
    {
        mark = GameObject.Find("mark" + num);
        mark.GetComponent<Animator>().SetTrigger("Ding");
        if(num == 10)
        {
            finishScreen.PlayFinish();
        }
    }
}
