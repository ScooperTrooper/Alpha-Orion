using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetest : MonoBehaviour
{

    float moveSpeed = 1f;
    float turnSpeed = 0.5f;
    float runSpeed;
    float animationSpeed;
    float speed;
    float forward = 0;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        speed = moveSpeed;
        animationSpeed = 0.4f;
        runSpeed = moveSpeed * 1.7f;
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.speed = 1;

        if (animator != null)
        {
            this.animator.SetFloat("Forward", forward); this.animator.SetFloat("Turn", 0f);
            

        }

        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.position = this.gameObject.transform.position + (this.gameObject.transform.forward *(speed * Time.fixedDeltaTime));
            if (animator != null)
            {
                forward =  speed*animationSpeed;

            }


        }
        else { forward = 0; }


        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            this.animator.SetFloat("Turn", -0.2f);
            this.gameObject.transform.RotateAround(this.gameObject.transform.position, Vector3.up, -turnSpeed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            this.animator.SetFloat("Turn",-0.8f);
            this.gameObject.transform.RotateAround(this.gameObject.transform.position, Vector3.up, -turnSpeed);
        }


        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.position = this.gameObject.transform.position + (this.gameObject.transform.forward * (-speed * Time.fixedDeltaTime));
            if (animator != null)
            {
                animator.playbackTime = animator.GetCurrentAnimatorClipInfo(1).Length;
                animator.speed = -1;
              

                forward = animationSpeed * speed;

            }
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {
            this.animator.SetFloat("Turn", 0.2f);
            this.gameObject.transform.RotateAround(this.gameObject.transform.position, Vector3.up, turnSpeed);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.animator.SetFloat("Turn", 0.8f);
            this.gameObject.transform.RotateAround(this.gameObject.transform.position, Vector3.up, turnSpeed);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = runSpeed;
      

        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = moveSpeed;


        }




    }
}
