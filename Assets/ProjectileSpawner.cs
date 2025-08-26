using System.Collections;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform player; // cible
    public float minSpawnInterval = 1f;
    public float maxSpawnInterval = 3f;
    public float minSpeed = 5f;
    public float maxSpeed = 10f;

    void Start()
    {
        StartCoroutine(SpawnProjectiles());
    }

    IEnumerator SpawnProjectiles()
    {
        while (true)
        {
            float delay = Random.Range(minSpawnInterval, maxSpawnInterval);
            yield return new WaitForSeconds(delay);

            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            float speed = Random.Range(minSpeed, maxSpeed);

            // Donne la direction au projectile
            ProjectileMover mover = projectile.GetComponent<ProjectileMover>();
            if (mover != null)
            {
                mover.Init(player.position, speed);
            }
        }
    }
}
