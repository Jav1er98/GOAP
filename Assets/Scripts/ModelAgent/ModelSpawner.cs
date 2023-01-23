using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSpawner : MonoBehaviour
{
   [SerializeField] private GameObject _modelPrefab;

    private void OnEnable()
    {
        LeaveModelShow.OnModelDestroyed += SpawnModel;
    }

    private void OnDisable()
    {
        LeaveModelShow.OnModelDestroyed -= SpawnModel;
    }

    private void Start()
    {
        SpawnModel();
    }

    public void SpawnModel()
    {
        Instantiate(_modelPrefab, transform.position, Quaternion.identity);
    }
}
