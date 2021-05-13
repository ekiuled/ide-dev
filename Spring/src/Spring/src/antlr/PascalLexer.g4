lexer grammar PascalLexer;

channels { Comments, Whitespaces }

fragment A : [aA];
fragment B : [bB];
fragment C : [cC];
fragment D : [dD];
fragment E : [eE];
fragment F : [fF];
fragment G : [gG];
fragment H : [hH];
fragment I : [iI];
fragment J : [jJ];
fragment K : [kK];
fragment L : [lL];
fragment M : [mM];
fragment N : [nN];
fragment O : [oO];
fragment P : [pP];
fragment Q : [qQ];
fragment R : [rR];
fragment S : [sS];
fragment T : [tT];
fragment U : [uU];
fragment V : [vV];
fragment W : [wW];
fragment X : [xX];
fragment Y : [yY];
fragment Z : [zZ];

Number: Sign? (UnsignedInteger | UnsignedReal);
fragment Sign: Plus | Minus;
UnsignedInteger: DigitSequence 
               | Dollar HexSequence
               | Ampersand OctalSequence
               | Percent BinSequence; 
UnsignedReal: DigitSequence (Dot DigitSequence)? ScaleFactor?;
fragment ScaleFactor: E Sign? DigitSequence;  

fragment Plus: '+';
fragment Minus: '-';
fragment Dollar: '$';
fragment Ampersand: '&';
fragment Percent: '%';
fragment Dot: '.';

DigitSequence: Digit+;
fragment BinSequence: Bin+;
fragment HexSequence: Hex+;
fragment OctalSequence: Octal+;
fragment Digit: [0-9];
fragment Hex: [0-9a-fA-F];
fragment Octal: [0-7];
fragment Bin: [0-1];

CharacterString: (QuotedString | ControlString)+;
fragment QuotedString: Quote (~['\n] | Quote Quote)* Quote;
fragment Quote: '\'';
fragment ControlString: Hash UnsignedReal;
fragment Hash: '#';

Comment: (SingleComment | MultilineComment) -> channel(Comments);
fragment SingleComment: DoubleSlash ~[\n\r]*;
fragment DoubleSlash: '//';
fragment MultilineComment: LCurlyBrace NestedComment RCurlyBrace
                         | LBraceStar NestedComment RBraceStar;
fragment NestedComment: (MultilineComment | .)*?;
fragment LCurlyBrace: '{';
fragment RCurlyBrace: '}';
fragment LBraceStar: '(*';
fragment RBraceStar: '*)';

Semicolon: ';';
Colon: ':';
LBrace: '(';
RBrace: ')';
LBracket: '[';
RBracket: ']';
Comma: ',';
Dots: '..';
At: '@';

Assign: ':=';
PlusAssign: '+=';
MinusAssign: '-=';
MultAssign: '*=';
DivAssign: '/=';

RelationalOperator: Lt | Le | Gt | Ge | Eq | Neq | In | Is;
fragment Lt: '<';
fragment Le: '<=';
fragment Gt: '>';
fragment Ge: '>=';
fragment Eq: '=';
fragment Neq: '<>';
In: I N;
Is: I S;

AddingOperator: Plus | Minus | Or | Xor;
Or: O R;
Xor: X O R;

MultiplicationOperator: Mult | Divide | Div | Mod | And | Shl | Shr | As;
fragment Mult: '*';
fragment Divide: '/';
Div: D I V;
Mod: M O D;
And: A N D;
Shl: S H L;
Shr: S H R;
As: A S;

Nil: N I L;
Begin: B E G I N;
End: E N D;
Goto: G O T O;
Not: N O T;
Signum: S I G N;
Case: C A S E;
Of: O F;
Else: E L S E;
Otherwise: O T H E R W I S E;
If: I F;
Then: T H E N;
For: F O R;
To: T O;
Downto: D O W N T O;
Do: D O;
Repeat: R E P E A T;
Until: U N T I L;
While: W H I L E;
With: W I T H;

Identifier: (Letter | Underscore) (Letter | Digit | Underscore)*;
fragment Letter: [a-zA-Z];
fragment Underscore: '_';

Symbol: Letter | Digit | Hex;
Whitespace: [ \n\t\r]+ -> channel(Whitespaces);
Error: .+?;