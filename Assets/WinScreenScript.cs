using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class WinScreenScript : MonoBehaviour
{
    
    void Update()
    {
        
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}