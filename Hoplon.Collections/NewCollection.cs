using System.Collections.Generic;
using System.Linq;

namespace Hoplon.Collections
{
    public class NewCollection : IHoplonCollection
    {
        Dictionary<string, SortedSet<string>> dict = new Dictionary<string, SortedSet<string>>();

        public bool Add(string key, string value)
        {
            SortedSet<string> setVal = new SortedSet<string>();
            bool remove = false;
            if(dict.ContainsKey(key)) {
                remove = true;
                dict.TryGetValue(key, out setVal);
            }
            
            bool retorno = setVal.Add(value);
            if(remove) {
                dict.Remove(key);
            }
            dict.Add(key, setVal);
            return retorno;
        }

        public IList<string> Get(string key, int start, int end)
        {
            SortedSet<string> set = new SortedSet<string>();
            IList<string> result = new List<string>();
            if(dict.ContainsKey(key)) {
                dict.TryGetValue(key, out set);
            } else {
                return result;
            }

            var ini = 0;
            var fim = end;
            if(start > 0 ) {
                ini = start;
            }
            if(end >= set.Count ) {
                fim = set.Count-1;
            }
            if(end < 0 ) {
                fim -= end;
            }

            for (int i = ini; i <= fim; i++) {
                result.Add(set.ElementAt(i));
            }

            return result;
        }

        public bool Remove(string key)
        {
            if(!dict.ContainsKey(key)) {
                return false;
            }
            dict.Remove(key);
            return true;
        }

        public long IndexOf(string key, string value)
        {
            SortedSet<string> valores = new SortedSet<string>();
            if(!dict.ContainsKey(key)) {
                return -1;
            }
            dict.TryGetValue(key, out valores);

            for (int i = 0; i < valores.Count; i++) {
                if(value.Equals(valores.ElementAt(i))) {
                    return i;
                }
            }
            return -1;
        }
        
    }
}