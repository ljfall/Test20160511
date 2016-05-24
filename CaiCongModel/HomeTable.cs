using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiCongModel
{
    public class HomeTable
    {
        private int _id;
        private string _thiskey;
        private string _thisvalue;
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// key
        /// </summary>
        public string ThisKey
        {
            set { _thiskey = value; }
            get { return _thiskey; }
        }
        /// <summary>
        /// key对应的value
        /// </summary>
        public string ThisValue
        {
            set { _thisvalue = value; }
            get { return _thisvalue; }
        }
    }
}
