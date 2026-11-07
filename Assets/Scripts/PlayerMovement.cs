using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public InputActionReference moveAction;
    public SpriteRenderer playerSprite;
    public Animator playerAnimator;
    public float speed = 5.0f;
    Vector2 direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        direction = moveAction.action.ReadValue<Vector2>();
        transform.Translate(direction * speed * Time.deltaTime);
        if (direction.x < 0)
        {
            playerSprite.flipX = true;
        } 
        else if (direction.x > 0) 
        {
            playerSprite.flipX = false;
        }

        if (direction.magnitude != 0)
        {
            playerAnimator.SetBool("isRunning", true);
        }
        else
        {
            playerAnimator.SetBool("isRunning", false);
        }
    }
}
