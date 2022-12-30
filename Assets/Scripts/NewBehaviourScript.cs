using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
    
{

    public float force;
    private Rigidbody2D rb;
    private Animator anim;
    private int Points;
    public Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ClickOnMouse();

        }
        else
        {
            anim.SetBool("Clicked", false);
        }
    }

    void ClickOnMouse()
    {
        rb.velocity = Vector2.up * force;
        anim.SetBool("Clicked", true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Pipe")
        {
            Points++;
            ScoreText.text = Points.ToString();
        }
    }
}
