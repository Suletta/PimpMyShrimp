using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    // variables
    [Tooltip("when active spawn bullet")]
    public bool spawn = true;
    [Tooltip("Bullet prefab")]
    public AxolotlBullet bullet;
    [Tooltip("Angle of spawn of bullet")]
    public float minRotation, maxRotation;
    [Tooltip("Time of spawn")]
    public float rate;
    public float bulletSpeed;
    [Tooltip("Number of bullet spawned simultaneously")]
    public int numberOfBullet;

    private float timer = 0;
    [Tooltip("Just don't touch")]
    public float[] rotations ;

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
