using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFade : MonoBehaviour
{
    public float fadeTime = 1f;

    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
        StartCoroutine(FadeAndDelete());
    }

    private IEnumerator FadeAndDelete()
    {
        float elapsedTime = 0f;
        Color startingColor = image.color;

        while (elapsedTime < fadeTime)
        {
            elapsedTime += Time.deltaTime;

            float alpha = Mathf.Lerp(startingColor.a, 0f, elapsedTime / fadeTime);
            Color newColor = new Color(startingColor.r, startingColor.g, startingColor.b, alpha);
            image.color = newColor;

            yield return null;
        }

        image.color = new Color(startingColor.r, startingColor.g, startingColor.b, 0f);
        
        // Delay for a short time to ensure the image is completely transparent
        yield return new WaitForSeconds(0.2f);
        
        Destroy(gameObject);
    }
}
