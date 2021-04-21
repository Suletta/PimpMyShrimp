using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    // variables
    [Tooltip("when active spawn bullet")]
    public bool spawn = true;
    [Header("Bullet Variable")]
    [Tooltip("Bullet prefab")]
    public AxolotlBullet bullet;
    [Range(0, 100)]
    public float bulletSpeed;
    [Header("Spawn Variable")]
    [Tooltip("Min. Angle of spawn of bullet")]
    public float minRotation;
    [Tooltip("Max. Angle of spawn of bullet")]
    public float maxRotation;
    [Tooltip("Number of bullet spawned simultaneously")]
    [Range(0, 100)]
    public int numberOfBullet;
    [Tooltip("Time of spawn")]
    [Range(0f, 5f)]
    public float rate;

    private float timer = 0;
    [Tooltip("Just don't touch")]
    private float [] rotations = new float [100];


    private void Update()
    {
        if (spawn)
        {
            SetRotations();
            if (timer >= rate)
            {
                SpawnBullet();
                timer = 0;
            }
            timer += Time.deltaTime;
        }
    }

    // definisce la rotazione dei proiettili(la loro direzione)
    private float[] SetRotations()
    {
        for (int i = 0; i < numberOfBullet; i++)
        {
            var fraction = (float)i / (float)numberOfBullet;
            var difference = maxRotation - minRotation;
            var fdd = fraction * difference;
            rotations[i] = fdd + minRotation;
        }
        return rotations;
    }


    private void SpawnBullet()
    {
        for (int i = 0; i < numberOfBullet; i++)
        {
            AxolotlBullet b = Instantiate(bullet,new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler (0,0,0 ), transform );
            b.speed = bulletSpeed;
            b.rotation = rotations[i];
            Destroy(b.gameObject, 10);
        }
    }
}
