
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    [SerializeField] private GameObject[] itens; // Array para os prefabs
    public GameManager gameManager; // Referência ao GameManager

    void Start()
    {
        InvokeRepeating("CreateObject", 1f, 1f);
    }

    public void CreateObject()
    {
        // Só cria itens se o jogo tiver começado
        if (gameManager.startGame == true)
        {
            int index = Random.Range(0, itens.Length);

            Vector3 spawnPosition = new Vector3(
                Random.Range(-8f, 8f),
                8f,
                0f
            );

            Instantiate(itens[index], spawnPosition, Quaternion.identity);
        }
    }
}