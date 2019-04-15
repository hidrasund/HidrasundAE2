using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
    public RotationAxes Axes = RotationAxes.MouseXAndY;
    public float SensitivityX = 5f;
    public float SensitivityY = 3f;

    public float MinimumX = -360F;
    public float MaximumX = 360F;

    public float MinimumY = -75f;
    public float MaximumY = 75f;

    float RotationY = 0F;

    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked; //Makes the cursor locked to the center of the screen
        

        if (Axes == RotationAxes.MouseXAndY)
        {
            float RotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * SensitivityX;

            RotationY += Input.GetAxis("Mouse Y") * SensitivityY;
            RotationY = Mathf.Clamp(RotationY, MinimumY, MaximumY);

            transform.localEulerAngles = new Vector3(-RotationY, RotationX, 0);
        }
        else if (Axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * SensitivityX, 0);
        }
        else
        {
            RotationY += Input.GetAxis("Mouse Y") * SensitivityY;
            RotationY = Mathf.Clamp(RotationY, MinimumY, MaximumY);

            transform.localEulerAngles = new Vector3(-RotationY, transform.localEulerAngles.y, 0);
        }
    }
}