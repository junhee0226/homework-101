using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public float Smoothjing = 5f;

    Vector3 m_Offsetval;

    // Start is called before the first frame update
    void Start()
    {
        m_Offsetval = transform.position - Target.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camerapos = Target.position + m_Offsetval;
        transform.position = Vector3.Lerp(transform.position, camerapos, Smoothjing * Time.deltaTime);  
    }
}
