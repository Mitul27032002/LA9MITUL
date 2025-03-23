using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    // This function is called when the player collides with the object
    private void OnCollisionEnter(Collision collision) //class the described collisions
    {
        // Check if the object that collided with this object has the "Elf" tag
        if (collision.gameObject.CompareTag("Elf"))
        {
            // Make this object disappear by disabling its MeshRenderer and Collider components
            SceneManager.LoadScene("Night");
        }
    }
}
