空のUnityプロジェクトを作成。
Bolt をインストール。
Sample_Bolt_CallCS2Bolt.unitypackage をインポート
Bolt Setup Wizardが自動起動したらインストール時と同じように進める。
/Assets/Scenes/Main をダブルクリックして読み込む。


Hierarchy内の Bolt_Object に以下がコンポーネントで付与されています。

  C#スクリプト
  Flow Graph
  State Graph

C#スクリプトから、Flow Graph及び、State Graph の Custom Eventを呼び出しています。
単純に加算値を引数で渡しています。

Flow Graph、State Graphの各Custom Eventでは引数の加算値を各シーン変数に累積加算して、結果をDebug.Logで表示しています。

