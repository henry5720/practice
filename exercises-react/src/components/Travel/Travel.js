import { useState } from "react";
import "./travel.css";
import { Logo } from "./Obj/Logo";
import { Form } from "./Obj/Form";
import { PackingList } from "./Obj/PackingList";
import { Status } from "./Obj/Status";

const initialItems=[
    {id: 1, description: "Passports", quantity: 2, packed: false},
    {id: 2, description: "Socks", quantity: 12, packed: true},
];
const Travel=()=>{
    const [items, setItems]=useState(initialItems);
    const handleAddItems=(item)=>{
        setItems(items=>[...items, item]);
    }
    const handleDeleteItems=(id)=>{
        setItems(items=>items.filter(item=>item.id !== id));
    }
    const handleToggleItems=(id)=>{
        // console.log(id);
        setItems(items=>items.map(item=>item.id===id
            ?{...item, packed: !item.packed}
            :item
        ))
    }
    const handleClear=()=>{
        const confirm=window.confirm("Are you sure you want to delete all items?");
        if (confirm) {
            setItems([]);
        }
    }
    return (
        <div className="app">
            <Logo></Logo>
            <Form onAddItems={handleAddItems}></Form>
            <PackingList
                items={items}
                onDeleteItems={handleDeleteItems}
                onTaggleItem={handleToggleItems}
                onClear={handleClear}
            ></PackingList>
            <Status items={items}></Status>
        </div>
    )
}
const SeletedList=({items, sortedItems})=>{
    const [sortBy, setSortBy]=useState("description");
    const handleChange=(event)=>{
        // console.log(event.target.value);
        setSortBy(event.target.value);
    }
    switch (sortBy) {
        case "input":
            break;
        case "description":
        break
        default:
            break;
    }
    return (
        <div className="actions">
            <select value={sortBy} onChange={handleChange}>
                <option value="input">Sort by input order</option>
                <option value="description">Sort by description</option>
                <option value="packed">Sort by packed status</option>
            </select>
        </div>
    )
}
export default Travel;