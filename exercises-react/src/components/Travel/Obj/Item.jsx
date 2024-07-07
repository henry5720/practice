export const Item = ({ item, onDeleteItems, onTaggleItem }) => {
    return (
        <li className="item">
            <input className="myInput" type="checkbox" checked={item.packed} onChange={() => onTaggleItem(item.id)}></input>
            <span style={item.packed ? { textDecoration: "line-through" } : {}}>
                {item.quantity} : {item.description}
            </span>
            <button className="btn" onClick={() => onDeleteItems(item.id)}>❌</button>
        </li>
    );
};
