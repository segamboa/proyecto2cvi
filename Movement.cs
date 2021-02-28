using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();
    }
    

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("vertical", Input.GetAxis("Vertical"));
        anim.SetFloat("horizontal", Input.GetAxis("Horizontal")); 

        if(Input.GetKeyUp(KeyCode.P)){
            //Debug.Log("HOLA");
            anim.enabled = !anim.enabled;  
        }
    }
}
