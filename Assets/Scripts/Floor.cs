using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public bool isFirst;
    private void Update()
    {
        if(isFirst==false)
        {
            Invoke("Destruct", 20f);
        }
    }

    private void Destruct()
    {
        Destroy(gameObject);
    }
}

