var express= require('express');
var app = express();

app.get('/test', function(req, res) {
  var retval = {
    "2016" : 4000000,
    "2017" : 3860000,
    "2018" : 70000,
    "2019" : 800000,

  };
  res.json(retval);
});

app.listen(3001);
console.log("listening on port 3001");
