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
        animationSpeed = 0.7f;
        runSpeed = moveSpeed * 1.7f;
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D)) { forward = 0; }
        this.animator.SetFloat("Forward", forward);




    







        if (Input.GetKey(KeyCode.W))
        {

            if (this.gameObject.transform.rotation != Quaternion.Euler(0, 0, 0))
            {
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            }

            this.gameObject.transform.position = this.gameObject.transform.position + (this.gameObject.transform.forward * (speed * Time.fixedDeltaTime));
            if (animator != null)
            {
                forward = speed * animationSpeed;

            }


        }
        if (Input.GetKey(KeyCode.A))
        {
            if (this.gameObject.transform.rotation != Quaternion.Euler(0, -90, 0))
            {
                this.gameObject.transform.rotation = Quaternion.Euler(0, -90, 0);
            }
            this.gameObject.transform.position = this.gameObject.transform.position + (this.gameObject.transform.forward * (speed * Time.fixedDeltaTime));
            if (animator != null)
            {
                forward = speed * animationSpeed;

            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (this.gameObject.transform.rotation != Quaternion.Euler(0, 180, 0))
            {
                this.gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
            }

            this.gameObject.transform.position = this.gameObject.transform.position + (this.gameObject.transform.forward * (speed * Time.fixedDeltaTime));
            if (animator != null)
            {
                forward = speed * animationSpeed;

            }

        }
        if (Input.GetKey(KeyCode.D))
        {
            if (this.gameObject.transform.rotation != Quaternion.Euler(0, 90, 0))
            {
                this.gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
            }
            this.gameObject.transform.position = this.gameObject.transform.position + (this.gameObject.transform.forward * (speed * Time.fixedDeltaTime));
            if (animator != null)
            {
                forward = speed * animationSpeed;

            }

        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            if (this.gameObject.transform.rotation != Quaternion.Euler(0, -45, 0))
            {
                this.gameObject.transform.rotation = Quaternion.Euler(0, -45, 0);
            }

            this.gameObject.transform.position = this.gameObject.transform.position + (this.gameObject.transform.forward * (speed * Time.fixedDeltaTime));
            if (animator != null)
            {
                forward = speed * animationSpeed;

            }


        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            if (this.gameObject.transform.rotation != Quaternion.Euler(0, 45, 0))
            {
                this.gameObject.transform.rotation = Quaternion.Euler(0, 45, 0);
            }

            this.gameObject.transform.position = this.gameObject.transform.position + (this.gameObject.transform.forward * (speed * Time.fixedDeltaTime));
            if (animator != null)
            {
                forward = speed * animationSpeed;

            }


        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            if (this.gameObject.transform.rotation != Quaternion.Euler(0, -135, 0))
            {
                this.gameObject.transform.rotation = Quaternion.Euler(0, -135, 0);
            }

            this.gameObject.transform.position = this.gameObject.transform.position + (this.gameObject.transform.forward * (speed * Time.fixedDeltaTime));
            if (animator != null)
            {
                forward = speed * animationSpeed;

            }


        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            if (this.gameObject.transform.rotation != Quaternion.Euler(0, 135, 0))
            {
                this.gameObject.transform.rotation = Quaternion.Euler(0, 135, 0);
            }

            this.gameObject.transform.position = this.gameObject.transform.position + (this.gameObject.transform.forward * (speed * Time.fixedDeltaTime));
            if (animator != null)
            {
                forward = speed * animationSpeed;

            }


        }





        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            forward = 0;

        }


        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            forward = 0;

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
