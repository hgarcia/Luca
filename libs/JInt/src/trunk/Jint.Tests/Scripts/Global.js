// 15.1.2.1
assert(1, eval(1));
var i = 1;
assert(2, eval("i = i + 1")); 

assert(NaN, parseInt("x"));
assert(10, parseInt("10"));
assert(16, parseInt("0x10"));
assert(2, parseInt("10", 2));
assert(8, parseInt("10", 8));

assert(NaN, parseFloat("x"));
assert(1, parseFloat("1"));
assert(10, parseFloat("1e1"));
assert(1.5, parseFloat("15e-1"));

istrue(isFinite(0));
isfalse(isFinite(NaN));
isfalse(isFinite(1 / 0));
isfalse(isFinite(Infinity));

assert('~!@#$%25%5E&*()%7B%7D[]=:/,;?+\'%22%5C', encodeURI('~!@#$%^&*(){}[]=:/,;?+\'"\\'));
assert('~!%40%23%24%25%5E%26*()%7B%7D[]%3D%3A%2F%2C%3B%3F%2B\'%22%5C', encodeURIComponent('~!@#$%^&*(){}[]=:/,;?+\'"\\'));

