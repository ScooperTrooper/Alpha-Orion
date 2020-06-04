using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    public GameObject target;
    Vector3 Distance;

    // Start is called before the first frame update
    void Start()
    {
       Distance = this.gameObject.transform.position - target.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = target.transform.position + Distance;

        
    }
}
