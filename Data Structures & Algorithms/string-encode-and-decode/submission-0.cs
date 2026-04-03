public class Solution {
  public string Encode(IList<string> strs) {
      StringBuilder sb=new StringBuilder();

      foreach(var x in strs)
      {
        sb.Append(encode(x));
        sb.Append('\0');
      }  
      
        return sb.ToString();
    }
    static string encode (string s )
    {
      var res=s.ToCharArray().Select(x=>(char)(x^s.Length));
      return String.Concat(res);
    }
    public List<string> Decode(string s) {
      List<string>res=new List<string>();
      var resar=s.Split('\0').SkipLast(1);
      foreach(var x in resar)
      {
        res.Add(encode(x));
      }
      
      return res;
   }
  }
