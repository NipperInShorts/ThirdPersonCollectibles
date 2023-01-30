using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revealer : MonoBehaviour
{
    public Revealer nextReveal;
    public MeshRenderer objectRenderer;
    public Material objectMaterial;

    private Color tempColor;

    // Start is called before the first frame update
    void Start()
    {
        objectRenderer = gameObject.GetComponent<MeshRenderer>();
        objectMaterial = objectRenderer.material;
        tempColor = new Color(objectMaterial.color.r, objectMaterial.color.g, objectMaterial.color.b, objectMaterial.color.a);
        objectMaterial.SetColor("_Color", tempColor);

        if (nextReveal)
        {
            MeshRenderer nextRevealRenderer = nextReveal.GetComponent<MeshRenderer>();
            Material nextRevealMaterial = nextRevealRenderer.material;
            Color nextRevealTempColor = new Color(nextRevealMaterial.color.r, nextRevealMaterial.color.g, nextRevealMaterial.color.b, 0.0f);

            nextRevealMaterial.SetColor("_Color", nextRevealTempColor);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Here");
        if (other.CompareTag("Player") && nextReveal) {
            MeshRenderer nextRevealRenderer = nextReveal.GetComponent<MeshRenderer>();
            Material nextRevealMaterial = nextRevealRenderer.material;
            Color nextRevealTempColor = new Color(nextRevealMaterial.color.r, nextRevealMaterial.color.g, nextRevealMaterial.color.b, 1.0f);

            nextRevealMaterial.SetColor("_Color", nextRevealTempColor);            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision);
    }
}
