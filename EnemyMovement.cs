using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector2 _direction;

    private void FixedUpdate()
    {
        Init();
        transform.Translate(_speed * _direction * Time.deltaTime, Space.World);
    }

    public void Init()
    {
        _direction = Vector2.left;
    }
}