var express= require('express');
var app = express();

app.get('/test', function(req, res) {
  var retval = {
    "2016" : 12376123761,
    "2017" : 89398123782,
    "2018" : 26372361028,
    "2019" : 93837627262,

  };
  res.json(retval);
});

app.listen(3003);
console.log("listening on port 3003");
