using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordRemove : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D Target) 
    {
        if (Target.gameObject.tag.Equals("Word"))
        {
            //Debug.Log("Interacted word");
            Destroy(Target.gameObject); //Remove Word when interacted with square


        }
    }
}
