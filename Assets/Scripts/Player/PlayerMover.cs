using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _stepSize;
    [SerializeField] private float _maxY;
    [SerializeField] private float _minY;

    [SerializeField] private Vector3 _targetPosition;

    private void Start()
    {
        _targetPosition = transform.position;
    }

    private void Update()
    {
        if (transform.position != _targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _moveSpeed * Time.deltaTime);
        }
    }

    public void MoveUp()
    {
        if (_targetPosition.y < _maxY)
        {
            SetPosition(_stepSize);
        }
    }

    public void MoveDown()
    {
        if (_targetPosition.y > _minY)
        {
            SetPosition(-_stepSize);
        }
    }

    private void SetPosition(float value)
    {
        _targetPosition = new Vector3(_targetPosition.x, _targetPosition.y + value);
    }
}
