using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpritesheetAnimator))]
public class AnimateGirlSpritesheet2 : MonoBehaviour
{
    SpritesheetAnimator animator;

    void Start()
    {
        animator = GetComponent<SpritesheetAnimator>();
    }

    public float speed = 0.5f;
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            animator.Play(Anims.Run);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.Play(Anims.Roll);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            animator.Play(Anims.Run);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.Play(Anims.Run);

        }
        else if (Input.GetKey(KeyCode.Z))
        {
            animator.Play(Anims.Top);

        }
        else if (Input.GetKey(KeyCode.E))
        {
            animator.Play(Anims.Jump);
        }
        else
        {
            animator.Play(Anims.Iddle);
        }

    }
}
