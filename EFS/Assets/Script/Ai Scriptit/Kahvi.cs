using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Kahvi : MonoBehaviour
{
    [SerializeField]
    GameManager gm;
    public NavMeshAgent enemy;
    public Transform player;
    bool canMove = false;
    public AudioSource aani;
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
            aani.Play();
            canMove = true;
            gm.increasePoints();
            Debug.Log("canMove");
        }
    }
}
