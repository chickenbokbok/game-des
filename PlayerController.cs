using System;
using System.Diagnostics;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool isMoving;
    public Vector2 input;

    //Start is called before the first frame update
    void Start()
    {

    }

    //Update is called once per frame
    private void Update()
    {
        if (!isMoving)
        {

            float moveX = Input.GetAxisRaw("Horizontal");
            float moveY = Input.GetAxisRaw("Vertical");
            
            Vector2 move = new Vector2(moveX, moveY);
            transform.Translate(move * moveSpeed * Time.deltaTime);



            }



        }
}
