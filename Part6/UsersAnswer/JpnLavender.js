var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var splitValue = input.replace(/(^\s+)|(\s+$)/g, "").split('\n');
var checkCase = RegExp(splitValue[1]);

console.log( checkCase.test(splitValue[0]) ? "true" : "false" )

