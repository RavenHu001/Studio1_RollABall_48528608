using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed;
 
    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new Vector3(input.x,0, input.y); //get new 3D vector, y in 2d is the z in 3d
        sphereRigidbody.AddForce(inputXZPlane*ballSpeed); //apply force on ball
    }
}
