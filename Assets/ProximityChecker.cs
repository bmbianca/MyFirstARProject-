using UnityEngine;

public class ProximityChecker : MonoBehaviour
{
    public Transform character1;
    public Transform character2;
    public Animator anim1;
    public Animator anim2;

    void Update()
    {
        // Calculate the distance between the two characters in 3D space
        float distance = Vector3.Distance(character1.position, character2.position);

        if (distance < 0.25f)
        {
            anim1.SetBool("isClose", true);
            anim2.SetBool("isClose", true);
        }
        else
        {
            anim1.SetBool("isClose", false);
            anim2.SetBool("isClose", false);
        }
    }
}