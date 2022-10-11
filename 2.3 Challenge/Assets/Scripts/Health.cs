using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    int hearts = 100;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hearts: " + hearts);
    }

    // Update is called once per frame
    void Update()
    {
        hearts = hearts - 1;
        Debug.Log("Hearts: " + hearts);
    }
}
