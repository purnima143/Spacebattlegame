using UnityEngine;

public class MoveLeft : MonoBehaviour
{   private enemy enemy;
    public float Speed = 1;
    private void Awake() {
        enemy=GetComponent<enemy>();
    }
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * Speed,Space.World);
        if (transform.position.x < -15)
        {
            transform.position += new Vector3(30, 0, 0);
            showRandomSprite();
            enemy?.Respawn();
        }
    }
    private void showRandomSprite()
    {
        int index = UnityEngine.Random.Range(0, 3);
        int childCount = transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            child.gameObject.SetActive(index == i);
        }
    }
    private void OnEnable()
    {
        showRandomSprite();
    }
}
