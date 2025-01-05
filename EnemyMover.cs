using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _direction;

    private void FixedUpdate()
    {
        Init();
        transform.Translate(_speed * _direction * Time.deltaTime, Space.World);
    }

    public void Init()
    {
        _direction = Vector3.left;
    }
}