using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        SleepWalkerRange();
    }
    public void SleepWalkerRange()
    {
        transform.position += Vector3.right * speed*Time.deltaTime;
        if (transform.position.x >= 9)
        {
            speed *= 0;
        }
        
    }
}
