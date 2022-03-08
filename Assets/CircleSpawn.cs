using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawn : MonoBehaviour
{
    public GameObject circlePrefab;
    Vector2 spawnPos;
    float x, y, xMin, xMax, yMin, yMax;

    void Start()
    {
        SetBorders();
        StartPos();
    }

    private void StartPos()
    {
        x = Random.Range(xMin + 1, xMax - 1);
        y = Random.Range(yMin + 1, yMax - 1);
        spawnPos = new Vector2(x, y);
        transform.position = new Vector2(x, y);
        CheckPos();
    }

    private void SetBorders()
    {
        xMin = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0)).x;
        xMax = Camera.main.ViewportToWorldPoint (new Vector2 (1, 0)).x;
        yMin = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0)).y;
        yMax = Camera.main.ViewportToWorldPoint (new Vector2 (0, 1)).y;
    }

    void CheckPos()
    {
        Collider2D other = Physics2D.OverlapCircle(spawnPos, 1f);
        if (other != null) {
            StartPos();
        }
        
        else {
            GameObject Circle = Instantiate(circlePrefab, spawnPos, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
