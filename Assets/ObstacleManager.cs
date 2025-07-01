using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstacle;
    public float delaiSpawn;


    public void Start()
    {
        Instantiate(obstacle, transform.position, obstacle.transform.rotation);
        InvokeRepeating(methodName: "Spawn", time: 0f, repeatRate: delaiSpawn);
    }

    private void Spawn()
    {
        float random = Random.Range(0f, 1f);

        if (random < 0.5f)
        {
            Instantiate(obstacle, transform.position, obstacle.transform.rotation);
        }
        else
        {

        }
    }



}
