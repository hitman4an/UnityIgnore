using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growing : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 newScale = transform.localScale;
        newScale += Vector3.one * (_speed * Time.deltaTime);

        transform.localScale = newScale;
    }
}