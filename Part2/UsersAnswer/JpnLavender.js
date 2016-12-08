var input = require('fs').readFileSync('/dev/stdin', 'utf8');
console.log(Math.floor( Math.random() * input ));
