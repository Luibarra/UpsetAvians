using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour
{
    public GameObject Bird;

    bool onMap = false;
    int birdsUsed = 6; 

    private void FixedUpdate()
    {
        if(!onMap && !isMoving())
        {
            spawnNext();
            birdsUsed--;
            if (birdsUsed == 0)
                SceneManager.LoadScene(0);
        }
    }

    bool isMoving()
    {
        Rigidbody2D[] bodies = FindObjectsOfType(typeof(Rigidbody2D)) as Rigidbody2D[];
        foreach (Rigidbody2D rb in bodies)
            if (rb.velocity.sqrMagnitude > 4)
                return true;

        return false; 
    }

    void spawnNext()
    {
        onMap = true;
        Instantiate(Bird, transform.position, Quaternion.identity);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        onMap = false; 
    }
}
