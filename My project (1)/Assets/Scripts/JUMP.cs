using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUMP : MonoBehaviour

{
    [SerializeField, Header("¸õÅD°ª«×"), Range(0, 3000)]
    private float HJ = 350;
    private Rigidbody2D rg;
    private Animator ani;
    private bool clickJ;

    private void Awake()
    {
        rg = GetComponent<Rigidbody2D>();
        ani =GetComponent<Animator>();
    }
    // Start is called before the first frame update
    private void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            clickJ = true;
        }
    }
    private void Update()
    {
        Jump();
    }
    private void FixedUpdate()
    {
        JF();
    }
    private void JF()
    {
        if(clickJ)
        {
            rg.AddForce(new Vector2(0, HJ));
            clickJ = false;
        }
    }
}
