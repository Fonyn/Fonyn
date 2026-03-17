using System;
using System.Collections.Generic;
using System.Text;
using static Fonyn.Compiler.Lexing.SyntaxKind;

namespace Fonyn.Compiler.Lexing
{
    internal class Lexer
    {
        private static readonly Dictionary<string, SyntaxKind> keywords = new()
        {
            { "if", IfKeyword },
            { "else", ElseKeyword },
            { "while", WhileKeyword },
            { "for", ForKeyword },
            { "return", ReturnKeyword },
        };
    }
}
