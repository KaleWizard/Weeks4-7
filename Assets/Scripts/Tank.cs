using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tank : MonoBehaviour
{
    public ValueModifier TankSpeed;
    public TMP_Dropdown TankAppearanceDropdown;
    public SpriteRenderer bodySpriteRenderer;

    void Update()
    {
        Vector3 movementVector = Vector3.zero;
        movementVector.x = Input.GetAxisRaw("Horizontal");
        transform.position += movementVector * Time.deltaTime * TankSpeed.value;

        int dropdownValue = TankAppearanceDropdown.value;
        Sprite dropdownSprite = TankAppearanceDropdown.options.ToArray()[dropdownValue].image;
        if (dropdownSprite != bodySpriteRenderer.sprite)
        {
            bodySpriteRenderer.sprite = dropdownSprite;
        }
    }
}
