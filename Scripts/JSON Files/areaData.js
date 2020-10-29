var express= require('express');
var app = express();

app.get('/test', function(req, res) {
  var retval = {
    department: '1X93',
    floor: '354',
    area: 8324,
    sales: 4000000,
  };
  res.json(retval);
});

app.listen(3000);
console.log("listening on port 3000");
