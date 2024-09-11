using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cmareaaa : MonoBehaviour
{
    public Vector3 Offset;

    public float CamSpeed = 2f;
    public Transform target;
    // Update is called once per frame
    void Update()
    {
        Vector3 Offset = target.position;
        Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, CamSpeed * Time.deltaTime);
    }
}
