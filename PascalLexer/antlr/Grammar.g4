lexer grammar Grammar;

Number: Sign? ( UnsignedInteger | UnsignedReal );
fragment Sign: '+' | '-';
fragment UnsignedInteger: DigitSequence 
                         | '$' HexSequence
                         | '&' OctalSequence
                         | '%' BinSequence; 
fragment UnsignedReal: DigitSequence ('.' DigitSequence)? ScaleFactor?;
fragment ScaleFactor: ('E' | 'e') Sign? DigitSequence;  
fragment DigitSequence: Digit+;
fragment BinSequence: Bin+;
fragment HexSequence: Hex+;
fragment OctalSequence: Octal+;
fragment Digit: [0-9];
fragment Hex: [0-9a-fA-F];
fragment Octal: [0-7];
fragment Bin: [0-1];

Identifier: (Letter | Underscore) (Letter | Digit | Underscore)*;
fragment Letter: [a-zA-Z];
fragment Underscore: '_';