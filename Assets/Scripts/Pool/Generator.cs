using UnityEngine;

public class Generator : Pool
{
    [SerializeField] private GameObject _template;
    [SerializeField] private float _timeBetweenSpawn;
    
    private float _elapsedTime = 0;

    private void Start()
    {
        Init(_template);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime > _timeBetweenSpawn)
        {
            if (TryGetObject(out GameObject prefab))
            {
                _elapsedTime = 0;
                Vector2 spawnPoint = new Vector2(transform.position.x, transform.position.y);
                prefab.SetActive(true);
                prefab.transform.position = spawnPoint;

                DisableBehindCamera();
            }
        }
    }
}
