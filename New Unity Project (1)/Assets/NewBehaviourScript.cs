using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public int br;
    public int br1;
    public int z;
    public int c;
    public GameObject obj;
    public GameObject obj3;
    public GameObject obj5;
    public GameObject obj7;
    public GameObject obj9;
    public GameObject obj10;
    public GameObject obj11;
    public GameObject obj12;
    public GameObject obj13;
    public GameObject obj14;
    public GameObject obj15;
    public GameObject obj16;
    public GameObject obj17;
    public GameObject obj18;
    public GameObject obj19;
    public GameObject start;
    float Timer;
    int l;
    int a;
    int b;
    float f;
    float g;
    float e;
    float r;
    float q;
    float p;
    float h;
    float o;
    float m;
    float n;
    float v;
    float k;
    // Start is called before the first frame update

    void Start()
    {
        Timer = 5;
    }
    void OnMouseDown()
    {
        Timer = 0;
        l = Random.Range(1, 6);
        a = Random.Range(1, 5);
        b = Random.Range(1, 5);
        start.GetComponent<MeshRenderer>().enabled = false;
    }
  

    // Update is called once per frame
    void Update()
    {
        foreach(Touch touch in Input.touches)
        {
            if(touch.phase==TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;
                if(Physics.Raycast(ray, out hit))
                {
                    if (hit.transform==gameObject.transform)
                    {
                        Timer = 0;
                        l = Random.Range(1, 6);
                        a = Random.Range(1, 5);
                        b = Random.Range(1, 5);
                        start.GetComponent<MeshRenderer>().enabled = false;
                    }
                }
            }
        }
        Timer += Time.deltaTime; 

        if (Timer<3)
        {
            if (a == 1)
            {
                m = obj19.transform.position.x;
                n = obj10.transform.position.x;
                f = obj19.transform.position.z;
                g = obj19.transform.position.y;
                e = obj10.transform.position.z;
                r = obj10.transform.position.y;
                obj10.transform.position = new Vector3(m, g, f);
                obj19.transform.position = new Vector3(n, r, e);
            }
            if (a == 2)
            {
                m = obj12.transform.position.x;
                n = obj10.transform.position.x;
                f = obj12.transform.position.z;
                g = obj12.transform.position.y;
                e = obj10.transform.position.z;
                r = obj10.transform.position.y;
                obj10.transform.position = new Vector3(m, g, f);
                obj12.transform.position = new Vector3(n, r, e);
            }
            if (a == 3)
            {
                m = obj17.transform.position.x;
                n = obj10.transform.position.x;
                f = obj17.transform.position.z;
                g = obj17.transform.position.y;
                e = obj10.transform.position.z;
                r = obj10.transform.position.y;
                obj10.transform.position = new Vector3(m, g, f);
                obj17.transform.position = new Vector3(n, r, e);
            }
            if (a == 4)
            {
                m = obj11.transform.position.x;
                n = obj10.transform.position.x;
                f = obj11.transform.position.z;
                g = obj11.transform.position.y;
                e = obj10.transform.position.z;
                r = obj10.transform.position.y;
                obj10.transform.position = new Vector3(m, g, f);
                obj11.transform.position = new Vector3(n, r, e);
            }
            a = Random.Range(1, 5);
            if (b == 1)
            {
                v = obj13.transform.position.x;
                k = obj14.transform.position.x;
                q = obj13.transform.position.z;
                p = obj13.transform.position.y;
                h = obj14.transform.position.z;
                o = obj14.transform.position.y;
                obj14.transform.position = new Vector3(v, p, q);
                obj13.transform.position = new Vector3(k, o, h);
            }
            if (b == 2)
            {
                v = obj15.transform.position.x;
                k = obj14.transform.position.x;
                q = obj15.transform.position.z;
                p = obj15.transform.position.y;
                h = obj14.transform.position.z;
                o = obj14.transform.position.y;
                obj14.transform.position = new Vector3(v, p, q);
                obj15.transform.position = new Vector3(k, o, h);
            }
            if (b == 3)
            {
                v = obj16.transform.position.x;
                k = obj14.transform.position.x;
                q = obj16.transform.position.z;
                p = obj16.transform.position.y;
                h = obj14.transform.position.z;
                o = obj14.transform.position.y;
                obj14.transform.position = new Vector3(v, p, q);
                obj16.transform.position = new Vector3(k, o, h);
            }
            if (b == 4)
            {
                v = obj18.transform.position.x;
                k = obj14.transform.position.x;
                q = obj18.transform.position.z;
                p = obj18.transform.position.y;
                h = obj14.transform.position.z;
                o = obj14.transform.position.y;
                obj14.transform.position = new Vector3(v, p, q);
                obj18.transform.position = new Vector3(k, o, h);
            }
            b = Random.Range(1, 5);
        }
        if (Timer > 3 && Timer < 4)
        {
            if (l == 1)
            {
                obj.SetActive(false);
            }
            if (l == 2)
            {
                obj3.SetActive(false);
            }
            if (l == 3)
            {
                obj5.SetActive(false);
            }
            if (l == 4)
            {
                obj7.SetActive(false);
            }
            if (l == 5)
            {
                obj9.SetActive(false);
            }
        }
    }
}
