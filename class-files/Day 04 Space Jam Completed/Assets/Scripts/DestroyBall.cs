using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    Material material;
    bool isFading = false;
    [SerializeField] float fadeSpeed = 10f;

    void Start()
    {
        // Get the Renderer attached to this game object.
        Renderer renderer = GetComponent<Renderer>();
        // Get the material the renderer is using.
        material = renderer.material;

        // Set the color to something blue and semi-transparent.
        //material.color = new Color(1f, 0f, 1f, 1f);

        // Generate a semi-transparent basketball color.
        //Color newColor = Color.Lerp(material.color, new Color(0f, 0f, 0f, 0f), 0.5f);
        // Apply it to the material.
        //material.color = newColor;

        // Schedule the fade out as soon as the ball is created, so that we don't accumulate
        // a whole bunch on top of the court.
        Invoke("StartFading", 6f);
    }

    void StartFading()
    {
        isFading = true;
    }

    void Update()
    {
        if (transform.position.y < -20)
        {
            StartFading();
        }

        if (isFading)
        {
            // Generate the new, slightly more transparent color and apply it to the ball.
            float fadeAmount = fadeSpeed * Time.deltaTime;
            Color newColor = Color.Lerp(material.color, Color.clear, fadeAmount);
            material.color = newColor;

            // When we've reached the end of the animation (fully transparent), destroy!
            if (material.color == Color.clear)
            {
                Destroy(gameObject);
            }
        }
    }
}
