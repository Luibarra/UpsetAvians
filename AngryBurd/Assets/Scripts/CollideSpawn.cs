using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideSpawn : MonoBehaviour
{
    public GameObject effect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(effect, transform.position, Quaternion.identity);
        Destroy(this); 
    }
}
