using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class BarrelPivot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public ValueModifier BulletSpeed;
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
            Vector3 spawnPosition = transform.position + transform.right;
            GameObject newBullet = Instantiate(bulletPrefab, spawnPosition, Quaternion.identity);
            newBullet.transform.right = transform.right;
            int dropdownValue = BulletAppearanceDropdown.value;
            Sprite dropdownSprite = BulletAppearanceDropdown.options.ToArray()[dropdownValue].image;
            newBullet.GetComponent<SpriteRenderer>().sprite = dropdownSprite;
            //newBullet.GetComponent<BulletMovement>().speed = BulletSpeed.value;
            audio.PlayOneShot(gunshot);
            Destroy(newBullet, 5);
        }
    }
}
