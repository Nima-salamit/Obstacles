using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float xValue = 0f;

    [SerializeField] private float yValue = 0f;

    [SerializeField] private float zValue = 0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);
    }
}
