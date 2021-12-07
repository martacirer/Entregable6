using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

public float speed = 5f;
private float lowerLim = 10f;
private float upperLim = 10f;
private float rightLim = 15f;
private float leftLim = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

//proyectil siempre para delante y destruirse cuando salga de los limites
        transform.Translate(Vector3.up * speed * Time.deltaTime);


        if(transform.position.y > upperLim)
          {
             Destroy(gameObject);
          }
        if(transform.position.y < lowerLim)
          {
             Destroy(gameObject);
          }
        if(transform.position.y < leftLim)
          {
             Destroy(gameObject);
          }
        if(transform.position.y > rightLim)
          {
             Destroy(gameObject);
          }

    }
}
