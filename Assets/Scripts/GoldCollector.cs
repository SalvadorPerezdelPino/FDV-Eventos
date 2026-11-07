using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GoldCollector : MonoBehaviour
{
    public Tilemap goldTilemap;
    public TMP_Text goldText;
    private int gold = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateGoldText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Gold")
        {
            Vector2 hit = other.ClosestPoint(transform.position);
            goldTilemap.SetTile(goldTilemap.WorldToCell(hit), null);
            gold += 1;
            UpdateGoldText();
        }
    }

    private void UpdateGoldText()
    {
        goldText.text = gold.ToString();
    }
}
