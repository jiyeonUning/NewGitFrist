using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerCamera : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;

    private void Update()
    {
        transform.position = target.position + offset;
        transform.LookAt(transform.position);
    }
}
