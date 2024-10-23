using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace platprac
{
    public class PlayerController : MonoBehaviour
    {
        #region Variables
        Rigidbody2D rb2D;
        Animator animator;

        [SerializeField] private float moveSpeed;

        [SerializeField] private bool isMove = false;
        public bool IsMove
        {
            get { return isMove; }
            set
            {
                isMove = value;
                animator.SetBool(AnimationString.IsMove, true);
            }
        }
        #endregion

        private void Awake()
        {
            // ÂüÁ¶
            rb2D = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
        }
    }
}



