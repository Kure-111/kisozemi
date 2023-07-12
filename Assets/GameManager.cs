using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    bool okdesu = false;
    bool start = true;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && start)
        {
            start = false;
            SpawnAnimal();
        }
        if (Input.GetKeyDown(KeyCode.Q) && okdesu)
        {
            SpawnAnimal();
            okdesu = false;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.01f, transform.position.z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.01f, transform.position.z);
        }
    }

    public void SpawnAnimal()
    {
        int index = Random.Range(0, animalPrefabs.Length);
        GameObject spawnedAnimal = Instantiate(animalPrefabs[index], transform.position, Quaternion.identity);
    }
    public void ok()
    {
        okdesu = true;
    }
}


