using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private int _moveSpeed;

    private void Update()
    {
        transform.Translate(Vector3.left * _moveSpeed * Time.deltaTime);
    }
}
