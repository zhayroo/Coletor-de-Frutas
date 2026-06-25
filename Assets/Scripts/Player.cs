
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public GameManager gameManager;

    void Update()
    {
        if (gameManager == null || !gameManager.startGame)
            return;

        float x = 0f;

        if (Input.GetKey(KeyCode.A)) x = -1f;
        if (Input.GetKey(KeyCode.D)) x = 1f;

        transform.position += Vector3.right * x * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameManager == null) return;

        if (other.CompareTag("Fruit"))
        {
            Destroy(other.gameObject);
            gameManager.score += 10;
        }

        if (other.CompareTag("Damage"))
        {
            gameManager.GameOver();
            Destroy(gameObject);
        }
    }
}