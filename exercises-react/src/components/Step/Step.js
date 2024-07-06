import { useState } from "react";
import "./step.css";
import { Link } from "react-router-dom";
const messages = [
  "Learn React *",
  "Apply for jobs *",
  "Invest your new income",
];
const Step = () => {
  const [step, setStep] = useState(1);
  const [isOpen, setIsOpen] = useState(true);
  const handlePrevious=()=>{
    if(step>1) setStep(step-1);
  }
  const handleNext=()=>{
    if(step<3) setStep(step+1);
  }
  return (
    <>
      <div className="homeBox">
        <button className="myLink m-10" onClick={()=>setIsOpen(!isOpen)}>
          <div style={
            isOpen
            ?{
                height: "100%",
                backgroundImage: `url(${process.env.PUBLIC_URL}/imgs/icons8-no-idea-60.png)`,
                backgroundSize: 'contain',
            }
            :{
              height: "100%",
              backgroundImage: `url(${process.env.PUBLIC_URL}/imgs/icons8-light-60.png)`,
              backgroundSize: 'contain',
            }
          }></div>
        </button>
        <Link to="/" className="myLink m-10">
          <div style={{
              height: "100%",
              backgroundImage: `url(${process.env.PUBLIC_URL}/imgs/icons8-home-60.png)`,
              backgroundSize: 'contain',
          }}>
          </div>
        </Link>
      </div>

      { isOpen && (
        <div className="steps">
          <div className="numbers">
            <div className={step >= 1 ? "active" : ""}>1</div>
            <div className={step >= 2 ? "active" : ""}>2</div>
            <div className={step >= 3 ? "active" : ""}>3</div>
          </div>
          <p className="message">
            Step {step}: {messages[step - 1]}
          </p>
          <div className="buttons">
            <Button bgColor={"#7950f2"} color={"#fff"} onClick={handlePrevious}>
            <span>{"<"}</span> Previous
            </Button>
            <Button bgColor={"#7950f2"} color={"#fff"} onClick={handleNext}>
              Next <span>{">"}</span>
            </Button>
          </div>
        </div>
        )
      }
    </>
  );
};

const Button=({textColor, bgColor, onClick, children})=>{
  return (
    <button
      style={{ backgroundColor: bgColor, color: textColor }}
      onClick={onClick}
    >
      {children}
    </button>
  )
}

export default Step;
