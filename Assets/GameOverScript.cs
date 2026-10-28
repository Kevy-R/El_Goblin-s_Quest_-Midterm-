using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    
    void Update()
    {
        //If the player hit space. . .
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            //Then load the 'Example 3' scene
            SceneManager.LoadScene("Main Menu");
        }
    }
}