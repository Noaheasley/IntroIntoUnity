using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    public float YMin;
    public float YMax;
    public float HSpeed;
    public float VSpeed;
    public float VerticalSpeed;
    public float StartCos = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(HSpeed,0,0) * Time.deltaTime;
        StartCos += Time.deltaTime;
        transform.position += new Vector3(0, Mathf.Cos(StartCos), 0) * VerticalSpeed * Time.deltaTime; 
    }
}
