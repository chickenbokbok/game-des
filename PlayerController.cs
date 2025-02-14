using System;
using System.Collections;
using System.Numerics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public bool isMoving;
    public UnityEngine.Vector2 input;

    //Update is called once per frame
    private void Update()
    {
        if (!isMoving)
        {

            input.X = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");
            if (input != UnityEngine.Vector2.Zero)
            {
                var targetPos = transform.position;
                targetPos.x += input.x;
                targetPos.y += input.y;

                Coroutine coroutine = StartCoroutine(Move(targetPos));


            }



        }
    }

    private IEnumerator Move(UnityEngine.Vector3 targetPos)
    {
        throw new NotImplementedException();
    }

    IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true;
        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            targetPos = Vector3.MoveTowards(targetPos, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPos;
        isMoving = false;

    }
}
