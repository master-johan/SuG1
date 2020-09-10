using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CollisionTester : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
      //  Debug.Log(gameObject.name + "Has collided with" + col.gameObject.name);
    }

    void TriggerNotify(Collision col)
    {
        //Debug.Log(gameObject.name + "Was triggered by" + col.gameObject.name);
    }
}
