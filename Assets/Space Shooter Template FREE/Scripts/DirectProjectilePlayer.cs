using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectProjectilePlayer : MonoBehaviour
{
    public float speed;
    private Vector3 playerDestination;

    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerDestination = player.transform.position - this.transform.position;
    }

    private void Update()
    {
        //transform.LookAt(playerDestination, Vector3.up);
        // transform.Translate(Vector3.up * speed * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, playerDestination + new Vector3(0, 0, 0), speed * Time.deltaTime);
    }
}
