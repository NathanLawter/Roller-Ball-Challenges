using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    private int count;
    private int score;
    public float speed;
    public Text AllText;
    public Text countText;
    public Text scoreText;
    public Text winText;
    public GameObject Player;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
        score = 0;
        SetScoreText();
        scoreText.text = "";
    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            score = score + 1;
            SetCountText();

        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            score = score - 1;
            SetScoreText();
        }
        if (count == 16)
        {
            transform.position = new Vector3(8.69f, Player.transform.position.y, -12.82f);
        }
        if (other.gameObject.CompareTag("Bad Wall"))
        {
            score = score - 1;

        }
    }
    void SetCountText()
    {
        countText.text = "Pickups: " + count.ToString();
        if (count >= 16)
        {
            winText.text = "You finished with " + count.ToString() + " pickups!";
        }

    }
    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}