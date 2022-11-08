import React, { useEffect, useState } from 'react';

function App() {

    const [duration, setDuration] = useState("");
    const [amount, setAmount] = useState("");
    const [selectedLoanType, setSelectedLoanType] = useState("");
    const [loanTypes, setLoanTypes] = useState([]);

    const loadLoanTypes = async () => {
        const response = await fetch('/loans');
        const data = await response.json();
        console.log(data);
        setLoanTypes(data);
    };

    useEffect(() => {
        loadLoanTypes();
    }, []);

    let handleSubmit = async (e) => {
        e.preventDefault();
        const requestOptions = {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({
                "paybackSchemeType": "linear",
                "durationInYears": duration,
                "loanAmount": amount,
                "loanTypeId": selectedLoanType
            })
        };
        const response = await fetch('/loans/calculate', requestOptions)
        const data = await response.json();
        alert('Monthly payment is: ' + data);
    }
    let renderLoanTypesSelect = () => {
        return (
            <label>
                Loan Type:
                <select value={selectedLoanType} onChange={(e) => setSelectedLoanType(e.target.value)}>
                    <option>Please choose one option</option>
                    {loanTypes.map((loanType) => {
                        return <option value={loanType.id} >
                            {loanType.name}
                        </option>
                    })}
                </select>
            </label>
        );
    }

    return (
        <>
            <div className="App">
                <h1 id="tabelLabel" >Loan Calculator</h1>
                <form onSubmit={handleSubmit}>
                    <p>{renderLoanTypesSelect()}</p>

                    <p><label> Loan Amount
                        <input type="number" value={amount} onChange={(e) => setAmount(e.target.value)} />
                    </label></p>
                    <p><label> Payback Duration (years)
                        <input type="number" value={duration} onChange={(e) => setDuration(e.target.value)} />
                    </label></p>
                    <p><input type="submit" value="Calculate" /></p></form>

            </div>
        </>
    );
};




export default App;