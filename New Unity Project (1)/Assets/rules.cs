using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rules : MonoBehaviour
{
	public GameObject txt;
	public GameObject begin;
    // Start is called before the first frame update
    void Start()
    {
        
    }
	public void rule()
	{
		txt.SetActive(txt.activeSelf);
		begin.SetActive(begin.activeSelf);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
