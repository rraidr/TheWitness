using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWhisperDistance : MonoBehaviour
{

    public FMOD.Studio.EventInstance instance;

    public FMODUnity.EventReference fmodEvent;

    public GameObject player;
    public float incrementValue;
    public bool inTrigger;

    [SerializeField, Range (0f, 100f)] public float distance;



    void Start()
    {
        distance = 100f;
        instance = FMODUnity.RuntimeManager.CreateInstance(fmodEvent);
        instance.start();
        inTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        instance.setParameterByName("Distance", distance);
        incrementValue = 15f;

        if (inTrigger == true)
        {
            if (distance >= 0)
            {
                distance -= incrementValue * Time.deltaTime;
            }
        }

        if (inTrigger == false)
        {
            if (distance <= 100)
            {
                distance += incrementValue * Time.deltaTime;
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    public void OnTriggerExit(Collider other)
    {
        inTrigger = false; 
    }


}
