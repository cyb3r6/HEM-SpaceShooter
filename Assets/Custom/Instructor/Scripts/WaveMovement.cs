using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 15;
    [SerializeField]
    private float frequency = 12;
    [SerializeField]
    private float amplitude = 6;

    void Update()
    {
        float horizontalMovement = Mathf.Sin(Time.time * frequency) * amplitude;
        Vector3 movement = (Vector3.up * speed + Vector3.right * horizontalMovement) * Time.deltaTime;
        transform.Translate(movement);
    }
}
