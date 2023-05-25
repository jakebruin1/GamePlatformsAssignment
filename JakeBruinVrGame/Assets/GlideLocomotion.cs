using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlideLocomotion : MonoBehaviour
{
    public Transform trackedTransform;
    public float rotationSpeed = 100f;
    public Transform rigRoot;
    public float velocity = 2f;

    // Start is called before the first frame update
    private void Start()
    {
        if (rigRoot == null) rigRoot =
                  transform;
    }

    // Update is called once per frame
    private void Update()
    {

        float forward = Input.GetAxis("XRI_Right_Primary2DAxis_Vertical");
        if (forward != 0f)
        {
            Vector3 moveDirection = Vector3.forward;
            if (trackedTransform != null)
            {
                moveDirection = trackedTransform.forward;
                moveDirection.y = 0f;
            }
            moveDirection *= -forward * velocity
                * Time.deltaTime;
            rigRoot.Translate(moveDirection);
        }

        if (trackedTransform == null)
        {
            float sideways = Input.GetAxis("XRI_Right_Primary2DAxis_Horizontal");

            if (sideways != 0f)
            {
                float rotation = sideways * rotationSpeed
                    * Time.deltaTime;
                rigRoot.Rotate(0, rotation, 0);
            }
        }
    }
}
