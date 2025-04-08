using System.Collections;
using System.Collections.Generic;
using Coffee.UIExtensions;
using UnityEngine;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine.UI;

public class MarksScript : MonoBehaviour
{
    private GameObject mark;
    public FinishScript finishScreen;

    private UIParticleAttractor attractor;
    // Start is called before the first frame update
    void Start()
    {
        attractor = gameObject.GetComponent<UIParticleAttractor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlusOne(int num, GameObject particleSystem)
    {
        mark = GameObject.Find("mark" + num);
        attractor = mark.GetComponent<UIParticleAttractor>();
        mark.GetComponent<Animator>().SetTrigger("Ding");
        if(num == 10)
        {
            finishScreen.PlayFinish();
        }
        attractor.AddParticleSystem(particleSystem.GetComponent<ParticleSystem>());
        //attractor.AddParticleSystem(particleSystem);
    }
}
