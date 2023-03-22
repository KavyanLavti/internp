using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public float Score = 0;
    
   
    void Update()
    {
        Debug.Log(Score);
    }
   
    private void OnTriggerEnter(Collider pointer)
    {
        if (pointer.gameObject.tag == "Cubes")
        {
            Score += 10;
            Destroy(pointer.gameObject);
        }
        else if (pointer.gameObject.tag == "Spheres")
        {
            Score += 30;
            Destroy(pointer.gameObject);
        }
    }
}
