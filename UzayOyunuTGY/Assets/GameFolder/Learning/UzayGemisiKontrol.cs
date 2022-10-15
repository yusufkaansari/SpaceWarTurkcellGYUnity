﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UzayOyunuTGY.Learning
{
    public class UzayGemisiKontrol : MonoBehaviour
    {

        const float hareketGucu = 10;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Vector3 position = transform.position;

            float yatayInput = Input.GetAxis("Horizontal");
            float dikeyInput = Input.GetAxis("Vertical");

            if (yatayInput != 0)
            {
                position.x += yatayInput * hareketGucu * Time.deltaTime;
            }

            if (dikeyInput != 0)
            {
                position.y += dikeyInput * hareketGucu * Time.deltaTime;
            }

            transform.position = position;
        }
    }
}
