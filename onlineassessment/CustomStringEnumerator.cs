using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

//I will work on this
namespace CustomStringEnumerator.Tests
{
    // Do not change the name of this class
    public class CustomStringEnumerator : IEnumerable<string>
    {
        IEnumerable<string> _collection;
        EnumeratorConfig _config;
        /// <summary> Constructor </summary>
        /// <exception cref="System.ArgumentNullException">If a collection is null</exception>
        /// <exception cref="System.ArgumentNullException">If an config is null</exception>
        public CustomStringEnumerator(IEnumerable<string> collection, EnumeratorConfig config)
        {
            if (collection == null || config == null)
                throw new System.ArgumentNullException();
            _collection = collection;
            _config = new EnumeratorConfig {
                MaxLength = config.MaxLength,
                MinLength = config.MinLength,
                StartWithCapitalLetter = config.StartWithCapitalLetter,
                StartWithDigit = config.StartWithDigit };
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach(string str in _collection)
            {
                if (isValid(str))
                    yield return str;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public bool isValid(string str)
        {
            if(String.IsNullOrEmpty(str))
            {
                if ((_config.MinLength == -1||_config.MinLength==0)&&!_config.StartWithCapitalLetter&&!_config.StartWithDigit) return true;
                else return false;
            }
            if ((_config.MinLength!=-1&&str.Length < _config.MinLength) ||(_config.MaxLength!=-1&& str.Length > _config.MaxLength))
                return false;
            if (_config.StartWithCapitalLetter && (str[0] < 'A' || str[0] > 'Z'))
                return false;
            if (_config.StartWithDigit && (str[0] < '0' || str[0] > '9'))
                return false;
            return true;
        }
    }
    /*
// A sample showing how CustomStringEnumerator & EnumeratorConfig will be used
var collection = new string[] { ... };
var config = new EnumeratorConfig
{
    MinLength = 3,
    MaxLength = 10,
    StartWithCapitalLetter = true
};

// The custom enumerator will return strings that are longer or equal to 3 charaters
// and shorter or equal 10 characters and start with a capital letter.
var enumerator = new CustomStringEnumerator(collection, config);
foreach (var s in enumerator)
{
    Console.WriteLine(s);
}
*/

    
}