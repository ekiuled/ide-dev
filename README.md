# ide-dev
Домашние задания по курсу "Разработка IDE".

## Домашнее задание 2
Лексер языка Pascal ([спецификация](https://www.freepascal.org/docs-html/ref/refch1.html#x8-70001)).

Поддерживаются:
* Symbols 
* Comments 
* Identifiers 
* Numbers 
* Character Strings

### Использование
`ParserLexer.Lexer.Lex` на вход получает строку и выдаёт последовательность токенов.