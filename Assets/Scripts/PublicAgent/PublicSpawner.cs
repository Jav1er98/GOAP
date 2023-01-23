using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicSpawner : MonoBehaviour
{
   [SerializeField] private GameObject _publicPrefab;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnPublic), 0, Random.Range(1, 20));
    }
    
    private void SpawnPublic()
    {
        StartCoroutine(nameof(DelayedSpawnPublic));
    }
    
    private IEnumerator DelayedSpawnPublic()
    {
        yield return new WaitForSeconds(Random.Range(0, 2));
        Instantiate(_publicPrefab, transform.position, Quaternion.identity);
    }
}
