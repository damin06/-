using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textmove : MonoBehaviour
{
    [SerializeField]
    //privait public protected
    public float _speed = 5f;
    private Rigidbody2D _rb = null;
    private Transform _transform = null;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _transform = transform;

    }

    // Update is called once per frame
    void Update()
    {


    }
    private void RigidMove()
    {
        float hori = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");
        Vector2 dir = new Vector2(hori, verti);
        _rb.velocity = dir * _speed;
    }
    //    private void OnAnimatorMove()
    //    //{
    //    //    Input.GetAxisRaw("Horizontal");
     
    //    //    Vector2 dir = hori * transform.right + verti * transform.up;

    //    //    _transform.Translate(dir.normalized * Time.deltaTime * _speed);
    //    //}

}