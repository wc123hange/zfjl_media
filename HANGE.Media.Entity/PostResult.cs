using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANGE.Media.Entity
{
 public   class PostResult<T,E> 
    {
        public string code { set; get; }
        public string msg { set; get; }
        public T value { set; get; }

        public List<E> valueList { set; get; }

    }
}
