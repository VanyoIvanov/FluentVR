using UnityEngine;
using UnityEngine.AI;

public class Follow : MonoBehaviour
{
    public Transform player;
    Animator animator;
    NavMeshAgent agent;

    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.SetDestination(player.position);
        animator.SetBool("idle", agent.remainingDistance <= agent.stoppingDistance);
    }
}
