using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMath : MonoBehaviour
{
    int num = 4;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(num);
    }

    // Update is called once per frame
    void Update()
    {
        num = product(num, 2);
        Debug.Log(num);
    }

    int product(int num1, int num2)
    {
        return num1 * num2;
    }
}
