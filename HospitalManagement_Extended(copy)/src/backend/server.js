// const promise = require("bluebird");


// const initOptions = {
//     promiseLib: promise // overriding the default (ES6 Promise);
// };

// const pgp = require('pg-promise')(initOptions);
// // See also: http://vitaly-t.github.io/pg-promise/module-pg-promise.html

// // Database connection details;
// const cn = {
//     host: 'localhost', // 'localhost' is the default;
//     port: 5432, // 5432 is the default;
//     database: 'student',
//     user: 'postgres',
//     password: 'root',

//     // to auto-exit on idle, without having to shut-down the pool;
//     // see https://github.com/vitaly-t/pg-promise#library-de-initialization
//     allowExitOnIdle: true
// };
// // You can check for all default values in:
// // https://github.com/brianc/node-postgres/blob/master/packages/pg/lib/defaults.js

// const db = pgp(cn); // database instance;

// var data = undefined;

// db.many("Select * from Student;")
// .then((data) => { 
//    this.data =  data;
// }).catch((error) => {
//     console.log("Error : " + error);
// });

// const express = require("express");
// const port = 3000;  
// const server = express();

// const cors = require("cors");

// server.use(cors());

// server.get("/students",(req, res) => {
//     res.setHeader("content-type","application/json");
//     res.send(this.data);
// });

// server.listen(port,()=> {
//         console.log("Server started");
//     });





