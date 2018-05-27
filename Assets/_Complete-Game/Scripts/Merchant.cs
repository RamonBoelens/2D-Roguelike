using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Completed
{
    public class Merchant : MonoBehaviour
    {

        private Animator animator;                  //Used to store a reference to the Player's animator component.

        // Use this for initialization
        void Start()
        {
            //Get a component reference to the Player's animator component
            animator = GetComponent<Animator>();

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
