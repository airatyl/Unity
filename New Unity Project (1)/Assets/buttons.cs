using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    public GameObject begin;
    public GameObject cube;
    public GameObject rules;
    public GameObject txt;
    public void rule()
    {
        begin.SetActive(!begin.activeSelf);
        txt.SetActive(!txt.activeSelf);
    }
    public void begins()
    {
        begin.SetActive(!begin.activeSelf);
        rules.SetActive(!rules.activeSelf);
        cube.SetActive(!cube.activeSelf);
    }
}
