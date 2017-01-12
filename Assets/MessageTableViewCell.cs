using UnityEngine;
using UnityEngine.UI;

// リスト項目のデータクラスを定義
public class MessageData
{
	public string iconName;		// アイコン名
	//public float height;		// 送信者名
	public string name;			// 送信者名
	public string message;		// メッセージ
	public string date;			// 送信日時
}

// TableViewCell<T>クラスを継承する
public class MessageTableViewCell : TableViewCell<MessageData>
{
	[SerializeField] private Image iconImage;	// アイコンを表示するイメージ
	//[SerializeField] private GameObject cellContent;	// セルの内容
	[SerializeField] private Text nameLabel;	// 送信者名を表示するテキスト
	[SerializeField] private Text messageText;	// メッセージを表示するテキスト
	[SerializeField] private Text dateLabel;	// 送信日時を表示するテキスト

	// セルの内容を更新するメソッドのオーバーライド
	public override void UpdateContent(MessageData MessageData)
	{
		nameLabel.text = MessageData.name;
		messageText.text = MessageData.message;
		dateLabel.text = MessageData.date;
		//MessageData.height = cellContent.GetComponent<RectTransform>().sizeDelta.y;

		#region アイコンのスプライトを変更するコードの追加
		// スプライトシート名とスプライト名を指定してアイコンのスプライトを変更する
		iconImage.sprite = 
			SpriteSheetManager.GetSpriteByName("IconAtlas", MessageData.iconName);
		#endregion
	}
}
