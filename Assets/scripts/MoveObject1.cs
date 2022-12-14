using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject1 : MonoBehaviour
{
    public float delta = 10f;
    public float speed = 6f;
    private Vector3 _startPos;

    void Start()
    {
        _startPos = transform.position;
    }

    void Update()
    {
        Vector3 v = _startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
