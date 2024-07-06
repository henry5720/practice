import { useState } from "react"
import { Link } from "react-router-dom";

const you={
    question: "How did you like the service?",
    option: [
        {text: "Dissatisfied", value: 0},
        {text: "It was okay", value: 5},
        {text: "It was good", value: 10},
        {text: "Absolutely amazing!", value: 20},
    ]
}
const youFriend={
    question: "How did your friend like the service?",
    option: [
        {text: "Dissatisfied", value: 0},
        {text: "It was okay", value: 5},
        {text: "It was good", value: 10},
        {text: "Absolutely amazing!", value: 20},
    ]
}

const Tip=()=>{
    const [bill, setBill]=useState(0);
    const [serviceTip1, setServiceTip1]=useState(0)
    const [serviceTip2, setServiceTip2]=useState(0)

    return (
        <>
            <Link to="/" className="myLink m-10">
                    <div className="homeBtn"></div>
            </Link>
            <Bill bill={bill} setBill={setBill}></Bill>
            <Option content={you} serviceTip={serviceTip1} setServiceTip={setServiceTip1}></Option>
            <Option content={youFriend} serviceTip={serviceTip2} setServiceTip={setServiceTip2}></Option>
            <TotalPay bill={bill} serviceTip1={serviceTip1} serviceTip2={serviceTip2}></TotalPay>
            <Reset setBill={setBill} setServiceTip1={setServiceTip1} setServiceTip2={setServiceTip2} ></Reset>
        </>
    )
}

const Bill=({bill, setBill})=>{
    const handleChange=(e)=>{
        console.log(e.target.value);
        setBill(e.target.value);
    }
    return (
        <>
            <h2>
                How much was the bill?
            </h2>
            <input type="text" value={bill} onChange={handleChange}></input>
        </>
    )
}

const Option=({content, serviceTip, setServiceTip})=>{
    return (
        <>
            <h2>
                {content.question}
            </h2>
            <select value={serviceTip}
                onChange={
                    (e)=>{
                        console.log(e.target.value);
                        setServiceTip(e.target.value)
                    }
            }>
                {
                    content.option.map((item, index)=>{
                        return <option key={index} value={item.value}>{item.text} ({item.value}%)</option>
                    })
                }
            </select>
        </>
    )
}

const TotalPay=({bill, serviceTip1, serviceTip2})=>{
    console.log({bill, serviceTip1, serviceTip2});
    const tip=bill*((Number(serviceTip1)+Number(serviceTip2))*0.01);
    console.log({tip});
    return (
        <h2>
            You pay ${Number(bill)+tip} (${Number(bill)} + ${tip} tip)
        </h2>
    )
}

const Reset=({setBill, setServiceTip1, setServiceTip2})=>{
    const handleReset=()=>{
        setBill(0);
        setServiceTip1(0);
        setServiceTip2(0);
    }
    return (
        <button onClick={handleReset}>Reset</button>
    )
}

export default Tip;