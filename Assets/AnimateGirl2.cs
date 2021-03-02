using UnityEngine;

[RequireComponent(typeof(SpriteRenderer), typeof(Animator), typeof(Rigidbody2D))]
public class AnimateGirl2 : MonoBehaviour
{
    [Tooltip("Vitesse max en unités par secondes")]
    public int MaxSpeed = 2;

    // Autres scripts
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private Rigidbody2D rigidbody2D;

    // variables de mon instance
    private Vector3 speed;

    // statics
    private static readonly int Speed = Animator.StringToHash("Speed");
    private static readonly int Roll = Animator.StringToHash("Roll");
    private static readonly int GoingUp = Animator.StringToHash("GoingUp");

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        var maxDistancePerFrame = MaxSpeed;
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.D))
        {
            move += Vector3.right * maxDistancePerFrame;
        }
        else if (Input.GetKey(KeyCode.Q))
        {   
            move += Vector3.left * maxDistancePerFrame;
        }

        if (Input.GetKey(KeyCode.Z))
        {
            move += Vector3.up * maxDistancePerFrame;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            move += Vector3.down * maxDistancePerFrame;
        }

        if (animator.GetBool(Roll)) animator.ResetTrigger(Roll);
        // Ici on utilise GetKeyDown, qui ne retourne true que la première frame où la touche est appuyée
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger(Roll);
        }

        animator.SetBool(GoingUp, Input.GetKey(KeyCode.Z));

        animator.SetFloat(Speed, move.magnitude * 10f);
        rigidbody2D.velocity = move;
    }
}