using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    
    [SerializeField]
    private Rigidbody _rb;
    [SerializeField]
    private Material _lightMaterial;
    [SerializeField]
    private Material _material;
    [SerializeField] 
    private Renderer _renderer;

    private float _moveHorizontal;
    private float _moveVertical;

    [SerializeField] 
    private BlockType _type;

    private Vector3 _movement;

    public void Init(float speed, Material light, Material mat, BlockType type)
    {
        _rb = GetComponent<Rigidbody>();
        _renderer = GetComponent<Renderer>();
        
        _renderer.material = mat;

        _type = type;
        
        _speed = speed;
        
        _lightMaterial = light;
        _material = mat;
    }
    
    public void Init(float speed, BlockDes des)
    {
        Init(speed, des.LightMaterial, des.Material, des.Type);
    }

    private void Update()
    {
        _moveHorizontal = Input.GetAxis("Horizontal");
        _moveVertical = Input.GetAxis("Vertical");
        
        _movement = new Vector3(_moveHorizontal, 0.0f, _moveVertical);
    }

    private void FixedUpdate()
    {
        MovementLogic();
    }

    private void MovementLogic()
    {
        _rb.MovePosition(_rb.position + _movement * (_speed * Time.fixedDeltaTime));
    }
}
