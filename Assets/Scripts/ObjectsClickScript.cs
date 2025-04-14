using System.Collections;
using System.Collections.Generic;
using Coffee.UIExtensions;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class ObjectsClickScript : MonoBehaviour
{
    public GameObject pointsCounter;
    public MarksScript marks;
    public ParticleSystem particleSystem;
    public PlaySoundOnClickScript playSoundOnClickScript;
    
    private int points = 0;
    private const int max = 10;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        particleSystem = gameObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Click()
    {
        anim.SetTrigger("Click");
        
        this.gameObject.GetComponent<Button>().enabled = false;
        points = int.Parse(pointsCounter.GetComponent<TMPro.TextMeshProUGUI>().text) - 1;
        pointsCounter.GetComponent<TMPro.TextMeshProUGUI>().text = points.ToString();
        marks.PlusOne(max - points, this.gameObject);
        playSoundOnClickScript.PlaySfx(max - points);
    }
}
