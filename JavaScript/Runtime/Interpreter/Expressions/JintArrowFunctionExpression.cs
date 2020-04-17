using Esprima.Ast;
using Anura.JavaScript.Native.Function;
using Anura.JavaScript.Runtime.Environments;

namespace Anura.JavaScript.Runtime.Interpreter.Expressions
{
    internal sealed class JintArrowFunctionExpression : JintExpression
    {
        private readonly JintFunctionDefinition _function;

        public JintArrowFunctionExpression(Engine engine, IFunction function)
            : base(engine, ArrowParameterPlaceHolder.Empty)
        {

            _function = new JintFunctionDefinition(engine, function);
        }

        protected override object EvaluateInternal()
        {
            var funcEnv = LexicalEnvironment.NewDeclarativeEnvironment(_engine, _engine.ExecutionContext.LexicalEnvironment);

            var closure = new ArrowFunctionInstance(
                _engine,
                _function,
                funcEnv,
                _function._strict);

            return closure;
        }
    }
}