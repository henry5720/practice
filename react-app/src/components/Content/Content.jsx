import Title from "../Title/Title";
import Item from "../Item/Item";

const Content = ({data}) => {
    return (
        <ul>
            {data.map((item, index) => {
                // console.log({item});
                return (
                <li key={index}>
                    <Title item={item.title}></Title>
                    <Item item={item.element} className={item.style}></Item>
                </li>
                );
            })}
        </ul>
    );
};

export default Content;
