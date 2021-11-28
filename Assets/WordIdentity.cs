using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordIdentity : MonoBehaviour
{

    public void OnCollisionEnter2D() 
    {
        if (gameObject.tag == "Endline")
        {
            Destroy(gameObject);
        }
    }
}
