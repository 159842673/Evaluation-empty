using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class SnakeController : MonoBehaviour
{
    private bool isAlive = true;
    private bool fruitEaten = true ;
    Rigidbody2D emptySpace;
    

    void Start()
    {
        GameObject tail = new GameObject();
        StartCoroutine(Move());
        //Instantiate(tail, transform.position(1, 0, 0),transform.rotation);
    }
   
    public IEnumerator Move()
    {
        emptySpace = gameObject.AddComponent<Rigidbody2D>();
        yield return new WaitForEndOfFrame();
       
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        //var position = new Vector2();

    }
    void AddTailPart(Vector2 newPartPosition)
    {
        if (fruitEaten == false)
        {

        }
        else (fruitEaten == true)


    }
    void Die()
    {
  
        if (isAlive == false)
        {
            Destroy(gameObject);
           //Destroy(AddTailPart);
        }
    }
}
