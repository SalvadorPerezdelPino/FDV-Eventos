using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public Slider playerHealth;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            animator.SetTrigger("Attack");
            playerHealth.value = Mathf.Clamp01(playerHealth.value - 0.2f);
        }
    }
}
