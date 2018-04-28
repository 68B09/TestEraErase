# TestEraErase
テスト元号設定削除ツール
======================
Windows10 2018 Spring Release で入れられる(と思われる)新元号テスト用設定を削除するプログラムです。

言語・開発環境
------
C#/.NET Framework 4.0/VisualStudio2017

使い方
------
TestEraErase.zipを解凍して中に入っているTestEraErase.exeを実行する。  
TestEraErase.zip  
MD5:21a7fa2bc1622889b7ba74415f6f439c  
SHA256:e0e3a2bb9bcec6383732c3e4b59b7be5ca193e4bd0f95fb5cf7d3a6167e55df0

関連情報
------
１、管理者権限で起動するようになっています  
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
