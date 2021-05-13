parser grammar PascalParser;

options { tokenVocab = PascalLexer; }

program: compoundStatement EOF;

// Statements
compoundStatement: Begin statement (Semicolon statement)* Semicolon? End;
statement: (label Colon)? (simpleStatement | structuredStatement);
body: (statement Semicolon? | compoundStatement);

simpleStatement: assigmnentStatement | procedureStatement | gotoStatement;
assigmnentStatement: Identifier assignment expression;
assignment: Assign | PlusAssign | MinusAssign | MultAssign | DivAssign;
procedureStatement: Identifier actualParameterList?;
gotoStatement: Goto label;
label: Number | Identifier;

structuredStatement: compoundStatement | conditionalStatement | repetitiveStatement | withStatement;
conditionalStatement: caseStatement | ifStatement;
repetitiveStatement: forStatement | repeatStatement | whileStatement;

caseStatement: Case expression Of case (Semicolon case)* elsePart? Semicolon? End;
case: caseRange (Comma caseRange)* Colon body;
caseRange: constant (Dots constant)?;
constant: Number | CharacterString;
elsePart: (Else | Otherwise) body;

ifStatement: If expression Then body (Else body)?;

forStatement: For Identifier Assign expression (To | Downto) expression Do body
            | For Identifier In expression Do body;
            
repeatStatement: Repeat statement (Semicolon statement)* Until expression;
whileStatement: While expression Do body;
withStatement: With Identifier (Comma Identifier)* Do body;

// Expressions
expression: simpleExpression (RelationalOperator simpleExpression)?;
simpleExpression: term (AddingOperator term)*;
term: factor (MultiplicationOperator factor)*;
factor: LBrace expression RBrace
      | Identifier
      | functionCall
      | unsignedConstant
      | Not factor
      | Signum factor
      | setConstructor
      | valueTypecast
      | addressFactor;
      
functionCall: Identifier actualParameterList?;
actualParameterList: LBrace (expression (Comma expression)*)? RBrace;

unsignedConstant: Number | CharacterString | Nil;

setConstructor: LBracket setGroup (Comma setGroup)* RBracket;
setGroup: expression (Dots expression)?;

valueTypecast: Identifier LBrace expression RBrace;
addressFactor: At Identifier;