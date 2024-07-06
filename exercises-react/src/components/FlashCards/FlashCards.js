import "./flashcards.css";
import { useState } from "react";
import { Link } from "react-router-dom";

const questions = [
    {
        id: 3457,
        question: "What language is React based on?",
        answer: "JavaScript",
    },
    {
        id: 7336,
        question: "What are the building blocks of React apps?",
        answer: "Components",
    },
    {
        id: 8832,
        question: "What's the name of the syntax we use to describe a UI in React?",
        answer: "JSX",
    },
    {
        id: 1297,
        question: "How to pass data from parent to child components?",
        answer: "Props",
    },
    {
        id: 9103,
        question: "How to give components memory?",
        answer: "useState hook",
    },
    {
        id: 2002,
        question:
        "What do we call an input element that is completely synchronised with state?",
        answer: "Controlled element",
    },
];

const FlashCards = () => {
    const [selected, setSelected]=useState(null);
    const handleClicked=(id)=>{
        setSelected(id);
    }
    return (
        <>
            <Link to="/" className="myLink m-10">
                <div style={{
                    height: "100%",
                    backgroundImage: `url(${process.env.PUBLIC_URL}/imgs/icons8-home-60.png)`,
                    backgroundSize: 'contain',
                }}></div>
            </Link>
            <div className="flashcards">
                {
                    questions.map(item=>
                        <div key={item.id} onClick={()=>handleClicked(item.id)} className={selected===item.id?"selected":""}>
                            <p>
                                {selected===item.id?item.answer:item.question}
                            </p>
                        </div>
                    )
                }
            </div>
        </>
    );
};

export default FlashCards;
