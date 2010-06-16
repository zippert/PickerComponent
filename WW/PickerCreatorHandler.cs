using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace WW
{
    class PickerCreatorHandler
    {
        public Hashtable data;

        public PickerCreatorHandler()
        {
            data = new Hashtable();
        }

        public void Add(String key, String value)
        {
            data.Add(key, value);
        }

        public void Remove(String key)
        {
            data.Remove(key);
        }

        public void Clear()
        {
            data.Clear();
        }

        public String GetValue(String key)
        {
            return (String)data[key];
        }

        public String[] Get(String charset)
        {
            if (charset.Equals(""))
            {
                return GetAllKeys();
            }

            List<String> list = new List<String>();
            
            foreach(String s in data.Keys){
                if (s.Contains(charset))
                {
                    list.Add(s);
                }
            }
            return list.ToArray();
        }


        public String[] GetAllKeys()
        {
            String[] list = new String[data.Keys.Count];
            data.Keys.CopyTo(list, 0);
            return list;
        }

        public Boolean contains(String key)
        {
            return data.ContainsKey(key);
        }



    }
}
