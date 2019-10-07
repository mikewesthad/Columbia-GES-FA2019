using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionTracker : MonoBehaviour
{
    [SerializeField] Text damageText;
    [SerializeField] float damagePerCollision = 1f;
    Material carMaterial;
    float carDamagePercent = 0f;

    void Start()
    {
        carMaterial = GetComponent<Renderer>().material;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("collided with: " + collision.gameObject.name);

            carDamagePercent += damagePerCollision;
            carMaterial.color = Color.Lerp(carMaterial.color, Color.red, damagePerCollision / 100f);
            if (carDamagePercent > 100) carDamagePercent = 100;
            damageText.text = "Damage: " + carDamagePercent + "%";
        }
    }
}
