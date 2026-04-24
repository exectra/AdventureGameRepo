using System;
using UnityEngine;

namespace Gamekit3D.GameCommands
{
    public class SimpleTranslator : SimpleTransformer
    {
        public new Rigidbody rigidbody;
        public Vector3 start = -Vector3.forward;
        public Vector3 end = Vector3.forward;

        public AK.Wwise.Event Play_DoorOpen;
        public AK.Wwise.Event Play_MovingPlatform_Up;
        public AK.Wwise.Event Play_MovingPlatform_Down;

        float previousPosition = 0f;

        bool hasPlayedOpenSound = false;
        bool isMovingUp = false;
        bool isMovingDown = false;

        float upDelay = 1f;
        float upDelayTimer = 0f;
        bool pendingUpSound = false;

        float movementThreshold = 0.001f;

        public override void PerformTransform(float position)
        {
            // Detect movement direction with threshold
            if (position > previousPosition + movementThreshold)
            {
                if (!isMovingUp)
                {
                    // Start delayed up sound
                    pendingUpSound = true;
                    upDelayTimer = upDelay;

                    isMovingUp = true;
                    isMovingDown = false;
                }
            }
            else if (position < previousPosition - movementThreshold)
            {
                if (!isMovingDown)
                {
                    // Cancel delayed up sound if switching direction
                    pendingUpSound = false;

                    PlayMovingPlatformDown();

                    isMovingDown = true;
                    isMovingUp = false;
                }
            }

            // Handle delayed up sound timer
            if (pendingUpSound)
            {
                upDelayTimer -= UnityEngine.Time.deltaTime;

                if (upDelayTimer <= 0f)
                {
                    PlayMovingPlatformUp();
                    pendingUpSound = false;
                }
            }

            // Play door open once when movement starts
            if (!hasPlayedOpenSound && position > 0f)
            {
                PlayDoorOpen();
                hasPlayedOpenSound = true;
            }

            previousPosition = position;

            var curvePosition = accelCurve.Evaluate(position);
            var pos = transform.TransformPoint(Vector3.Lerp(start, end, curvePosition));
            Vector3 deltaPosition = pos - rigidbody.position;

            if (Application.isEditor && !Application.isPlaying)
                rigidbody.transform.position = pos;

            rigidbody.MovePosition(pos);

            if (m_Platform != null)
                m_Platform.MoveCharacterController(deltaPosition);
        }
        public void PlayDoorOpen()
        {
            Play_DoorOpen.Post(gameObject);
        }
        public void PlayMovingPlatformUp()
        {
            Play_MovingPlatform_Up.Post(gameObject);
        }
        public void PlayMovingPlatformDown()
        {
            Play_MovingPlatform_Down.Post(gameObject);
        }
    }
}
