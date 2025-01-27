using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private SphereCollider ballCollider;
    [SerializeField] private float ballSpeed;
    [SerializeField] private float jumpForce;

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new Vector3(input.x,0, input.y); //get new 3D vector, y in 2d is the z in 3d
        sphereRigidbody.AddForce(inputXZPlane*ballSpeed); //apply force on ball
    }
    public void jumpBall(Vector3 input) 
    {
        if (isGrounded()) 
        { 
            Vector3 inputYPlane = new Vector3(0,input.y,0); //get new 3D vector
            sphereRigidbody.AddForce(inputYPlane * jumpForce); //apply force on ball
        }
    }
    // detacet on ground
    private bool isGrounded()
    {
        float raycastDistance = ballCollider.radius+0.1f;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, raycastDistance))
        {
            if (hit.collider.CompareTag("Ground"))
            {
                return true;
            }
        }
        return false;
    }
}
