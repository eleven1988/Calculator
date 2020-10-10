grammar Calculator;
 
options {
    language=CSharp;
}
 
@lexer::namespace{Calculator}
@parser::namespace{Calculator}

/*
 * Parser Rules
 */
 
public addSubExpr
    : multDivExpr (( '+' | '-' ) multDivExpr)*;
 
multDivExpr
  : INT (( '*' | '/' ) INT)*;
 
/*
 * Lexer Rules
 */
 
INT : '0'..'9'+;
WS :  (' '|'\t'|'\r'|'\n')+ {Skip();} ;