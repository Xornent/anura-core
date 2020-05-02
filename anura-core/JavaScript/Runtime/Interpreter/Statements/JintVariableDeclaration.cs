using Esprima.Ast;
using Anura.JavaScript.Native;
using Anura.JavaScript.Native.Function;
using Anura.JavaScript.Runtime.Interpreter.Expressions;
using Anura.JavaScript.Runtime.References;

namespace Anura.JavaScript.Runtime.Interpreter.Statements
{
    internal sealed class JintVariableDeclaration : JintStatement<VariableDeclaration>
    {
        private static readonly Completion VoidCompletion = new Completion(CompletionType.Normal, Undefined.Instance, null, default);

        private ResolvedDeclaration[] _declarations;

        private sealed class ResolvedDeclaration
        {
            internal JintExpression Left;
            internal BindingPattern LeftPattern;
            internal JintExpression Init;
            internal JintIdentifierExpression LeftIdentifier;
            internal bool EvalOrArguments;
        }

        public JintVariableDeclaration(Engine engine, VariableDeclaration statement) : base(engine, statement)
        {
            _initialized = false;
        }

        protected override void Initialize()
        {
            _declarations = new ResolvedDeclaration[_statement.Declarations.Count];
            for (var i = 0; i < _declarations.Length; i++)
            {
                var declaration = _statement.Declarations[i];

                JintExpression left = null;
                JintExpression init = null;
                BindingPattern bindingPattern = null;
                if (declaration.Init != null)
                {
                    if (declaration.Id is Expression expression)
                    {
                        left = JintExpression.Build(_engine, expression);
                    }
                    else if (declaration.Id is BindingPattern bp)
                    {
                        bindingPattern = bp;
                    }
                        
                    init = JintExpression.Build(_engine, declaration.Init);
                }

                var leftIdentifier = left as JintIdentifierExpression;
                _declarations[i] = new ResolvedDeclaration
                {
                    Left = left,
                    LeftPattern = bindingPattern,
                    LeftIdentifier = leftIdentifier,
                    EvalOrArguments = leftIdentifier?.HasEvalOrArguments == true,
                    Init = init
                };
            }
        }

        protected override Completion ExecuteInternal()
        {
            foreach (var declaration in _declarations)
            {
                if (declaration.Init != null)
                {
                    if (declaration.LeftPattern != null)
                    {
                        BindingPatternAssignmentExpression.ProcessPatterns(
                            _engine,
                            declaration.LeftPattern,
                            declaration.Init.GetValue(),
                            checkReference: false /* we are variable assignment*/);
                    }
                    else if (declaration.LeftIdentifier == null
                        || JintAssignmentExpression.SimpleAssignmentExpression.AssignToIdentifier(
                            _engine,
                            declaration.LeftIdentifier,
                            declaration.Init,
                            declaration.EvalOrArguments) is null)
                    {
                        // slow path
                        var lhs = (Reference) declaration.Left.Evaluate();
                        lhs.AssertValid(_engine);

                        var value = declaration.Init.GetValue().Clone();

                        if (declaration.Init._expression.IsFunctionWithName())
                        {
                            ((FunctionInstance) value).SetFunctionName(lhs.GetReferencedName());
                        }

                        _engine.PutValue(lhs, value);
                        _engine._referencePool.Return(lhs);
                    }
                }
            }

            return VoidCompletion;
        }
    }
}