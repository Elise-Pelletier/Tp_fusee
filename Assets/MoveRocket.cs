using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MoveRocket : MonoBehaviour
{
    public bool monte;
    public float vitesse = 0.5f;

    public GameObject explosion;

    public void JumpKeyPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            monte = true;
        }
        else if (context.canceled)
        {
            monte = false;
        }

    }
    public void Update()
    {
        if (monte)
        {
            if (transform.position.y < 17.33f)
            {
                transform.position += new Vector3(0, 1, 0) * vitesse * Time.deltaTime;

            }

        }
        else
        {
            if (transform.position.y > -2.88)
            {
                transform.position -= new Vector3(0, 1, 0) * vitesse * Time.deltaTime;
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);

        print("BOOM!!!!");
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}  