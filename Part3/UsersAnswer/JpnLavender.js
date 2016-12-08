var fs = require('fs');
var input = fs.readFileSync('/dev/stdin', 'utf8');

var processing = input.split('\n');
var money      = processing[1].split(" ");
var answer     = 0;

money.forEach(function(value, index){
  answer += parseInt(value);
});

console.log( Math.floor(answer * 1.08) );
