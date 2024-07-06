import { useState } from "react";

export const Form=({onAddItems})=>{
    const [description, setDescription]=useState("");
    const [quantity, setQuantity]=useState(1);

    const handleSubmit=(e)=>{
        e.preventDefault();
        if(!description) return;
        const newItem={id: Date.now(), description, quantity, packed: false};
        console.log({newItem});
        onAddItems(newItem);
        setDescription("");
        setQuantity(1);
    }
    const handleChange=(e)=>{
        setQuantity(Number(e.target.value));
    }
    return (
        <form className="add-form" onSubmit={handleSubmit}>
            <h3 className="title">What do you need for your trip?</h3>
            <select className="mySelect" value={quantity} onChange={handleChange}>
                {
                    Array.from({length: 20}, (_, i)=>i+1).map(
                        num=><option key={num} value={num}>{num}</option>
                    )
                }
            </select>
            <input className="myInput" type="text" placeholder="Item..."
                value={description}
                onChange={(e)=>setDescription(e.target.value)}
            ></input>
            <button className="btn">Add</button>
        </form>
    )
}
