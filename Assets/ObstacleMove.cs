using UnityEngine;

public class ObstacleMove : MonoBehaviour
{

    public float vitesse = 0.3f;   // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Update()
    {
        transform.position -= new Vector3(1, 0, 0) * vitesse * Time.deltaTime;
    }

}
