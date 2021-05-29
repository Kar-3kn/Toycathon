using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pmove : MonoBehaviour
{
    static Animator anim;
    public float speed = 10f;
    public float rotationSpeed = 1000.0f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

  
        if(Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("jump");
            
        }

        if(Input.GetButtonDown("q"))
        {
            anim.SetTrigger("attack");
        }


        if (translation != 0)
        {
            anim.SetBool("run", true);
            anim.SetBool("wait", false);
        }
        else
        {
            anim.SetBool("run", false);
            anim.SetBool("wait", true);
        }
    }
}
