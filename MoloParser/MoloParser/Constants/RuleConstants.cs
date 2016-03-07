namespace MoloParser.Constants
{
    enum RuleConstants : int
    {
        RULE_PROGRAM_PROGRAM_LBRACE_RBRACE         =  0, // <Program> ::= <consts> program '{' <body> '}' <Func_decls>
        RULE_CONSTS                                =  1, // <consts> ::= <const> <consts>
        RULE_CONSTS2                               =  2, // <consts> ::= 
        RULE_CONST_CONST_ID_SEMI                   =  3, // <const> ::= const Id <const_part> ';'
        RULE_CONST_PART_FLOATLITERAL               =  4, // <const_part> ::= FloatLiteral
        RULE_CONST_PART_STRINGLITERAL              =  5, // <const_part> ::= StringLiteral
        RULE_CONST_PART_BOOLEANLITERAL             =  6, // <const_part> ::= BooleanLiteral
        RULE_FUNC_DECLS                            =  7, // <Func_decls> ::= <func_decl> <Func_decls>
        RULE_FUNC_DECLS2                           =  8, // <Func_decls> ::= 
        RULE_FUNC_DECL_LPAREN_RPAREN_LBRACE_RBRACE =  9, // <func_decl> ::= <typeid> '(' <first_typeid> ')' '{' <body> '}'
        RULE_FIRST_TYPEID                          = 10, // <first_typeid> ::= <typeid> <opt_para>
        RULE_FIRST_TYPEID2                         = 11, // <first_typeid> ::= 
        RULE_OPT_PARA_COMMA                        = 12, // <opt_para> ::= ',' <typeid> <opt_para>
        RULE_OPT_PARA                              = 13, // <opt_para> ::= 
        RULE_TYPEID_ID                             = 14, // <typeid> ::= <type> Id
        RULE_VAR_DECL_ID_EQ_SEMI                   = 15, // <var_decl> ::= Id '=' <expr> ';'
        RULE_OPERATOR                              = 16, // <operator> ::= <cmpr_opr>
        RULE_OPERATOR2                             = 17, // <operator> ::= <bool_opr>
        RULE_OPERATOR3                             = 18, // <operator> ::= <calc_opr>
        RULE_CMPR_OPR_LT                           = 19, // <cmpr_opr> ::= '<'
        RULE_CMPR_OPR_GT                           = 20, // <cmpr_opr> ::= '>'
        RULE_CMPR_OPR_LTEQ                         = 21, // <cmpr_opr> ::= '<='
        RULE_CMPR_OPR_GTEQ                         = 22, // <cmpr_opr> ::= '>='
        RULE_BOOL_OPR_AND                          = 23, // <bool_opr> ::= and
        RULE_BOOL_OPR_OR                           = 24, // <bool_opr> ::= or
        RULE_BOOL_OPR_EQEQ                         = 25, // <bool_opr> ::= '=='
        RULE_BOOL_OPR_EXCLAMEQ                     = 26, // <bool_opr> ::= '!='
        RULE_CALC_OPR_TIMES                        = 27, // <calc_opr> ::= '*'
        RULE_CALC_OPR_DIV                          = 28, // <calc_opr> ::= '/'
        RULE_CALC_OPR_MOD                          = 29, // <calc_opr> ::= mod
        RULE_CALC_OPR_PLUS                         = 30, // <calc_opr> ::= '+'
        RULE_CALC_OPR_MINUS                        = 31, // <calc_opr> ::= '-'
        RULE_TYPE_VOID                             = 32, // <type> ::= void
        RULE_TYPE_STRING                           = 33, // <type> ::= string
        RULE_TYPE_NUM                              = 34, // <type> ::= num
        RULE_TYPE_BOOL                             = 35, // <type> ::= bool
        RULE_VALUE_FLOATLITERAL                    = 36, // <value> ::= FloatLiteral
        RULE_VALUE_STRINGLITERAL                   = 37, // <value> ::= StringLiteral
        RULE_VALUE_BOOLEANLITERAL                  = 38, // <value> ::= BooleanLiteral
        RULE_VALUE                                 = 39, // <value> ::= <func_call>
        RULE_VALUE_ID                              = 40, // <value> ::= Id
        RULE_BODY                                  = 41, // <body> ::= <bodypart> <body>
        RULE_BODY2                                 = 42, // <body> ::= 
        RULE_BODYPART                              = 43, // <bodypart> ::= <var_decl>
        RULE_BODYPART2                             = 44, // <bodypart> ::= <func_call>
        RULE_BODYPART3                             = 45, // <bodypart> ::= <ctrl_stmt>
        RULE_EXPR                                  = 46, // <expr> ::= <value> <operator> <expr>
        RULE_EXPR2                                 = 47, // <expr> ::= <value>
        RULE_EXPR_LPAREN_RPAREN                    = 48, // <expr> ::= '(' <expr> ')'
        RULE_EXPR_MINUS                            = 49, // <expr> ::= '-' <value>
        RULE_EXPR_LPAREN_RPAREN2                   = 50, // <expr> ::= '(' <expr> ')' <operator> <expr>
        RULE_EXPR_EXCLAM                           = 51, // <expr> ::= '!' <expr>
        RULE_OPT_EXPRS_COMMA                       = 52, // <opt_exprs> ::= ',' <expr>
        RULE_OPT_EXPRS                             = 53, // <opt_exprs> ::= 
        RULE_CTRL_STMT_IF_LBRACE_RBRACE            = 54, // <ctrl_stmt> ::= if <expr> '{' <body> '}' <if_exp>
        RULE_CTRL_STMT_REPEAT_LBRACE_RBRACE        = 55, // <ctrl_stmt> ::= repeat <expr> '{' <body> '}'
        RULE_IF_EXP_ELSE_IF_LBRACE_RBRACE          = 56, // <if_exp> ::= else if <expr> '{' <body> '}' <if_exp>
        RULE_IF_EXP_ELSE_LBRACE_RBRACE             = 57, // <if_exp> ::= else '{' <body> '}'
        RULE_IF_EXP                                = 58, // <if_exp> ::= 
        RULE_FUNC_CALL_ID_LPAREN_RPAREN_SEMI       = 59, // <func_call> ::= Id '(' <expr_list> <opt_exprs> ')' ';'
        RULE_EXPR_LIST                             = 60, // <expr_list> ::= <expr> <opt_exprs>
        RULE_EXPR_LIST2                            = 61  // <expr_list> ::= 
    };
}