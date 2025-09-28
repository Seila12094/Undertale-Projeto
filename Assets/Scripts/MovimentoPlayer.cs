using UnityEngine;
using UnityEngine.InputSystem;

public class MovimentoPlayer : MonoBehaviour
{
    public Rigidbody2D rb;

    public float velocidadeMovimento = 5f;


    private float movimentoHorizontal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(movimentoHorizontal * velocidadeMovimento, rb.linearVelocityY);
    }

    public void Mover(InputAction.CallbackContext contexto)
    {
        movimentoHorizontal = contexto.ReadValue<Vector2>().x;
    }
}
