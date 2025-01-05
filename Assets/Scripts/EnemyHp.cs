using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    public float enemyMaxHealth = 3.0f;
    public float enemyCurrenHealth;
    public PlayerHP playerhp;
    public HealthBar healthBar;
    public PointsManager pointsManager;
    public Camera myCamera;
    

    private void Awake()
    {
        healthBar = GetComponentInChildren<HealthBar>();
        myCamera = Camera.main;
    }

    private void Start()
    {
        enemyCurrenHealth = enemyMaxHealth;

    }

    public void takeDamage(int damage)
    {
        enemyCurrenHealth -= damage;
        healthBar.ChangeSlider(enemyCurrenHealth, enemyMaxHealth);
        if (enemyCurrenHealth <= 0 )
        {
            myCamera.GetComponent<PointsManager>().AddPoint(enemyMaxHealth);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pizza"))
        {
            Destroy(other.gameObject);
            takeDamage(1);
        }
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject player = other.gameObject;
            player.GetComponent<PlayerHP>().PlayerHurt();
        }

    }
}
