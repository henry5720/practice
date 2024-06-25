const Item=({item, className})=>{
    // console.log("Item", {item});
    return (
        <ul className={className}>
            {item.map((ele, index)=>{
                return (
                    <li key={index}>
                        <img src={ele.img} alt="" />
                        <span>{ele.name}</span>
                    </li>
                )
            })}
        </ul>
    )
}

export default Item;