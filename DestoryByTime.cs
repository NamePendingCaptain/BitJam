using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour
{

    public float lifetime;
    //This will delete gameObjects after a period of time
    void Start()
    {
        Destroy(gameObject, lifetime);
    }


}
//Apply to all the exploded stuff


