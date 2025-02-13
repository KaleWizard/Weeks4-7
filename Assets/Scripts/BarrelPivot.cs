using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BarrelPivot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public ValueModifier BulletSpeed;
    public ValueModifier Gravity;
    public TMP_Dropdown BulletAppearanceDropdown;
    public AudioSource audio;
    public AudioClip gunshot;

    void Update()
    {
        PointAtMouse();

        if (Input.GetMouseButtonDown(0))
        {
            SpawnBullet();
        }
    }

    void PointAtMouse()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = transform.position.z;
        transform.right = mousePos - transform.position;
    }

    void SpawnBullet()
    {
        if (bulletPrefab != null)
        {
            // Spawn bullet at correct position
            Vector3 spawnPosition = transform.position + transform.right;
            GameObject newBullet = Instantiate(bulletPrefab, spawnPosition, Quaternion.identity);

            // Give bullet correct sprite
            int dropdownValue = BulletAppearanceDropdown.value;
            Sprite dropdownSprite = BulletAppearanceDropdown.options.ToArray()[dropdownValue].image;
            newBullet.GetComponent<SpriteRenderer>().sprite = dropdownSprite;

            // Give bullet correct rotation, velocity, and gravity
            BulletMovement bulletScript = newBullet.GetComponent<BulletMovement>();
            newBullet.transform.right = transform.right;
            bulletScript.SetVelocity(transform.right, BulletSpeed.value);
            bulletScript.gravity = Gravity;

            // Play gunshot sound and despawn bullet in 5 seconds
            audio.PlayOneShot(gunshot);
            Destroy(newBullet, 5);
        }
    }
}
