var express= require('express');
var app = express();

app.get('/test', function(req, res) {
  var retval = {
    "2016" : 48320387864,
    "2017" : 38600011230,
    "2018" : 70035632100,
    "2019" : 80343410000
  };
  res.json(retval);
});

app.listen(3002);
console.log("listening on port 3002");
