using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    [SerializeField]
    private float tumble;
    public float speed;
    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }
    void Update()
    {
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);
    }
}