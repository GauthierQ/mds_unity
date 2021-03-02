using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpritesheetAnimator))]
public class AnimateGirlSpritesheet : MonoBehaviour
{
    SpritesheetAnimator animator;

    void Start()
    {
        animator = GetComponent<SpritesheetAnimator>();
    }

    public float speed = 0.5f;
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            animator.Play(Anims.Run);

        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.Play(Anims.Roll);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            animator.Play(Anims.Run);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.Play(Anims.Run);

        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.Play(Anims.Top);

        }
        else if (Input.GetKey(KeyCode.Space))
        {
            animator.Play(Anims.Jump);
        }
        else
        {
            animator.Play(Anims.Iddle);
        }

    }
}
