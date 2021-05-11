lexer grammar Grammar;

Number: Sign? ( UnsignedInteger | UnsignedReal );
fragment Sign: Plus | Minus;
fragment UnsignedInteger: DigitSequence 
                        | Dollar HexSequence
                        | Ampersand OctalSequence
                        | Percent BinSequence; 
fragment UnsignedReal: DigitSequence (Dot DigitSequence)? ScaleFactor?;
fragment ScaleFactor: E Sign? DigitSequence;  

fragment Plus: '+';
fragment Minus: '-';
fragment Dollar: '$';
fragment Ampersand: '&';
fragment Percent: '%';
fragment Dot: '.';
fragment E: 'E' | 'e';

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

CharacterString: (QuotedString | ControlString)+;
fragment QuotedString: Quote (~['\n] | Quote Quote)* Quote;
fragment Quote: '\'';
fragment ControlString: Hash UnsignedReal;
fragment Hash: '#';

Comment: SingleComment | MultilineComment;
fragment SingleComment: DoubleSlash ~[\n\r]*;
fragment DoubleSlash: '//';
fragment MultilineComment: LCurlyBrace NestedComment RCurlyBrace
                         | LBraceStar NestedComment RBraceStar;
fragment NestedComment: (MultilineComment | .)*?;
fragment LCurlyBrace: '{';
fragment RCurlyBrace: '}';
fragment LBraceStar: '(*';
fragment RBraceStar: '*)';

Symbol: Letter | Digit | Hex;
Whitespace: [ \n\t\r]+;
Semicolon: ';';
LBrace: '(';
RBrace: ')';
Eop: '.';
Error: .+?;