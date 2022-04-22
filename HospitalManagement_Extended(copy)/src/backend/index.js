const express = require('express');
const app = express();
const cors=require('cors')

app.use(cors());
app.use(express.json());
const port = 3000;

app.listen(port,()=>{
    console.log(`started on PORT ${port}`)
})

app.use('/api/appointment',require('./router/book_appointment'))