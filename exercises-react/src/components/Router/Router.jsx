import { HashRouter , Routes, Route } from 'react-router-dom';
import routerList from "../../config/routerConfig";

const Router=()=>{
    return (
        <HashRouter>
            <Routes>
                {
                    routerList.map((item, index)=>{
                        return (
                            <Route key={index} path={item.route} element={item.component} />
                        );
                    })
                }
            </Routes>
        </HashRouter>
    );
}
export default Router;
