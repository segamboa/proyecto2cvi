using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripJuguete : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.P)){
            //Debug.Log("HOLA");
            anim.enabled = !anim.enabled;  
        }
    }
}
