using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipes : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.65f;

    private void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }

}
