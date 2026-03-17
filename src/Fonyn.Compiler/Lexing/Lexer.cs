using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using static Fonyn.Compiler.Lexing.SyntaxKind;

namespace Fonyn.Compiler.Lexing
{
    public class Lexer
    {
        private static readonly Dictionary<string, SyntaxKind> keywords = new()
        {
            { "if", IfKeyword },
            { "else", ElseKeyword },
            { "while", WhileKeyword },
            { "for", ForKeyword },
            { "return", ReturnKeyword },
        };

        private string sourceCode;
        private int position;

        public Lexer(string sourceCode)
        {
            this.sourceCode = sourceCode;
            position = 0;
        }

        /// <summary>
        /// ソースコードをトークン化する
        /// </summary>
        /// <returns>トークン列</returns>
        public (List<SyntaxToken> Tokens, List<int> LineStarts) Tokenize()
        {
            //位置を初期化
            position = 0;
            //トークン格納用
            var tokens = new List<SyntaxToken>();
            //行情報格納用
            var lineStarts = new List<int>() { 0 };

            //1文字づつ見てく
            while (position < sourceCode.Length)
            {
                //現在地
                char current = sourceCode[position];

                /*空白文字を検出*/
                if (char.IsWhiteSpace(current))
                {
                    int start = position;
                    //空白文字が終わるまで走査
                    while (position < sourceCode.Length && char.IsWhiteSpace(sourceCode[position])) 
                    {
                        //改行を検出したら改行位置を記録
                        if (sourceCode[position] == '\r')
                        {
                            if (position + 1 < sourceCode.Length && sourceCode[position + 1] == '\n')
                            {
                                position += 2;
                                lineStarts.Add(position);
                                continue;
                            }
                        }
                        else if (sourceCode[position] == '\n')
                        {
                            position++;
                            lineStarts.Add(position);
                            continue;
                        }

                        position++;
                    }
                    current = sourceCode[position];

                    //空白文字を抽出して記録する
                    string wLexeme = sourceCode.Substring(start, position - start);
                    tokens.Add(new WhitespaceToken(wLexeme, new Span(start, position - start)));
                    continue;
                }

                position++;
            }

            return (tokens, lineStarts);
        }
    }
}
