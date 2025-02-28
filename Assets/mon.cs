using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monnai_Bronze : MonoBehaviour
{
    [SerializeField] GameObject _prefabOriginal;

    void Start()
    {
    }
    private void Update()
    {
        transform.rotation = Random.rotation;
        Instantiate(_prefabOriginal, transform.position, transform.rotation);

    }
}
