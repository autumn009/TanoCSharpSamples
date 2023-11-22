#pragma warning disable MyID0001 // 種類は、評価の目的でのみ提供されています。将来の更新で変更または削除されることがあります。続行するには、この診断を非表示にします。
sub();
#pragma warning restore MyID0001 // 種類は、評価の目的でのみ提供されています。将来の更新で変更または削除されることがあります。続行するには、この診断を非表示にします。

[System.Diagnostics.CodeAnalysis.ExperimentalAttribute("MyID0001")]
void sub()
{
    Console.WriteLine("The Philadelphia Experiment");
}
