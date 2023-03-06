using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Framework.Data
{
    public interface IDataFilter
    {
        IDisposable Enable<TFilter>() where TFilter : class;

        IDisposable Disable<TFilter>() where TFilter : class;

        bool IsEnabled<TFilter>() where TFilter : class;
    }
}
