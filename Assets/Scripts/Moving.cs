using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float playerSpeed = 15f;
    private float horizontalInput;
    private float verticalInput;
    public float xRange = 10f;
    public float forwadRange = 10.0f;
    public float backwardsRange = 0f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        //moving on sides
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * playerSpeed * Time.deltaTime);
        //moving forward
        if (transform.position.z < backwardsRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, backwardsRange);
        }
        if (transform.position.z > forwadRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, forwadRange);
        }
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * playerSpeed * Time.deltaTime);
    }
}
