using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.Collections;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
		public AudioClip dragonClip;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }

		void Update() 
		{
			//dragon sequence
			if (m_Car.m_Rigidbody.velocity.magnitude <= 1) {
				AudioSource audio = gameObject.AddComponent<AudioSource>();
				audio.clip = dragonClip;
				audio.Play();
				Wait ();
				if (m_Car.m_Rigidbody.velocity.magnitude <= 1) {
					audio.Play();
				}
			}
		}

		IEnumerator Wait() 
		{
			yield return new WaitForSeconds(5);
		}

        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif

        }
    }
}
