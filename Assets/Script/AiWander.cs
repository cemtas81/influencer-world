using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiWander : MonoBehaviour
{
    public float wanderRadius;
    public float wanderTimer;
    public bool cansee;
    private Transform target;
    private NavMeshAgent agent;
    private float timer;
    public GameObject player;

    // Use this for initialization
    private void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;
        cansee = false;
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= wanderTimer)
        {
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            agent.SetDestination(newPos);
            timer = 0;
        }
        if (cansee==true)
        {
            this.gameObject.transform.LookAt(player.transform.position);
        }
        if (player.activeSelf==false)
        {
            cansee = false;
            agent.isStopped = false;
        }
    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = UnityEngine.Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="detection")
        {
            cansee = true;
            agent.isStopped = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "detection")
        {
            cansee = false;
            agent.isStopped = false;
        }
    }
}
