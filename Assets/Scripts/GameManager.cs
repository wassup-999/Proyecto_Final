using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject Prefabtablas;
    void Start()
    {
        
    }

    void Update()
    {
        DetecMouse();       
    }

    
    private void DetecMouse()
    {
        Vector2 MousePos = Input.mousePosition;
        Vector3 Gamepos = Camera.main.ScreenToWorldPoint(MousePos);
        //print(Gamepos);    
        
        if (Input.GetMouseButtonDown(0))
        {
            Gamepos.z = 0;
         
            Debug.Log("Se spawneo tabla");
            GameObject TablaPrefab =Instantiate(Prefabtablas, Input.mousePosition, Quaternion.identity);
            TablaPrefab.transform.position = Gamepos;
        }
        
    }  
}
