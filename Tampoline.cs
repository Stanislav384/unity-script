using UnityEngine;

public class Tampoline : MonoBehaviour
{
    public float jumping = 10f;
    public float defaultjump = 2f;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = jumping;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = defaultjump;
    }
}
