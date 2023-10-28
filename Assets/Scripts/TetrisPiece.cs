using UnityEngine;

public class TetrisPiece : MonoBehaviour
{
    private bool isFrozen = false;

    private void Update()
    {
        if (!isFrozen)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 50);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!isFrozen)
        {//|| collision.gameObject.CompareTag("Piece")
                if (collision.gameObject.CompareTag("Base") )
            {
                isFrozen = true;
                // Outras ações, como verificar linhas completas
            }
        }
    }
}
