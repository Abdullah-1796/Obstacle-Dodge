using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] Transform player;
    private Vector3 playerPosition;

    void Start()
    {
        playerPosition = player.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
