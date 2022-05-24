using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spaghetti : MonoBehaviour
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
        if (Score.Scores == 1)
        {
            Debug.Log("1");
            enemy.SetDestination(player.position);
        }
        
    }
}
