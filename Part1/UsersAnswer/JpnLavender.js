var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var arr = input.replace(/\r?\n/g,"").split(" ");

function sum(a){
  var result = 0;
  for (var i = 0; i < a.length; i++ ) {
    result += parseFloat(a[i]);
  }
  return result;
}

console.log( sum(arr) );
