import { useState } from "react";
import { Item } from "./Item";

export const PackingList = ({ items, onDeleteItems, onTaggleItem, onClear }) => {
    const [sortBy, setSortBy] = useState("input");
    const handleChange = (event) => {
        // console.log(event.target.value);
        setSortBy(event.target.value);
    };

    let sortedItems = items;
    switch (sortBy) {
        case "input":
            sortedItems = items;
            break;
        case "description":
            sortedItems = items.slice().sort((a, b) => a.description.localeCompare(b.description));
            break;
        case "packed":
            sortedItems = items.slice().sort((a, b) => Number(a.packed) - Number(b.packed));
            break;
        default:
            sortedItems = items;
            break;
    }

    return (
        <div className="list">
            <ul>
                {sortedItems.map(item => <Item key={item.id} item={item}
                    onDeleteItems={onDeleteItems}
                    onTaggleItem={onTaggleItem}
                ></Item>
                )}
            </ul>
            <div className="actions">
                <select value={sortBy} onChange={handleChange}>
                    <option value="input">Sort by input order</option>
                    <option value="description">Sort by description</option>
                    <option value="packed">Sort by packed status</option>
                </select>
                <button className="btn" onClick={onClear}>Clear list</button>
            </div>
        </div>
    );
};
