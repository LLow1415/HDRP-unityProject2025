using UnityEngine;

public class EnemyChasing : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    public float stoppingDistance = 0.5f;
    public float activationDistance = 5f;

    [HideInInspector]
    public bool isPlayerHiding = false;

    private Patrolling patrolling;

    void Start()
    {
        patrolling = GetComponent<Patrolling>();
    }

    void Update()
    {
        if (target == null)
        {
            patrolling.StartPatrolling();
            return;
        }

        float distanceToPlayer = Vector3.Distance(transform.position, target.position);

        if (!isPlayerHiding && distanceToPlayer <= activationDistance && distanceToPlayer > stoppingDistance)
        {
            FollowTarget();
        }
        else
        {
            patrolling.StartPatrolling();
        }
    }

    void FollowTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}