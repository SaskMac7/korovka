using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosToPos : MonoBehaviour
{
    public GameObject Obj;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(Obj.transform.position.x, Obj.transform.position.y, Obj.transform.position.z);
    }
}
