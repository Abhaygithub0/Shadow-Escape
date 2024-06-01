using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
   public float  Playerhealth ;
   public float currentHealth ;
    float Damage = 1;
    [SerializeField] Image image;
    [SerializeField] GameObject GameOverUI;
    [SerializeField] PlayerController controller;
    [SerializeField] CameraFollow Camera;

    private void Start()
    {
        currentHealth=Playerhealth;
    }
    private void Update()
    {
        image.fillAmount = currentHealth / 10;

    }
    public void TakeDamage ()
    {
        currentHealth = Mathf.Max(currentHealth - Damage, 0);
       
       
        Playerhealth = currentHealth;
        if (Playerhealth <= 0)
        {
           

            Die();

        }
    }
    public void Die()
    {
            controller.enabled = false;
            Camera.enabled = false;
            GameOverUI.SetActive(true);
    }

}
 