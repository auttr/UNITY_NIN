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
    [SerializeField, Header("checkpos")]
    private Vector3 checkpos =  Vector3.one;
    [SerializeField, Header("checksize")]
    private Vector3 checksize;
    [SerializeField, Header("checkcolor")]
    private Color checkcolor =new  Color(1, 0, 0.5f, 0.5f);
    [SerializeField, Header("checkgroundlayer")]
    private LayerMask layer;
    bool Isground;


    private void Awake()
    {
        rg = GetComponent<Rigidbody2D>();
        ani =GetComponent<Animator>();
    }
    // Start is called before the first frame update
    private void OnDrawGizmos()
    {
        Gizmos.color = checkcolor;
        Gizmos.DrawCube(transform.position + checkpos, checksize);
    }
    void IsGround()
    {
        Collider2D hit=Physics2D.OverlapBox(transform.position + checkpos, checksize,0,layer);
        //print("¸I¨ì:"+hit.name);
        Isground = hit;
    }
    private void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            clickJ = true;
        }else if   (Input.GetButtonUp("Jump"))
        {
            clickJ = false;
        }
    }
    private void Update()
    {
        Jump();
        IsGround();
    }
    private void FixedUpdate()
    {
        JF();
    }
    private void JF()
    {
        if(clickJ && Isground)
        {
            rg.AddForce(new Vector2(0, HJ));
            clickJ = false;
        }
    }
}
