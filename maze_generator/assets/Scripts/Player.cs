using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Player : MonoBehaviour
{
    public float moveSpeed = 2;

    PhotonView view;
    public void Start()
    {
        view = GetComponent<PhotonView>();
    }
    public void Update()
    {
        if (view.IsMine)
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
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (view.IsMine)
        {
            if (collision.gameObject.tag == "Walls")
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
}
