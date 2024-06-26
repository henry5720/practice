const express=require('express');
const app=express();
const PORT=3000

app.get("/", (req, res)=>{
    res.send("<p>hello</p>")
})

app.listen(PORT, ()=>console.log('[server] http://localhost:3000'))