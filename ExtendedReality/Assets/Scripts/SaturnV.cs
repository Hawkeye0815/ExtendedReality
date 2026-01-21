using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SaturnV : MonoBehaviour
{
    public ParticleSystem flames;
    public ParticleSystem smoke;
    public ParticleSystem ember1;
    public ParticleSystem ember2;

    public Transform target;
    public Transform origin;
    public GameObject prefab;
    public float speed;
    public float newSpeed;

    public bool clicked = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        clicked = false;
        newSpeed = speed;
    }
    public void Launch()
    {
        flames.Play();
        smoke.Play();
        ember1.Play();
        ember2.Play();      
        
        clicked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(clicked)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, newSpeed * Time.deltaTime);
            newSpeed = newSpeed + 0.01f;
            if (Vector3.Distance(transform.position, target.position) < 0.001f)
            {
                Instantiate(prefab, origin.position, origin.rotation);
                Destroy(gameObject);
            }
        }    
    }
}
