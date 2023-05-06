using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// importing scene manager so we can use it

public class exit : MonoBehaviour
{
    //scene you want to exit to
    public string Scene;
    //key you want to initiate exit
    public string ExitKey;
    //both are public so you can change them
    //please use key values from abcdefghigklmnopqrstuvwxyz

    //update so that Unity is checking constantly
    void Update()
    {
        
        //if player pressed the key you assigned
        if (Input.GetKeyDown(ExitKey))
        {
           //then do:
            SceneManager.LoadScene(Scene);
           //which asks the scene manager to load the scene you assigned
        }
    }
}
