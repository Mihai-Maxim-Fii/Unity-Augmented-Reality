using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
  
    void Start()
    {
        GetComponent<Animator>().SetBool("AttackMe", false);

    }

    // Update is called once per frame
    void Update()
    {
        float d = Vector3.Distance(Camera.main.transform.position, transform.position);
           if(d<10.50f)
            {
                GetComponent<Animator>().SetBool("AttackMe", true);
            }
           else
                GetComponent<Animator>().SetBool("AttackMe", false);
    }
}
