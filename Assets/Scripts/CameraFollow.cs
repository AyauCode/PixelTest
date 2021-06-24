using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform follow;
    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 pos = new Vector3(follow.position.x, this.transform.position.y, follow.position.z);
        this.transform.position = pos + offset;
    }
}
