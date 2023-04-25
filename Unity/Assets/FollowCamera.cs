using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;

    public bool followingTarget = false;
    // Start is called before the first frame update
    void Start()
    {
            target = GameObject.Find("Pod").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (followingTarget)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime);
            transform.LookAt(target.parent);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            followingTarget = false;
        }

        Debug.Log(followingTarget);
    }
}
