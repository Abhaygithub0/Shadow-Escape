using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f; 
    [SerializeField] private float jumpForce = 10f; 
    [SerializeField] PlayerHealth playerhealth;
    [SerializeField] CoinCollector coincollector;
    [SerializeField] CheckPoint checkpoints;
    private Rigidbody rb;
    private bool isGrounded;
   

    private void Start()
    {
       
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        PlayerMove();
        PlayerJump();
    }
    void PlayerMove()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 moveDirection = new Vector2(horizontalInput, 0f) * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, rb.velocity.y);
    }
    void PlayerJump()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag("DeathZone"))
        {
            rb.drag = 100;
            playerhealth.Die(); 
            playerhealth.currentHealth = 0;
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            
            playerhealth.TakeDamage();
        }

        if (collision.gameObject.CompareTag("CheckPointObsticles"))
        {
            playerhealth.TakeDamage();
            checkpoints.Respawn();
           
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coincollector.incrementvalue(10);
            
        }
    }


}
