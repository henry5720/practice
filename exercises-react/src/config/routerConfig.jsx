import Home from "../components/Home/Home";
import Step from "../components/Step/Step";
import Counter from "../components/Counter/Counter";
import Travel from "../components/Travel/Travel";
import FlashCards from "../components/FlashCards/FlashCards";
import Range from "../components/Range/Range";
import Tip from "../components/Tip/Tip";
const routerList=[
    {
        name: "Home",
        route: "/",
        component: <Home></Home>
    },
    {
        name: "Step",
        route: "/step",
        component: <Step></Step>
    },
    {
        name: "Counter",
        route: "/counter",
        component: <Counter></Counter>
    },
    {
        name: "Travel",
        route: "/travel",
        component: <Travel></Travel>
    },
    {
        name: "FlashCards",
        route: "/flashCards",
        component: <FlashCards></FlashCards>
    },
    {
        name: "Range",
        route: "/range",
        component: <Range></Range>
    },
    {
        name: "Tip",
        route: "/tip",
        component: <Tip></Tip>
    }
];
export default routerList;