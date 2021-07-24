using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float _FowerdSpeed = 25.0f;
    public float _StrafeSpeed = 7.5f;
    public float _HoverSpeed = 5.0f;

    public float _LookRateSpeed = 90.0f;
    public float _RollAcceleration = 3.5f;
    public float _RollSpeed = 90f;

    private float _ActiveFowerdSpeed;
    private float _ActiveStrafeSpeed;
    private float _ActiveHoverSpeed;

    private float _FowerdAcceleration = 2.5f;
    private float _StrafeAcceleration = 2.0f;
    private float _HoverAcceleration = 2.0f;

    private Vector2 _LookInput;
    private Vector2 _ScreenCenter;
    private Vector2 _MouseDistance;
    private float _RollInput;



    private void Start()
    {
        _ScreenCenter.x = Screen.width * 0.5f;
        _ScreenCenter.y = Screen.height * 0.5f;

        Cursor.lockState = CursorLockMode.Confined;
    }

    private void Update()
    {

        _LookInput.x = Input.mousePosition.x;
        _LookInput.y = Input.mousePosition.y;

        _MouseDistance.x = (_LookInput.x - _ScreenCenter.x) / _ScreenCenter.y;
        _MouseDistance.y = (_LookInput.y - _ScreenCenter.y) / _ScreenCenter.y;

        _MouseDistance = Vector2.ClampMagnitude(_MouseDistance, 2f);

        _RollInput = Mathf.Lerp(_RollInput, Input.GetAxisRaw("Horizontal"), _RollAcceleration * Time.deltaTime);

        transform.Rotate(-_MouseDistance.y * _LookRateSpeed * Time.deltaTime,
                        _MouseDistance.x * _LookRateSpeed * Time.deltaTime,
                        _RollInput * _RollSpeed * Time.deltaTime, Space.Self);
        

      _ActiveFowerdSpeed = Mathf.Lerp(_ActiveFowerdSpeed, Input.GetAxisRaw("Vertical") * _FowerdSpeed, _FowerdAcceleration * Time.deltaTime);
        _ActiveStrafeSpeed = Mathf.Lerp(_ActiveStrafeSpeed, Input.GetAxisRaw("Roll") * _StrafeSpeed, _StrafeAcceleration * Time.deltaTime);
        _ActiveHoverSpeed = Mathf.Lerp(_ActiveHoverSpeed, Input.GetAxisRaw("Hover") * _HoverSpeed, _HoverAcceleration * Time.deltaTime);

        transform.position += transform.forward * _ActiveFowerdSpeed * Time.deltaTime;
        transform.position += transform.right * _ActiveStrafeSpeed * Time.deltaTime;
        transform.position += transform.up * _ActiveHoverSpeed * Time.deltaTime;
    }
}
