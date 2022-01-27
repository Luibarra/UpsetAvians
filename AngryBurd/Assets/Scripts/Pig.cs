using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pig : MonoBehaviour
{
    public static int pigNum; 
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
            pigNum = 1;
        else
            pigNum = 2;
    }
    
    private void OnDestroy()
    {
        pigNum--;
        if (pigNum == 0)
            if (SceneManager.GetActiveScene().buildIndex == 2)
                SceneManager.LoadScene(0);
            else
                SceneManager.LoadScene(2); 
    }
}
