using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform targetToFollow;
    float offsetY, offsetZ;
    // Start is called before the first frame update
    void Start()
    {
        offsetY = targetToFollow.position.y - transform.position.y;
        offsetZ = targetToFollow.position.z - transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(targetToFollow.position.x,
                                         targetToFollow.position.y - offsetY,
                                         targetToFollow.position.z - offsetZ);

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 4);

    }
}
