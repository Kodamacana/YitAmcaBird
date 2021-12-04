using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharacterControls : MonoBehaviour
{
    float clickposition;
    bool isClick = false;
    public float jumpHeight;
    Rigidbody2D kus; // To access the Rigidbody Component
    void Start()
    {
        kus = transform.GetComponent<Rigidbody2D>();
        
    }



    private void Update()
    {
        if (isClick)
        {
            var d = Mathf.Sqrt(clickposition - Mathf.Abs( transform.position.y));
            kus.AddForce(new Vector2(0, 6000 + d));
        }


        if (Input.GetMouseButtonDown(0)) {

            kus.velocity = new Vector3(0, 0, 0);
            kus.AddForce(Vector2.up * jumpHeight);
            clickposition = kus.transform.position.y;
            isClick = true;
        }
    }



}
