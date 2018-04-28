# TestEraErase
テスト元号設定削除ツール
======================
Windows10 2018 Spring Release で入れられる(と思われる)新元号テスト用設定を削除するプログラムです。

言語・開発環境
------
C#/.NET Framework 4.0/VisualStudio2017

使い方
------
bin/x86/Release/TestEraErase.exe* をローカルドライブ上に置いてから実行する。

関連情報
------
１、レジストリを弄るので管理者権限で起動します  
２、レジストリを弄るので要注意  
　　実行結果は自己責任で。
　　万が一の為にシステム全体をバックアップしておいてください。  
　　不安な場合は使用しないでください。  
３、いじくるレジストリは HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Nls\Calendars\Japanese\Eras です  
　　この中から"？？_？_??????_?"を持つ値を削除します。  
　　削除前には確認ダイアログが表示されるので起動後にいきなりレジストリがいじられることはありません。  
　　
ライセンス
------
ライセンスを適用するファイルにはライセンスについての記述があります。  
The MIT License (MIT)  
Copyright (c) 2018 ZZO  
see also 'LICENSE' file

履歴
-----
2018/4/28 ZZO(68B09)  
First release.
