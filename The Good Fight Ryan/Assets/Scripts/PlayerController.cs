using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float _XMin, _XMax, _ZMin, _ZMax;
}

public class PlayerController : MonoBehaviour
{

    public Rigidbody _RB;
    public float speed;
    public Boundary _Boundary;

    public float _Tilt;

    void Start()
    {
        _RB = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0.0f, vertical);
        _RB.velocity = movement * speed;
        _RB.position = new Vector3
            (
                Mathf.Clamp(_RB.position.x, _Boundary._XMin, _Boundary._XMax),
                0.0f,
                Mathf.Clamp(_RB.position.z, _Boundary._ZMin, _Boundary._ZMax)
            );
        _RB.rotation = Quaternion.Euler(0.0f, 0.0f, _RB.velocity.x * -_Tilt);

    }

}
