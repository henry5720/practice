import { useState } from "react";
import "./counter.css";
import { Link } from "react-router-dom";

const Counter=()=>{
    const [step, setStep]=useState(1);
    const [count, setCount]=useState(0);

    return <>
        <Link to="/" className="myLink m-10">
            <div style={{
                height: "100%",
                backgroundImage: `url(${process.env.PUBLIC_URL}/imgs/icons8-home-60.png)`,
                backgroundSize: 'contain',
            }}></div>
        </Link>
        <CounterA step={step} setStep={setStep}></CounterA>
        <CounterB step={step} count={count} setCount={setCount}></CounterB>
        <DateBoard count={count}></DateBoard>
    </>
}
const CounterA=({step, setStep})=>{
    const handleMinus=()=>{
        console.log({step});
        if (step===0) return;
        setStep(step=>step-1);
    }
    const handleAdd=()=>{
        console.log({step});
        setStep(step=>step+1);
    }
    return <div className="middle">
        <button onClick={handleMinus}>-</button>
        <span>Step:</span>
        <div>{step}</div>
        <button onClick={handleAdd}>+</button>
    </div>
}
const CounterB=({step, count, setCount})=>{
    const handleMinus=()=>{
        console.log({step, count});
        setCount(count=>count-step);
    }
    const handleAdd=()=>{
        console.log({step, count});
        setCount(count=>count+step);
    }
    return <div className="middle">
        <button onClick={handleMinus}>-</button>
        <span>Count:</span>
        <div>{count}</div>
        <button onClick={handleAdd}>+</button>
    </div>

}
const DateBoard=({count})=>{
    const date=new Date();
    console.log({date, count});
    date.setDate(date.getDate()+count);

    return <>
        <h1 className="middle">
            {
                count===0
                ?"Today is : "
                :count>0
                ?`${count} days from today is `
                :`${Math.abs(count)} days ago was `
            }
            {date.toLocaleDateString()}
        </h1>;
    </>
}
export default Counter;