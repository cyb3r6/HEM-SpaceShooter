using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField]
    private float degrees;
    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 0, 1);
    }
}
