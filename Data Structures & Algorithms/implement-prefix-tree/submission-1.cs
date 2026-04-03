

public class Node {
    public bool IsLeaf = false;
    public Node[] Childs = new Node[26]; 
  }

public class PrefixTree {
    
    private Node root;
    public PrefixTree() {
        this.root = new Node();
    }

    public void Insert(string word)
    {
        var crnt = root;
        foreach (var x in word)
        {
            if (crnt.Childs[x - 'a'] is null)
                crnt.Childs[x - 'a'] = new Node();
                crnt = crnt.Childs[x - 'a'];
        }
        
        crnt.IsLeaf = true;
        
    }

    public bool Search(string word)
    {
        var crnt = root;
        foreach (var x in word)
        {
            if (crnt.Childs[x - 'a'] is null)
            {
                return false;
            }
                crnt = crnt.Childs[x - 'a'];
        }
        return crnt.IsLeaf;
    }

    public bool StartsWith(string prefix)
    {
        var crnt = root;
        foreach (var x in prefix)
        {
            if (crnt.Childs[x - 'a'] is null)
            {
                return false;
            }
                crnt = crnt.Childs[x - 'a'];
        }
        return true;
    }
}