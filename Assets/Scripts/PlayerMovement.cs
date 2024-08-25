using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D myRigidbody2D;
    void Start()
    {
        myRigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movemement();
    }

    private void Movemement(){

        if(Input.GetKeyDown(KeyCode.Space)){
            myRigidbody2D.AddForce(Vector2.up, ForceMode2D.Impulse);
        }
    }
}
