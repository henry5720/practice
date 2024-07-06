import { BrowserRouter, Routes, Route } from 'react-router-dom';
import routerList from "../../config/routerConfig";

const Router=()=>{
    return (
        <BrowserRouter>
            <Routes>
                {
                    routerList.map((item, index)=>{
                        return (
                            <Route key={index} path={item.route} element={item.component} />
                        );
                    })
                }
            </Routes>
        </BrowserRouter>
    );
}
export default Router;
