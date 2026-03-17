using System;
using System.Collections.Generic;
using System.Text;

namespace Fonyn.Compiler.Lexing;

/// <summary>
/// プログラムの構文要素の種類を表す列挙型。
/// </summary>
public enum SyntaxKind
{
    None,
    EndOfFile,     //EOF
    Identifier,    //識別子
    Number,        //数値リテラル
    String,        //文字列リテラル
    Plus,          // +
    Minus,         // -
    Asterisk,      // *
    Slash,         // /
    OpenParen,     // (
    CloseParen,    // )
    OpenBrace,     // {
    CloseBrace,    // }
    OpenBracket,   // [
    CloseBracket,  // ]
    Comma,         // ,
    Semicolon,     // ;
    Equals,        // =
    IfKeyword,     // if
    ElseKeyword,   // else
    WhileKeyword,  // while
    ForKeyword,    // for
    ReturnKeyword, // return
    Whitespace,    //空白文字

    Invalid,       //無効なトークン
}