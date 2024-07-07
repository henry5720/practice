import { Link } from "react-router-dom";

export const Logo=()=>{
    return (
            <h1 className="logo">
                <Link to="/" className="myLink m-10">
                    <div className="homeBtn"></div>
                </Link>
                Far Away
            </h1>
    );
}
