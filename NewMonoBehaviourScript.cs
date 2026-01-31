using UnityEngine;

public class RoomSpawner : MonoBehaviour
{

    public GameObject roomPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            Instantiate(roomPrefab, Vector3.zero, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
