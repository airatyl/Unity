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

  
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnMouseDown()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = new Color(1,1,1);

        if (obj1.GetComponent<MeshRenderer>().enabled == false)
        {
            start.GetComponent<MeshRenderer>().enabled = true;
            obj1.GetComponent<MeshRenderer>().enabled = true;
            a.z += 1;
            obj.GetComponent<TextMeshPro>().text = a.z.ToString();
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
                        if (obj1.GetComponent<MeshRenderer>().enabled == false)
                        {
                            start.GetComponent<MeshRenderer>().enabled = true;
                            obj1.GetComponent<MeshRenderer>().enabled = true;
                            a.z += 1;
                            obj.GetComponent<TextMeshPro>().text = a.z.ToString();
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
