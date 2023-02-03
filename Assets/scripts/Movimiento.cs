using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] private float _velocidad;

    private Rigidbody2D _rigidbody2D;
    private Vector2 _input;
    private Vector2 _direccionMovimiento;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        //x

        if (_input.x > 0.1f)
        {

            _direccionMovimiento.x = 1f;

        }

        else if (_input.x < 0)
        {

            _direccionMovimiento.x = -1f;

        }
        else
        {

            _direccionMovimiento.x = 0f;

        }

        //y

        if (_input.y > 0.1f)
        {

            _direccionMovimiento.y = 1f;

        }

        else if (_input.y < 0)
        {

            _direccionMovimiento.y = -1f;

        }
        else
        {

            _direccionMovimiento.y = 0f;

        }

    }

    private void FixedUpdate()
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + _direccionMovimiento * _velocidad * Time.fixedDeltaTime);
    }
}
