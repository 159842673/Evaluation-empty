using UnityEngine;

public class Fruit : MonoBehaviour
{
    public BoxCollider2D playZone;
    GameObject manger;
    Vector2Int MaxSpawnpos;
    private void Start()
    {
        var minSpawnpos = new Vector2Int(-17, 9);
        var floatPositionmin = (Vector2)minSpawnpos;
        transform.position = floatPositionmin;
        var maxSpawnPos = new Vector2Int(17, 9);
        var floatPositionmax = (Vector2)maxSpawnPos;
        transform.position = floatPositionmax;

    }
    void Update()
    {
        SpawnFruit();
    }
    void SpawnFruit()
    {
        //var position = new Vector2(Random.Range(minSpawnpos),Random.Range(MaxSpawnpos));
        //Instantiate(manger, randomPos, Quaternion.identity);

    }
}
