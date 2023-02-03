using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public int[] myArrayOfInts;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 18; i++)
        {
            Debug.Log(i);
        }

        for (int i = 0; i < myArrayOfInts.Length; i++)
        {
            Debug.Log(myArrayOfInts[i]);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
