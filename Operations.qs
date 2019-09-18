namespace toffoli_gate
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;

	operation ThreeQbitsRun () : (Int,Int,Int,Int,Int,Int,Int,Int)
    {

        mutable num000 = 0;
        mutable num001 = 0;
        mutable num010 = 0;
        mutable num011 = 0;
        mutable num100 = 0;
        mutable num101 = 0;
        mutable num110 = 0;
        mutable num111 = 0;

        using (qubits = Qubit[3])
        {
            for (test in 1..10000)
            {
                Set (Zero, qubits[0]);
                Set (Zero, qubits[1]);
                Set (Zero, qubits[2]);

                // Toffoli Gate in general configuration
                Set (One, qubits[0]);
                Set (One, qubits[1]);
                Set (One, qubits[2]);
                CCNOT(qubits[0],qubits[1],qubits[2]);

                // Take measurements (Collapse the wavefunction :)
                let res0 = M (qubits[0]);
                let res1 = M (qubits[1]);
                let res2 = M (qubits[2]);

                if(res2 == Zero and res1 == Zero and res0 == Zero){set num000 = num000 + 1;}
                if(res2 == Zero and res1 == Zero and res0 == One ){set num001 = num001 + 1;}
                if(res2 == Zero and res1 == One  and res0 == Zero){set num010 = num010 + 1;}
                if(res2 == Zero and res1 == One  and res0 == One ){set num011 = num011 + 1;}
                if(res2 == One  and res1 == Zero and res0 == Zero){set num100 = num100 + 1;}
                if(res2 == One  and res1 == Zero and res0 == One ){set num101 = num101 + 1;}
                if(res2 == One  and res1 == One  and res0 == Zero){set num110 = num110 + 1;}
                if(res2 == One  and res1 == One  and res0 == One ){set num111 = num111 + 1;}

            }
            Set(Zero, qubits[0]);
            Set(Zero, qubits[1]);
            Set(Zero, qubits[2]);
        }
        

        return (num000, num001, num010, num011, num100, num101, num110, num111);

    
    }

	operation Set (desired: Result, q1: Qubit) : Unit
    {
        // Measure qbit - collapse superposition (Schrodinger's cat :)
        let current = M(q1);
        if (desired != current)
        {
            // Invert value (NOT on qbit)
            X(q1);
        }
    }    
}
