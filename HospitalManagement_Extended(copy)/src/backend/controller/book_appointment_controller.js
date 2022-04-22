const moment = require("moment");
const { db } = require("../db.connection");

async function getappointment(req, res) {
  try {
    console.log(res)
    const result = await db.many(`select * from book_appointment`);
    return res.status(200).json(result);
  } catch (error) {
    return res
      .status(500)
      .json({ message: error.message ? error.message : "somthing went wrong" });
  }
}

async function addappointment(req, res) {
  console.log(typeof req.body);

  try {
    //  let currentTime=moment().format('YYYY-MM-DD')
    let appDate = new Date(req.body.appointment_date);
    moment(appDate).format("YYYY-MM-DD");

    await db.none(
      
      `insert into "book_appointment"
    ("first_name","last_name", "gender","address","mobile_no","email","doctor_name","speciality","appointment_date","appointment_time") VALUES ($1,$2,$3,$4,$5,$6,$7,$8,$9,$10)`,

      [
        req.body.pFirstName,
        req.body.pLastName,
        req.body.gender,
        req.body.address,
        req.body.mobile,
        req.body.email,
        req.body.doctorName,
        req.body.speciality,
        req.body.aptdate,
        req.body.apttime
        
      ]
    );
    return res.status(201).json({ message: "book appointment sucessfully" });
  } catch (error) {
    return res
      .status(500)
      .json({ message: error.message ? error.message : "somthing went wrong" });
  }
}

// function addAppointment(Req, res) {
//   return res.status(200).json({ message: "working fine" });
// }

module.exports = {
  getappointment,
  addappointment,
};
