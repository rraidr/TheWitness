using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillSpinScript : MonoBehaviour
{

    private void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(0f, 0f, 2f, Space.Self);
    }
}
