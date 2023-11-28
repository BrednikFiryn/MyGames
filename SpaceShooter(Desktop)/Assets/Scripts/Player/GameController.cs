using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject _hazard;
    public Vector3 _spawnValues;
    public float _timeToSpawnMax;
    private float _timeToSpawn;

    public PlayerDeath playerDeath;

    private void Start()
    {
        playerDeath = FindObjectOfType<PlayerDeath>();
        _timeToSpawn = _timeToSpawnMax;
    }

    void Update()
    {

        if (playerDeath._PlayerLife != null)
        {
            SpawnWaves();
        }
    }

    private void SpawnWaves()
    {
        _timeToSpawn -= Time.deltaTime;
        if (_timeToSpawn <= 0)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-_spawnValues.x, _spawnValues.x), _spawnValues.y, _spawnValues.z);
            Quaternion spawnRotation = Quaternion.identity;

            Instantiate(_hazard, spawnPosition, spawnRotation);
            _timeToSpawn = _timeToSpawnMax;
        }
    }
}
