﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

[RequireComponent(typeof(ScrollRect))]
public class MessageTableViewController : TableViewController<MessageData>
// TableViewController<T>クラスを継承
{
	// リスト項目のデータを読み込むメソッド
	private void LoadData()
	{
		// 通常データはデータソースから取得しますが、ここではハードコードで定義する
		tableData = new List<MessageData>() {
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="Nothing else, just water. Nothing else, just water. Nothing else, just water.", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="Sugar free and low calorie. Sugar free and low calorie. Sugar free and low calorie.", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="How would you like your coffee? How would you like your coffee? How would you like your coffee?", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="It will give you wings. It will give you wings. It will give you wings.s", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="Nothing else, just water. Nothing else, just water. Nothing else, just water.", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="Sugar free and low calorie. Sugar free and low calorie. Sugar free and low calorie.", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="How would you like your coffee? How would you like your coffee? How would you like your coffee?", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="It will give you wings. It will give you wings. It will give you wings.s", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="Nothing else, just water. Nothing else, just water. Nothing else, just water.", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="Sugar free and low calorie. Sugar free and low calorie. Sugar free and low calorie.", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="How would you like your coffee? How would you like your coffee? How would you like your coffee?", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="It will give you wings. It will give you wings. It will give you wings.s", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="Nothing else, just water. Nothing else, just water. Nothing else, just water.", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="Sugar free and low calorie. Sugar free and low calorie. Sugar free and low calorie.", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="How would you like your coffee? How would you like your coffee? How would you like your coffee?", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="It will give you wings. It will give you wings. It will give you wings.s", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="Nothing else, just water. Nothing else, just water. Nothing else, just water.", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="Sugar free and low calorie. Sugar free and low calorie. Sugar free and low calorie.", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="How would you like your coffee? How would you like your coffee? How would you like your coffee?", date="2117/02/28 22:30" }, 
			new MessageData { iconName="GirlFriend", name="HANAKO", 
				message="It will give you wings. It will give you wings. It will give you wings.s", date="2117/02/28 22:30" }, 
	};

		// スクロールさせる内容のサイズを更新する
		UpdateContents();
	}

	// リスト項目に対応するセルの高さを返すメソッド
	protected override float CellHeightAtIndex(int index)
	{
		/*if(index >= 0 && index <= tableData.Count-1)
		{
			if(tableData[index].message >= 1000)
			{
				// 価格が1000以上のアイテムを表示するセルの高さを返す
				return 240.0f;
			}
			if(tableData[index].message >= 500)
			{
				// 価格が500以上のアイテムを表示するセルの高さを返す
				return 160.0f;
			}
		}*/
		return 215.0f;
		//print(tableData[index].height);
		//return tableData[index].height;
	}

	// インスタンスのロード時に呼ばれる
	protected override void Awake()
	{
		// ベースクラスのAwakeメソッドを呼ぶ
		base.Awake();

		// アイコンのスプライトシートに含まれるスプライトをキャッシュしておく
		SpriteSheetManager.Load("IconAtlas");

		// リスト項目のデータを読み込む
		LoadData();
	}
	/*
	// インスタンスのロード時Awakeメソッドの後に呼ばれる
	protected override void Start()
	{
		// ベースクラスのStartメソッドを呼ぶ
		base.Start();

		// リスト項目のデータを読み込む
		LoadData();

		#region アイテム一覧画面をナビゲーションビューに対応させる
		if(navigationView != null)
		{
			// ナビゲーションビューの最初のビューとして設定する
			navigationView.Push(this);
		}
		#endregion
	}

	#region アイテム一覧画面をナビゲーションビューに対応させる
	// ナビゲーションビューを保持
	[SerializeField] private NavigationViewController navigationView;

	// ビューのタイトルを返す
	public override string Title { get { return "SHOP"; } }
	#endregion

	#region アイテム詳細画面に遷移させる処理の実装
	// アイテム詳細画面のビューを保持
	[SerializeField] private ShopDetailViewController detailView;

	// セルが選択されたときに呼ばれるメソッド
	public void OnPressCell(MessageTableViewCell cell)
	{
		if(navigationView != null)
		{
			// 選択されたセルからアイテムのデータを取得して、アイテム詳細画面の内容を更新する
			detailView.UpdateContent(tableData[cell.DataIndex]);
			// アイテム詳細画面に遷移する
			navigationView.Push(detailView);
		}
	}
	#endregion */
}
