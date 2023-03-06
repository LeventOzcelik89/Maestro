using Maestro.Application.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Application.Repository.Extension
{
    public class AbpUnitOfWorkOptions : IAbpUnitOfWorkOptions
    {
        /// <summary>
        /// Default: false.
        /// </summary>
        public bool IsTransactional { get; set; }

        public IsolationLevel? IsolationLevel { get; set; }

        /// <summary>
        /// Milliseconds
        /// </summary>
        public int? Timeout { get; set; }

        public AbpUnitOfWorkOptions()
        {

        }

        public AbpUnitOfWorkOptions(bool isTransactional = false, IsolationLevel? isolationLevel = null, int? timeout = null)
        {
            IsTransactional = isTransactional;
            IsolationLevel = isolationLevel;
            Timeout = timeout;
        }

        public AbpUnitOfWorkOptions Clone()
        {
            return new AbpUnitOfWorkOptions
            {
                IsTransactional = IsTransactional,
                IsolationLevel = IsolationLevel,
                Timeout = Timeout
            };
        }
    }
}
