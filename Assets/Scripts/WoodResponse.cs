using UnityEngine;

public class WoodResponse : MonoBehaviour
{
    public Transform player;
    private Transform goal;
    public MeatNotifier meat;
    public float speed = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meat.OnMeatEaten += FollowPlayer;
        goal = transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = goal.position - transform.position;
        float distance = direction.magnitude;
        if (distance > 0.0001f)
        {
            transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
    }

    void FollowPlayer()
    {
        goal = player;
    }
}
