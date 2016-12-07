var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var money = input.split(" ");
var answer = 0;

money.forEach(function(value, index){
  answer += parseInt(value);
});

console.log( Math.floor(answer * 1.08) );
