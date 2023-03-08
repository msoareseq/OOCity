using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField, Range(0,200)]
    private float leftLimit;
    [SerializeField, Range(0,200)]
    private float rightLimit;
    [SerializeField, Range(0,20)]
    private float speed;
        

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > leftLimit)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < rightLimit)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    
}
