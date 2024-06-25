import "./App.css"
import data from "./data/data";
import Nav from "./components/Nav/Nav";
import Content from "./components/Content/Content";
import Footer from "./components/Footer/Footer";
const App=()=>{
  console.log({data});
  return (
    <>
      <Nav></Nav>
      <div className="banner"></div>
      <Content data={data}></Content>
      <Footer></Footer>
    </>
  );
}

export default App;