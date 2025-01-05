using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public float myMaxHP = 3f;
    public float myHP;
    public HealthBar healthbar;
    public GameObject gameOver;

    private void Awake()
    {
        healthbar = GetComponentInChildren<HealthBar>();
    }

    private void Start()
    {
        myHP = myMaxHP;
    }

    public void PlayerHurt()
    {
        myHP -= 1;
        healthbar.ChangeSlider(myHP, myMaxHP);
        if (myHP <= 0)
        {
            Destroy(gameObject);
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
