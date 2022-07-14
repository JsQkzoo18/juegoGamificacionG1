using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosOriginal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = this.transform.position + new Vector3(0f, -4f, 0f) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
