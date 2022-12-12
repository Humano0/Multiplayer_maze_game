using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float moveSpeed = 1.4f;
    void Start()
    {
        transform.Translate(new Vector3(-7.85f, 4.36f, -1));
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(new Vector3(0, moveSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(new Vector3(0, -moveSpeed * Time.deltaTime, 0));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Walls")
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0));
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.Translate(new Vector3(0, -moveSpeed * Time.deltaTime, 0));
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Translate(new Vector3(0, moveSpeed * Time.deltaTime, 0));
            }
        }
    }
}
