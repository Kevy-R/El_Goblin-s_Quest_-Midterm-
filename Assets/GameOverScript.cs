using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    
    void Update()
    {
       
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
         
            SceneManager.LoadScene("Main Menu");
        }
    }
}