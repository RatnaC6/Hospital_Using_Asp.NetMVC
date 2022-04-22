const express = require("express");
const userRouter = express.Router();


const book_appointmentController=require('../controller/book_appointment_controller');

userRouter.get('/',book_appointmentController.getappointment)
userRouter.post('/',book_appointmentController.addappointment)


module.exports=userRouter