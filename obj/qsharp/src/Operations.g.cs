#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"toffoli_gate\",\"Name\":\"ThreeQbitsRun\"},\"SourceFile\":\"/Users/telstra/repository/quantum/toffoli-gate/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"toffoli_gate\",\"Name\":\"ThreeQbitsRun\"},\"SourceFile\":\"/Users/telstra/repository/quantum/toffoli-gate/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"toffoli_gate\",\"Name\":\"Set\"},\"SourceFile\":\"/Users/telstra/repository/quantum/toffoli-gate/Operations.qs\",\"Position\":{\"Item1\":57,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"toffoli_gate\",\"Name\":\"Set\"},\"SourceFile\":\"/Users/telstra/repository/quantum/toffoli-gate/Operations.qs\",\"Position\":{\"Item1\":57,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
#line hidden
namespace toffoli_gate
{
    public partial class ThreeQbitsRun : Operation<QVoid, (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>, ICallable
    {
        public ThreeQbitsRun(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ThreeQbitsRun";
        String ICallable.FullName => "toffoli_gate.ThreeQbitsRun";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumIntrinsicCCNOT
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        public override Func<QVoid, (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)> Body => (__in__) =>
        {
#line 9 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
            var num000 = 0L;
#line 10 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
            var num001 = 0L;
#line 11 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
            var num010 = 0L;
#line 12 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
            var num011 = 0L;
#line 13 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
            var num100 = 0L;
#line 14 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
            var num101 = 0L;
#line 15 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
            var num110 = 0L;
#line 16 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
            var num111 = 0L;
#line hidden
            {
#line 18 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                var qubits = Allocate.Apply(3L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 20 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                    foreach (var test in new Range(1L, 10000L))
#line hidden
                    {
#line 22 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                        Set.Apply((Result.Zero, qubits[0L]));
#line 23 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                        Set.Apply((Result.Zero, qubits[1L]));
#line 24 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                        Set.Apply((Result.Zero, qubits[2L]));
#line 27 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                        Set.Apply((Result.One, qubits[0L]));
#line 28 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                        Set.Apply((Result.One, qubits[1L]));
#line 29 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                        Set.Apply((Result.One, qubits[2L]));
#line 30 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                        MicrosoftQuantumIntrinsicCCNOT.Apply((qubits[0L], qubits[1L], qubits[2L]));
#line 33 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                        var res0 = MicrosoftQuantumIntrinsicM.Apply(qubits[0L]);
#line 34 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                        var res1 = MicrosoftQuantumIntrinsicM.Apply(qubits[1L]);
#line 35 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                        var res2 = MicrosoftQuantumIntrinsicM.Apply(qubits[2L]);
#line 37 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                        if ((((res2 == Result.Zero) && (res1 == Result.Zero)) && (res0 == Result.Zero)))
                        {
#line 37 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                            num000 = (num000 + 1L);
                        }

#line 38 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                        if ((((res2 == Result.Zero) && (res1 == Result.Zero)) && (res0 == Result.One)))
                        {
#line 38 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                            num001 = (num001 + 1L);
                        }

#line 39 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                        if ((((res2 == Result.Zero) && (res1 == Result.One)) && (res0 == Result.Zero)))
                        {
#line 39 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                            num010 = (num010 + 1L);
                        }

#line 40 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                        if ((((res2 == Result.Zero) && (res1 == Result.One)) && (res0 == Result.One)))
                        {
#line 40 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                            num011 = (num011 + 1L);
                        }

#line 41 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                        if ((((res2 == Result.One) && (res1 == Result.Zero)) && (res0 == Result.Zero)))
                        {
#line 41 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                            num100 = (num100 + 1L);
                        }

#line 42 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                        if ((((res2 == Result.One) && (res1 == Result.Zero)) && (res0 == Result.One)))
                        {
#line 42 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                            num101 = (num101 + 1L);
                        }

#line 43 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                        if ((((res2 == Result.One) && (res1 == Result.One)) && (res0 == Result.Zero)))
                        {
#line 43 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                            num110 = (num110 + 1L);
                        }

#line 44 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                        if ((((res2 == Result.One) && (res1 == Result.One)) && (res0 == Result.One)))
                        {
#line 44 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                            num111 = (num111 + 1L);
                        }
                    }

#line 47 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                    Set.Apply((Result.Zero, qubits[0L]));
#line 48 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                    Set.Apply((Result.Zero, qubits[1L]));
#line 49 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                    Set.Apply((Result.Zero, qubits[2L]));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(qubits);
                }
            }

#line 53 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
            return (num000, num001, num010, num011, num100, num101, num110, num111);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicCCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CCNOT));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Set));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut((Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)> Run(IOperationFactory __m__)
        {
            return __m__.Run<ThreeQbitsRun, QVoid, (Int64,Int64,Int64,Int64,Int64,Int64,Int64,Int64)>(QVoid.Instance);
        }
    }

    public partial class Set : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public Set(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Qubit)>, IApplyData
        {
            public In((Result,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Set";
        String ICallable.FullName => "toffoli_gate.Set";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(Result,Qubit), QVoid> Body => (__in__) =>
        {
            var (desired,q1) = __in__;
#line 61 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
            var current = MicrosoftQuantumIntrinsicM.Apply(q1);
#line 62 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
            if ((desired != current))
            {
#line 65 "/Users/telstra/repository/quantum/toffoli-gate/Operations.qs"
                MicrosoftQuantumIntrinsicX.Apply(q1);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((Result,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, q1));
        }
    }
}