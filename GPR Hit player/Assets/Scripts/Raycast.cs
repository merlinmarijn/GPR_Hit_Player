using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    Raycast ray;
    public GameObject prefab;
    void Update()
    {
        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.TransformDirection(transform.forward)*100, Color.red);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(transform.forward), out hit, Mathf.Infinity))
            {
                if (hit.transform.tag == "Player")
                {
                    hit.transform.GetComponent<Player>().DetectHit(10);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(prefab);
        }
    }
}
