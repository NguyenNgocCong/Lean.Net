using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Abstract
{
    public abstract class AbstractPost : IPost
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Alias { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Image { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MetaKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MetaDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool HomePlag { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
