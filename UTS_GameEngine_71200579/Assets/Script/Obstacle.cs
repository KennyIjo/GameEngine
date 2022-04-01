using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 2f;
    public float strength = 3f;

    private float randomOffset;
    // Start is called before the first frame update
    void Start()
    {
        randomOffset = Random.Range(0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y = Mathf.Sin(Time.time * speed + randomOffset) * strength;
        transform.position = pos;
    }
}