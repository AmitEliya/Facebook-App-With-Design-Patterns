using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Factory
{
    public interface IFacebookFeature
    {
        void Execute(params object[] parameters);
    }
}
