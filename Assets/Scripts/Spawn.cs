using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject cube;
    private float cooldown;
    private float force = 8.0f;
    
    void Update()
    {
        cooldown += Time.deltaTime;

        if (cooldown >= 0.2f) {
            GameObject gb = Instantiate(cube, Vector3.up, Quaternion.identity);
            Rigidbody rb = gb.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * force, ForceMode.Force);
            cooldown = 0;
        }
    }
}
