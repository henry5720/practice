import { Link } from 'react-router-dom';
import routerList from "../../config/routerConfig";
import "./home.css";

const Home=()=>{
    return (
        <nav className='routerNav'>
            <ul className='routerUl'>
                {
                    routerList.map((item, index)=>{
                        return (
                            <li key={index} className='routerLi'>
                                <Link to={item.route}>{item.name}</Link>
                            </li>
                        );
                    })
                }
            </ul>
        </nav>
    );
}

export default Home;