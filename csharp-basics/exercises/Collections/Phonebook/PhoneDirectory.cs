using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _data;
        private int _dataCount;

        public PhoneDirectory() {
            _data = new SortedDictionary<string, string>();
            _dataCount = 0;
        }

        private bool Find(string name) {
            for (var i = 0; i < _dataCount; i++) 
            {
                if (_data.ContainsKey(name)) 
                {
                    return true;
                }
            }
            return false;
        }

        public string GetNumber(string name) 
        {
            var position = Find(name);
            if (position == false) 
            {
                return null;
            } 
            else 
            {
                return _data[name];
            }
        }

        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
            }

            var i = Find(name);
            if (i == true) 
            {
                _data[name] = number;
            }
            else 
            {
                _data.Add(name, number);
                _dataCount++;
            }
        }
    }
}