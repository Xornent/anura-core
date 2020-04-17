﻿using Anura.JavaScript.Native;
using Anura.JavaScript.Native.Argument;
using Anura.JavaScript.Native.Function;
using Anura.JavaScript.Runtime.Environments;
using Anura.JavaScript.Runtime.References;

namespace Anura.JavaScript.Pooling
{
    /// <summary>
    /// Cache reusable <see cref="Reference" /> instances as we allocate them a lot.
    /// </summary>
    internal sealed class ArgumentsInstancePool
    {
        private const int PoolSize = 10;
        private readonly Engine _engine;
        private readonly ObjectPool<ArgumentsInstance> _pool;

        public ArgumentsInstancePool(Engine engine)
        {
            _engine = engine;
            _pool = new ObjectPool<ArgumentsInstance>(Factory, PoolSize);
        }

        private ArgumentsInstance Factory()
        {
            return new ArgumentsInstance(_engine)
            {
                _prototype = _engine.Object.PrototypeObject
            };
        }

        public ArgumentsInstance Rent(
            FunctionInstance func, 
            string[] names, 
            JsValue[] args, 
            EnvironmentRecord env, 
            bool strict)
        {
            var obj = _pool.Allocate();
            obj.Prepare(func, names, args, env, strict);
            return obj;
        }

        public void Return(ArgumentsInstance instance)
        {
            if (ReferenceEquals(instance, null))
            {
                return;
            }
            _pool.Free(instance);;
        }
    }
}