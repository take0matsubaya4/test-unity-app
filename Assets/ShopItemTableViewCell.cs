using UnityEngine;
using UnityEngine.UI;

// リスト項目のデータクラスを定義
public class ShopItemData
{
	public string iconName;		// アイコン名
	public string name;			// アイテム名
	public int price;			// 価格
	public string description;	// 説明
}

// TableViewCell<T>クラスを継承する
public class ShopItemTableViewCell : TableViewCell<ShopItemData>
{
	[SerializeField] private Image iconImage;	// アイコンを表示するイメージ
	[SerializeField] private Text nameLabel;	// アイテム名を表示するテキスト
	[SerializeField] private Text priceLabel;	// 価格を表示するテキスト

	// セルの内容を更新するメソッドのオーバーライド
	public override void UpdateContent(ShopItemData itemData)
	{
		nameLabel.text = itemData.name;
		priceLabel.text = itemData.price.ToString();

#region アイコンのスプライトを変更するコードの追加
		// スプライトシート名とスプライト名を指定してアイコンのスプライトを変更する
		iconImage.sprite = 
			SpriteSheetManager.GetSpriteByName("IconAtlas", itemData.iconName);
#endregion
	}
}
