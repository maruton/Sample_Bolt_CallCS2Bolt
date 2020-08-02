# Sample_Bolt_CallCS2Bolt
see english to the second half of the page.

## C#からBoltのノードを呼び出すサンプル
Unity 2019.4.3f1 で作成。

## インストール＆セットアップ

1. 空のUnityプロジェクトを作成。  
2. Bolt をインストール＆Setup Wizard。  
3. 'Sample_Bolt_CallCS2Bolt.zip' を以下のリンクからダウンロード。
   https://github.com/maruton/Sample_Bolt_CallCS2Bolt/releases/tag/Rel1.0
4. 展開すると 'Sample_Bolt_CallCS2Bolt.unitypackage' ができるのでUnityにインポート。  
5. シーン /Assets/Scenes/Main をダブルクリックして読み込む。  
6. 実行する。

## 簡易説明
Hierarchy内の Bolt_Object に以下がコンポーネントで付与されています。  
  
  C#スクリプト  
  Flow Graph  
  State Graph  
  
C#スクリプトから、Flow Graph及び、State Graph の Custom Eventを呼び出しています。 
単純に加算値を引数で渡しています。  

Flow Graph、State Graphの各Custom Eventでは引数の加算値を各シーン変数に累積加算して、結果をDebug.Logで表示しています。 
  


## ライセンス
BSDライセンス準拠。ただし著作権・免責の表示は不要。  
※自己責任において自由にご使用下さい。  
  
-------------------------------------------------------------------------------------  
## Sample for Bolt using TextMesh Pro

Unity 2019.4.3f1

## Install & Setup

1. Create new Unity project.  
2. Install Bolt from Asset store, and Setup Wizard.  
3. Download 'Sample_Bolt_CallCS2Bolt.zip' below link.  
   https://github.com/maruton/Sample_Bolt_CallCS2Bolt/releases/tag/Rel1.0  
4. Extract and, Import unity.  
5. Load scene /Assets/Scenes/Main.  
6. Go PLAY.

## What about procedure
Adde all component to 'Bolt_Object' in Hierarchy.
  
  C# script
  Flow Graph  
  State Graph  

Call each Custom Event from C# script that Flow Graph and State Graph.  
Each argment is add value.  
Custom event is add value to each self counter variable. and current value to output Debug.Log.  
  

  
## License
Modified BSD license.  
Modify: Display of copyright and disclaimer is not required.  
  
  
