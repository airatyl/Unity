using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript1 : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj2;
    public GameObject obj1;
    public GameObject start;
    public NewBehaviourScript a;
    public ProgressBar Pb;
    public ProgressBar Pb1;



    // Start is called before the first frame update
    void Start()
    {
        a.br = 1;
        Pb.BarValue = 100;
    }
    void OnMouseDown()
    {

        if (obj1.active == false)
        {
            start.GetComponent<MeshRenderer>().enabled = true;
            obj1.SetActive(true);
            Pb.BarValue = Pb.BarValue - 10 * a.br;
            a.br =a.br+ 1;
            a.br1 = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform == gameObject.transform)
                    {
                        if (obj1.active==false)
                        {
                            start.GetComponent<MeshRenderer>().enabled = true;
                            obj1.SetActive(true);
                            Pb.BarValue = Pb.BarValue - 10 * a.br;
                            a.br = a.br + 1;
                            a.br1 = 1;
                        }
                    }
                }
            }
        }
        if (Pb.BarValue==0)
        {
            a.br = 1;
            a.br1 = 1;
            Pb.BarValue = 100;
            Pb1.BarValue = 100;
        }
    }
}
