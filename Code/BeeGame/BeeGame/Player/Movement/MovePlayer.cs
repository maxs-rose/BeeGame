﻿using System.Collections;
using System.Collections.Generic;
using BeeGame.Core;
using UnityEngine;

namespace BeeGame.Player.Movement
{
    [RequireComponent(typeof(CharacterController))]
    public class MovePlayer : MonoBehaviour
    {
        public CharacterController myConroller;
        public float speed;
        
        void Update()
        {
            Move();
        }

        void Move()
        {
            if(THInput.GetButton("Forward"))
            {
                myConroller.SimpleMove(transform.forward * speed * Time.deltaTime * Time.timeScale);
            }

            if(THInput.GetButton("Backward"))
            {
                myConroller.SimpleMove(transform.forward * -speed * Time.deltaTime * Time.timeScale);
            }

            if(THInput.GetButton("Right"))
            {
                myConroller.SimpleMove(transform.right * speed * Time.deltaTime * Time.timeScale);
            }

            if (THInput.GetButton("Left"))
            {
                myConroller.SimpleMove(transform.right * -speed * Time.deltaTime * Time.timeScale);
            }
        }
    }
}
