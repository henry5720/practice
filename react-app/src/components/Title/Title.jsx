const Title=({item})=>{
    // console.log(item);
    const flexBox={
        margin: '10px 0',
        display: 'flex',
        justifyContent: 'space-between',
        alignItems: 'center',
    }
    const iconStyle = {
        display: 'block',
        margin: '0 10px',
        width: '30px',
        height: '30px',
        backgroundImage: `url(${item.icon})`,
        backgroundSize: 'contain',
        backgroundPosition: 'center center',
        backgroundRepeat: 'no-repeat'
    };
    const textStyle={
        margin: '0 10px',
        fontSize: '25px',
    }

    return (
        <div style={flexBox}>
            <div style={flexBox}>
                <i style={iconStyle}></i>
                <h2 style={textStyle}>{item.text}</h2>
            </div>
            <span style={textStyle}>{"更多 >"}</span>
        </div>
    )
}

export default Title;