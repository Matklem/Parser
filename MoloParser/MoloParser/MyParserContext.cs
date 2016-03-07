using System.IO;
using GoldParser;
using MoloParser.Constants;
using MoloParser.Exeptions;

namespace MoloParser
{
    public class MyParserContext
    {

        // instance fields
        private Parser m_parser;
        
        private TextReader m_inputReader;
        

        
        // constructor
        public MyParserContext(Parser prser)
        {
            m_parser = prser;   
        }
       

        private string GetTokenText()
        {
            // delete any of these that are non-terminals.

            switch (m_parser.TokenSymbol.Index)
            {

                case (int)SymbolConstants.SYMBOL_EOF :
                    //(EOF)
                    //Token Kind: 3
                    
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_ERROR :
                    //(Error)
                    //Token Kind: 7
                    
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_COMMENT :
                    //Comment
                    //Token Kind: 2
                    
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_NEWLINE :
                    //NewLine
                    //Token Kind: 2
                    
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_WHITESPACE :
                    //Whitespace
                    //Token Kind: 2
                    
                    
                    return null;

                #region Comments
                case (int)SymbolConstants.SYMBOL_TIMESDIV :
                    //'*/'
                    //Token Kind: 5
                    
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_DIVTIMES :
                    //'/*'
                    //Token Kind: 4
                    
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_DIVDIV :
                    //'//'
                    //Token Kind: 6
                    
                    
                    return null;

                #endregion

                case (int)SymbolConstants.SYMBOL_MINUS :
                    //'-'
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_EXCLAM :
                    //'!'
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_EXCLAMEQ :
                    //'!='
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_LPAREN :
                    //'('
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_RPAREN :
                    //')'
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_TIMES :
                    //'*'
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_COMMA :
                    //','
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_DIV :
                    //'/'
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_SEMI :
                    //';'
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_LBRACE :
                    //'{'
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_RBRACE :
                    //'}'
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_PLUS :
                    //'+'
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_LT :
                    //'<'
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_LTEQ :
                    //'<='
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_EQ :
                    //'='
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_EQEQ :
                    //'=='
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_GT :
                    //'>'
                    //Token Kind: 1                    
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_GTEQ :
                    //'>='
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_AND :
                    //and
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_BOOL :
                    //bool
                    //Token Kind: 1                    
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_BOOLEANLITERAL :
                    //BooleanLiteral
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_CONST :
                    //const
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_ELSE :
                    //else
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_FLOATLITERAL :
                    //FloatLiteral
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_ID :
                    //Id
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_IF :
                    //if
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_MOD :
                    //mod
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_NUM :
                    //num
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_OR :
                    //or
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_PROGRAM :
                    //program
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_REPEAT :
                    //repeat
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_STRING :
                    //string
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_STRINGLITERAL :
                    //StringLiteral
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_VOID :
                    //void
                    //Token Kind: 1
                    return m_parser.TokenString;

                case (int)SymbolConstants.SYMBOL_BODY :
                    //<body>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_BODYPART :
                    //<bodypart>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_BOOL_OPR :
                    //<bool_opr>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_CALC_OPR :
                    //<calc_opr>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_CMPR_OPR :
                    //<cmpr_opr>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_CONST2 :
                    //<const>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_CONST_PART :
                    //<const_part>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_CONSTS :
                    //<consts>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_CTRL_STMT :
                    //<ctrl_stmt>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_EXPR :
                    //<expr>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_EXPR_LIST :
                    //<expr_list>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_FIRST_TYPEID :
                    //<first_typeid>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_FUNC_CALL :
                    //<func_call>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_FUNC_DECL :
                    //<func_decl>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_FUNC_DECLS :
                    //<Func_decls>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_IF_EXP :
                    //<if_exp>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_OPERATOR :
                    //<operator>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_OPT_EXPRS :
                    //<opt_exprs>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_OPT_PARA :
                    //<opt_para>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_PROGRAM2 :
                    //<Program>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_TYPE :
                    //<type>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_TYPEID :
                    //<typeid>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_VALUE :
                    //<value>
                    //Token Kind: 0
                    
                    return null;

                case (int)SymbolConstants.SYMBOL_VAR_DECL :
                    //<var_decl>
                    //Token Kind: 0
                    
                    return null;

                default:
                    throw new SymbolException("You don't want the text of a non-terminal symbol");

            }
            
        }

        public ASTNode CreateASTNode()
        {
            switch (m_parser.ReductionRule.Index)
            {
                case (int)RuleConstants.RULE_PROGRAM_PROGRAM_LBRACE_RBRACE :
                    //<Program> ::= <consts> program '{' <body> '}' <Func_decls>
                    //todo: Perhaps create an object in the AST.
                    return new NonTerminalNode(m_parser);
                

                case (int)RuleConstants.RULE_CONSTS :
                    //<consts> ::= <const> <consts>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_CONSTS2 :
                    //<consts> ::= 
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_CONST_CONST_ID_SEMI :
                    //<const> ::= const Id <const_part> ';'
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_CONST_PART_FLOATLITERAL :
                    //<const_part> ::= FloatLiteral
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_CONST_PART_STRINGLITERAL :
                    //<const_part> ::= StringLiteral
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_CONST_PART_BOOLEANLITERAL :
                    //<const_part> ::= BooleanLiteral
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_FUNC_DECLS :
                    //<Func_decls> ::= <func_decl> <Func_decls>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_FUNC_DECLS2 :
                    //<Func_decls> ::= 
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_FUNC_DECL_LPAREN_RPAREN_LBRACE_RBRACE :
                    //<func_decl> ::= <typeid> '(' <first_typeid> ')' '{' <body> '}'
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_FIRST_TYPEID :
                    //<first_typeid> ::= <typeid> <opt_para>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_FIRST_TYPEID2 :
                    //<first_typeid> ::= 
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_OPT_PARA_COMMA :
                    //<opt_para> ::= ',' <typeid> <opt_para>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_OPT_PARA :
                    //<opt_para> ::= 
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_TYPEID_ID :
                    //<typeid> ::= <type> Id
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_VAR_DECL_ID_EQ_SEMI :
                    //<var_decl> ::= Id '=' <expr> ';'
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_OPERATOR :
                    //<operator> ::= <cmpr_opr>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_OPERATOR2 :
                    //<operator> ::= <bool_opr>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_OPERATOR3 :
                    //<operator> ::= <calc_opr>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_CMPR_OPR_LT :
                    //<cmpr_opr> ::= '<'
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_CMPR_OPR_GT :
                    //<cmpr_opr> ::= '>'
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_CMPR_OPR_LTEQ :
                    //<cmpr_opr> ::= '<='
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_CMPR_OPR_GTEQ :
                    //<cmpr_opr> ::= '>='
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_BOOL_OPR_AND :
                    //<bool_opr> ::= and
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_BOOL_OPR_OR :
                    //<bool_opr> ::= or
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_BOOL_OPR_EQEQ :
                    //<bool_opr> ::= '=='
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_BOOL_OPR_EXCLAMEQ :
                    //<bool_opr> ::= '!='
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_CALC_OPR_TIMES :
                    //<calc_opr> ::= '*'
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_CALC_OPR_DIV :
                    //<calc_opr> ::= '/'
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_CALC_OPR_MOD :
                    //<calc_opr> ::= mod
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_CALC_OPR_PLUS :
                    //<calc_opr> ::= '+'
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_CALC_OPR_MINUS :
                    //<calc_opr> ::= '-'
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_TYPE_VOID :
                    //<type> ::= void
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_TYPE_STRING :
                    //<type> ::= string
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_TYPE_NUM :
                    //<type> ::= num
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_TYPE_BOOL :
                    //<type> ::= bool
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_VALUE_FLOATLITERAL :
                    //<value> ::= FloatLiteral
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_VALUE_STRINGLITERAL :
                    //<value> ::= StringLiteral
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_VALUE_BOOLEANLITERAL :
                    //<value> ::= BooleanLiteral
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_VALUE :
                    //<value> ::= <func_call>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_VALUE_ID :
                    //<value> ::= Id
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_BODY :
                    //<body> ::= <bodypart> <body>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_BODY2 :
                    //<body> ::= 
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_BODYPART :
                    //<bodypart> ::= <var_decl>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_BODYPART2 :
                    //<bodypart> ::= <func_call>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_BODYPART3 :
                    //<bodypart> ::= <ctrl_stmt>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_EXPR :
                    //<expr> ::= <value> <operator> <expr>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_EXPR2 :
                    //<expr> ::= <value>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_EXPR_LPAREN_RPAREN :
                    //<expr> ::= '(' <expr> ')'
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_EXPR_MINUS :
                    //<expr> ::= '-' <value>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_EXPR_LPAREN_RPAREN2 :
                    //<expr> ::= '(' <expr> ')' <operator> <expr>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_EXPR_EXCLAM :
                    //<expr> ::= '!' <expr>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_OPT_EXPRS_COMMA :
                    //<opt_exprs> ::= ',' <expr>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_OPT_EXPRS :
                    //<opt_exprs> ::= 
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_CTRL_STMT_IF_LBRACE_RBRACE :
                    //<ctrl_stmt> ::= if <expr> '{' <body> '}' <if_exp>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_CTRL_STMT_REPEAT_LBRACE_RBRACE :
                    //<ctrl_stmt> ::= repeat <expr> '{' <body> '}'
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_IF_EXP_ELSE_IF_LBRACE_RBRACE :
                    //<if_exp> ::= else if <expr> '{' <body> '}' <if_exp>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_IF_EXP_ELSE_LBRACE_RBRACE :
                    //<if_exp> ::= else '{' <body> '}'
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_IF_EXP :
                    //<if_exp> ::= 
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_FUNC_CALL_ID_LPAREN_RPAREN_SEMI :
                    //<func_call> ::= Id '(' <expr_list> <opt_exprs> ')' ';'
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_EXPR_LIST :
                    //<expr_list> ::= <expr> <opt_exprs>
                    //todo: Perhaps create an object in the AST.
                    return null;

                case (int)RuleConstants.RULE_EXPR_LIST2 :
                    //<expr_list> ::= 
                    //todo: Perhaps create an object in the AST.
                    return null;

                default:
                    throw new RuleException("Unknown rule: Does your CGT Match your Code Revision?");
            }
            
        }

    }
}