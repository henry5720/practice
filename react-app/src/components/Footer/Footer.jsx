const Footer=()=>{
    const footerList=[
        {
            icon: "./src/assets/icon/home.png",
            text: "首頁"
        },
        {
            icon: "./src/assets/icon/video.png",
            text: "影片"
        },
        {
            icon: "./src/assets/icon/mouse.png",
            text: "角色"
        },
        {
            icon: "./src/assets/icon/person.png",
            text: "我的"
        },
    ];
    const ulStyle={
        position: 'sticky',
        bottom: 0,
        padding: '10px',
        width: '100%',
        display: 'flex',
        justifyContent: 'space-between',
        alignItems: 'center',
        backgroundColor: 'black'
    }
    const liStyle={
        display: 'flex',
        flexDirection: 'column',
        justifyContent: 'space-between',
        alignItems: 'center',
        cursor: 'pointer'
    }
    const imgStyle={
        magin: '0 0 10px 0',
        width: '30px',
        height: '30px',
    }
    return (
        <ul style={ulStyle}>
            {
                footerList.map((item, index)=>{
                    return (
                        <li key={index} style={liStyle}>
                            <img src={item.icon} alt="" style={imgStyle}/>
                            <span>{item.text}</span>
                        </li>
                    )
                })
            }
        </ul>
    );
}

export default Footer;