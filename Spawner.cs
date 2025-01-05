using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _spawner;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _spawnTime;

    private void Start()
    {
        StartCoroutine(Spawning());
    }

    private IEnumerator Spawning()
    {
        while (enabled)
        {
            Instantiate(_enemy, _spawner.position, Quaternion.identity);
            
            yield return new WaitForSeconds(_spawnTime);
        }
    }
}