using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine.UI;

public class MarksScript : MonoBehaviour
{
    private GameObject mark;
    private GameObject markImage;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlusOne(int num)
    {
        mark = GameObject.Find("mark" + num);
        mark.GetComponent<Animator>().SetTrigger("Ding");
    }
}
