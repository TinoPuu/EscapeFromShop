using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Kesäkurpitsa : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;
    bool canMove = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            enemy.SetDestination(player.position);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Terve");
        if (collision.gameObject.tag == "Player" && canMove == false)
        {
            canMove = true;
            Score.Scores += 1;
            Debug.Log("canMove");
        }
    }
}
