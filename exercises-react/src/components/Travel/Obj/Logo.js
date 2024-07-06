import { Link } from "react-router-dom";

export const Logo=()=>{
    return (
            <h1 className="logo">
                <Link to="/" className="myLink m-10">
                    <div style={{
                        height: "100%",
                        backgroundImage: `url(${process.env.PUBLIC_URL}/imgs/icons8-home-60.png)`,
                        backgroundSize: 'contain',
                    }}></div>
                </Link>
                Far Away
            </h1>
    );
}
