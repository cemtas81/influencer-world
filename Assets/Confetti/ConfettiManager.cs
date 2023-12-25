
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


    public class ConfettiManager: MonoBehaviour
    {
        public void Explode()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                ParticleSystem particleSystem = transform.GetChild(i).GetComponent<ParticleSystem>();

                if (particleSystem != null)
                {
                    particleSystem.Play();
                }
            }
        }
    }

