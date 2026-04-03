
public class WordDictionary {
        class Node
    {
        public Dictionary<char, Node> Childs = new Dictionary<char, Node>();
        public bool IsWord = false;
    }
    private Node root;
    public WordDictionary()
    {
        root = new Node();
    }

    public void AddWord(string word) {
        var crnt = root;
        foreach (var x in word)
        {
            if (!crnt.Childs.ContainsKey(x))
                crnt.Childs.Add(x, new Node());
            crnt = crnt.Childs[x];
        }
        crnt.IsWord = true;
    }
    
    public bool Search(string word) {
      return  fn(root, word, -1);
    }

    private bool fn(Node root, string word, int v)
    {
        /*
        increase index
            if(root has this child)
            goto this child 
            if (. )
            try all keys 
            if(v==word.Legth-1&&root.IsWord)
            return true
        */
        v++;
        if (v == word.Length && root.IsWord)
            return true;


        if (v >= word.Length)
            return false;
        if (root.Childs.ContainsKey(word[v]))
          return fn(root.Childs[word[v]], word, v);
            
        else if (word[v] == '.')
            foreach (var x in root.Childs.Keys)
            {
                if (fn(root.Childs[x], word, v))
                    return true;
            }
            return false;
    }
}
