
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;

    public Rigidbody2D rb;
    public SpriteRenderer playerSprite;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public GameObject platformPrefab;
    public TMP_Text resultText;

    public Vector2[] platformPos;

    private float moveX;
    private bool isGrounded;
    private bool gameOver = false;

    void Start()
    {
        resultText.text = "";
        for (int i = 0; i < platformPos.Length; i++)
        {
            Instantiate(platformPrefab, platformPos[i], Quaternion.identity);
        }
    }

    void Update()
    {
        if (gameOver)
        {
            return;
        }

        moveX = Input.GetAxisRaw("Horizontal");
        if (moveX > 0)
        {
            playerSprite.flipX = true;
        }
        else if (moveX < 0)
        {
            playerSprite.flipX = false;
        }
        isGrounded = Physics2D.OverlapCircle(
            groundCheck.position,
            0.2f,
            groundLayer
        );

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(
                rb.linearVelocity.x,
                jumpForce
            );
        }
        if (transform.position.y < -10f)
        {
            StartCoroutine(RestartAfterLose());
        }
    }

    void FixedUpdate()
    {
        if (!gameOver)
        {
            rb.linearVelocity = new Vector2(
                moveX * speed,
                rb.linearVelocity.y
            );
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!gameOver && other.CompareTag("Finish"))
        {
            gameOver = true;
            rb.linearVelocity = Vector2.zero;
            resultText.text = "You Win!";
        }
    }

    IEnumerator RestartAfterLose()
    {
        gameOver = true;
        rb.linearVelocity = Vector2.zero;
        resultText.text = "You Lose!";

        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }
}
