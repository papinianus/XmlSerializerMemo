# XMLSerializerMemo

## Memo

### Array

- XmlArray の Element Name がないとき Members が付与される
-- XmlArrayItem を XmlArray なしに利用したときも上記が該当する
- XmlArray の子要素の名前は XmlArrayItem の ElementName によって指定可能
-- 上記がない場合、クラス名が利用される。子要素のクラスに XmlRoot 属性があっても利用されない。

## reference

- [Basics of Serialize](http://park1.wakwak.com/~ima/dotnet_cs_xmlserializer0001.html)
- [Serializing Enum](https://hensa40.cutegirl.jp/archives/2523)
- [ArrayItem](https://dobon.net/vb/dotnet/file/xmlserializer2.html)
