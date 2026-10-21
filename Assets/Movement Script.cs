using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshPro ScoreText;
    public SpriteRenderer SR;
    public Rigidbody2D RB;
    public float speed = 6;
    public int score = 0;

    void Start()
    {

    }

    void Update()
    {
        Vector3 pos = transform.position;

        Vector2 vel = new Vector2(0, RB.linearVelocity.y);

        if (Keyboard.current.dKey.isPressed)
        {
            pos.x += speed * Time.deltaTime;
        }

        if (Keyboard.current.dKey.isPressed && Keyboard.current.qKey.isPressed)
        {
            pos.x += speed * Time.deltaTime * 2;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            pos.x -= speed * Time.deltaTime;
        }

        if (Keyboard.current.aKey.isPressed && Keyboard.current.qKey.isPressed)
        {
            pos.x -= speed * Time.deltaTime * 2;
        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame &&
            (OnGround() || JumpsLeft > 0))
        {
            vel.y = 5;
        }

        if (OnGround())
        {
            JumpsLeft = 2;
        }

        transform.position = pos;

        RB.linearVelocity = vel;
    }

    private int JumpsLeft = 2;

    public bool OnGround()
    {
        if (transform.position.y <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool CanJump()
    {
        return true;
    }
}
 