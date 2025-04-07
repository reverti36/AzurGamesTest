using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine.UI;

public class ObjectsClickScript : MonoBehaviour
{
    private int points;
    private const int max = 10;
    private Animator anim;
    public GameObject pointsCounter;

    public MarksScript marks;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
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
        marks.PlusOne(max - points);
    }
}
