using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public Car CloneTarget = null;
    public Transform GenerationPos = null;
    public int GenerationPersent = 50;

    public float CloneDelaySec = 1f;

    protected float NextSecToClone = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float curSec = Time.time;
        if(NextSecToClone <= Time.time)
        {
            int randomval = Random.Range(0, 100);
            if(randomval <= GenerationPersent)
            {
                CloneCar();
            }
            NextSecToClone = Time.time + CloneDelaySec;
        }

    }

    void CloneCar()
    {
        Transform clonePos = GenerationPos;
        Vector3 offsetPos = clonePos.position;
        offsetPos.y = 1f;
        GameObject cloneobj = GameObject.Instantiate(CloneTarget.gameObject, offsetPos, GenerationPos.rotation, this.transform);
        cloneobj.SetActive(true);
    }
}
