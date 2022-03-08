using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float movementSpeed = 5f;
    float xMin, xMax, yMin, yMax;

    void Start ()
    {
        SetBorders();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX, xMin + (transform.localScale.x / 2), xMax - (transform.localScale.x / 2));
        var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        var newPosY = Mathf.Clamp(transform.position.y + deltaY, yMin + (transform.localScale.y / 2), yMax - (transform.localScale.y / 2));
        transform.position = new Vector2 (newPosX, newPosY);
    }

    private void SetBorders()
    {
        xMin = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0)).x;
        xMax = Camera.main.ViewportToWorldPoint (new Vector2 (1, 0)).x;
        yMin = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0)).y;
        yMax = Camera.main.ViewportToWorldPoint (new Vector2 (0, 1)).y;
    }
}
