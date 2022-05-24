using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mehu : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent enemy;
    public Transform player;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Score.Scores == 3)
        {
            enemy.SetDestination(player.position);
        }
    }
}
