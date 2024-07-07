import { useState } from "react";
import "./range.css";
import { Link } from "react-router-dom";

const Range=()=>{
    const [rangeNum, setRangeNum]=useState(1);
    const [count, setCount]=useState(0);
    const handleChange=(e)=>{
        setRangeNum(e.target.value);
    }
    const handleMinus=()=>{
        setCount(count=>count-rangeNum);
    }
    const handleAdd=()=>{
        setCount(count=>Number(count)+Number(rangeNum));
    }
    const handleTxet=(e)=>{
        const num=isNaN(e.target.value)?0:e.target.value;
        setCount(num);
    }
    const handleReset=()=>{
        setRangeNum(1)
        setCount(0)
    }
    const date=new Date();
    date.setDate(date.getDate()+count);
    return (
        <div className="container">
            <Link to="/" className="myLink m-10">
                <div className="homeBtn"></div>
            </Link>
            <div className="rangeBox">
                <input
                    type="range"
                    min={0}
                    max={10}
                    value={rangeNum}
                    onChange={handleChange}
                >
                </input>
                <i>Step: {rangeNum}</i>
            </div>
            <div className="counterBox">
                <button className="stepBtn" onClick={handleMinus}>-</button>
                <input type="text" value={count} onChange={handleTxet}></input>
                <button className="stepBtn" onClick={handleAdd}>+</button>
            </div>
            <h1>
                {count===0
                    ? date.toDateString()
                    : count > 0
                        ? `${count} days from today is ${date.toDateString()}`
                        : `${count} days ago was ${date.toDateString()}`
                }
            </h1>
            {
                (rangeNum!==1 || count!==0)
                ? <button onClick={handleReset}>Reset</button>
                : null
            }
        </div>
    )
}

export default Range;