using UnityEngine;

public class Spawner : MonoBehaviour
{
    private Spawner spawner;
    private void Start()
    {
        spawner = GetComponent<Spawner>();
    }
}
