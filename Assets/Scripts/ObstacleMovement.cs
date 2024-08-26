using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement(){

        this.transform.position += Vector3.left * Time.deltaTime;
    }
}
