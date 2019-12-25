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
    int l;
    public ProgressBar Pb;

  
    // Start is called before the first frame update
    void Start()
    {
        Pb.BarValue = 100;
    }
    void OnMouseDown()
    {

        if (obj1.active == false)
        {
            start.GetComponent<MeshRenderer>().enabled = true;
            obj1.SetActive(true);
            a.z += 1;
            obj.GetComponent<TextMeshPro>().text = a.z.ToString();
            l = Random.Range(1, 5);
            Pb.BarValue = Pb.BarValue - 10 * l;
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
                            a.z += 1;
                            obj.GetComponent<TextMeshPro>().text = a.z.ToString();
                            l = Random.Range(1, 5);
                            Pb.BarValue = Pb.BarValue - 10 * l;
                        }
                    }
                }
            }
        }
        if (a.z==3 )
        {
            a.z = 0;
            obj2.GetComponent<TextMeshPro>().text = a.z.ToString();
            a.c = 0;
            obj.GetComponent<TextMeshPro>().text = a.c.ToString();
        }
    }
}
