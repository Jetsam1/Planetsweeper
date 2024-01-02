using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Death: MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (gameObject.tag == "Hazard")
        {
            Invoke("RockDestroyed", 0);
        }else if(gameObject.name=="Enemy")
        {
            Invoke("MissileDestroyed", 0);
        }
        else
        {
            Invoke("CometDestroyed", 0);
        }
           
    }

   private void RockDestroyed()
   {
        Debug.Log("Destroyed");
        Destroy(gameObject);
   }

    private void MissileDestroyed()
    {
        Debug.Log(" Missile Destroyed");
        Destroy(gameObject);
    }
    private void CometDestroyed()
    {
        Debug.Log("Comet Destroyed");
        Destroy(gameObject);
    }
}

