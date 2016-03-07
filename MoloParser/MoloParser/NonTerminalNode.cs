using System.Collections;
using GoldParser;

namespace MoloParser
{
    /// <summary>
    /// Derive this class for NonTerminal AST Nodes
    /// </summary>
    public class NonTerminalNode : ASTNode
    {
        private int m_reductionNumber;
        private Rule m_rule;
        private ArrayList m_array = new ArrayList();

        public NonTerminalNode(Parser theParser)
        {
            m_rule = theParser.ReductionRule;
        }
        
        public override bool IsTerminal
        {
            get
            {
                return false;
            }
        }

        public int ReductionNumber 
        {
            get { return m_reductionNumber; }
            set { m_reductionNumber = value; }
        }

        public int Count 
        {
            get { return m_array.Count; }
        }

        public ASTNode this[int index]
        {
            get { return m_array[index] as ASTNode; }
        }

        public void AppendChildNode(ASTNode node)
        {
            if (node == null)
            {
                return ; 
            }
            m_array.Add(node);
        }

        public Rule Rule
        {
            get { return m_rule; }
        }

    }
}