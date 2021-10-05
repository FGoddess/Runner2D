using UnityEngine;

public class EnemySpawner : ObjectPool
{
    [SerializeField] private int _spawnRepeatRate;
    [SerializeField] private GameObject[] _enemyPrefabs;
    [SerializeField] private Transform[] _spawnPoints;

    private void Start()
    {
        Initialize(_enemyPrefabs);
        _spawnPoints = GetComponentsInChildren<Transform>();
        InvokeRepeating(nameof(SpawnEnemy), 2, _spawnRepeatRate);
    }

    private void SpawnEnemy()
    {
        if (TryGetObject(out GameObject enemy))
        {
            enemy.SetActive(true);
            enemy.transform.position = _spawnPoints[Random.Range(0, _spawnPoints.Length)].position;
        }
    }
}
