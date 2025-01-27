using UnityEngine;
using UnityEngine.Events;

public class Jump : MonoBehaviour
{
    public UnityEvent<Vector3> onJump = new UnityEvent<Vector3>();//Creat event of on jump
    
    // Update is called once per frame
    void Update()
    {
        Vector3 inputVector = Vector3.zero; // intialize our input vector
        if (Input.GetKey(KeyCode.Space))
        {
            inputVector += Vector3.up;
        }
        
        onJump?.Invoke(inputVector); //send data by event
    }
}
