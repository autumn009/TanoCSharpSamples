using System;

class Node
{
    public readonly int Number;
    public Node[] Children;
    public Node(int n)
    {
        Number = n;
    }
}

class Program
{
    // 全てのノードを巡回するメソッド
    private static void nodeWalker(Node root, Action<Node> action)
    {
        // 子ノードを持っているか?
        if (root.Children != null)
        {
            // 子ノードを列挙して自分自身を呼び出す
            foreach (var item in root.Children) nodeWalker(item, action);
        }
        // ラムダ式で指定されたアクションを実行
        action(root);
    }

    static void Main(string[] args)
    {
        var root = new Node(1)
        {
            Children = new Node[]{
                new Node(2){
                    Children=new Node[]{
                        new Node(3),
                        new Node(4)
                    }
                },
                new Node(5)
            }
        };
        // キャプチャされる変数countを宣言
        int count = 0;
        nodeWalker(root, (node) =>
        {
            // ラムダ式内だが、countを利用できる
            count += node.Number;
        });
        // 累積した値を出力する
        Console.WriteLine(count);
    }
}
