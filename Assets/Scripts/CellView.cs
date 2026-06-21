using UnityEngine;

public class CellView : MonoBehaviour
{
    public int X;
    public int Y;

    [SerializeField] private GameObject[] prefabs;

    private GameObject _skin;

    public void Awake()
    {
        int index = Random.Range(0, prefabs.Length);
        _skin = Instantiate(prefabs[index]);
        _skin.transform.parent = transform;
        _skin.transform.localPosition = Vector3.zero;
        _skin.transform.localScale = new Vector3 (10, 10, 10);
    }

    public void Miss()
    {
        Destroy(_skin);
    }

    public void Got(GameObject skin)
    {
        Destroy(_skin);

        GameObject ship = Instantiate(skin);
        ship.transform.parent = transform;
        ship.transform.localPosition = Vector3.zero;    
    }
}
