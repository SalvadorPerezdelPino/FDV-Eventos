using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public Slider playerHealth;
    public Animator animator;
    public Transform castle;
    private Transform goal;
    public float speed = 3.0f;
    public ButtonHandler backButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        goal = transform;
        backButton.onCastleBack.AddListener(GoCastle);
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            animator.SetTrigger("Attack");
            playerHealth.value = Mathf.Clamp01(playerHealth.value - 0.2f);
        }
    }

    private void GoCastle()
    {
        goal = castle;
    }
}
