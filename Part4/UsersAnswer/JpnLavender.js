var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var x     = input.split(" ");

function calculation(value){
  var useEnergy     = parseInt(value[1]) / parseInt(value[2]);
  var amountOfMoney = useEnergy * parseInt(value[3]);
  var splitAmount  = amountOfMoney / parseInt(parseInt(value[0]) + 1);
  var reciprocatingDistance = splitAmount * 2;
  return Math.floor(reciprocatingDistance);
}

console.log(calculation(x));
