using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidControl : MonoBehaviour
{
    public float speed = 50.0f;

    public bool controlling = false;

    public ObstacleAvoidance obstacleAvoidance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controlling)
        {
            float contWalk = Input.GetAxis("Vertical");
            float contStrafe = Input.GetAxis("Horizontal");
            Walk(contWalk * speed * Time.deltaTime);
            Strafe(contStrafe * speed * Time.deltaTime);
        }
    }

    void Walk(float units)
    {
        Vector3 forward = this.transform.forward;
        //forward.y = 0;
        forward.Normalize();
        transform.position += forward * units;
    }

    void Strafe(float units)
    {
        transform.position += this.transform.right * units;

    }

    void SwitchControlTrue()
    {
        controlling = true;

    }
}
