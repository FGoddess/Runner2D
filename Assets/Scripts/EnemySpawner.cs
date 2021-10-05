using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private int _spawnRepeatRate;
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;

    private void Start()
    {
        _spawnPoints = GetComponentsInChildren<Transform>();
        InvokeRepeating(nameof(SpawnEnemy), 2, _spawnRepeatRate);
    }

    private void SpawnEnemy()
    {
        Instantiate(_enemyPrefab, _spawnPoints[Random.Range(0, _spawnPoints.Length)]);
    }
}
