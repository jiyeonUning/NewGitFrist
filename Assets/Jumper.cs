using UnityEngine;

public class Jumper : MonoBehaviour
{
    public float jumpPower;
    public Rigidbody rigidbody;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
}
