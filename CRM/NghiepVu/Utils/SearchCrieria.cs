using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using Lotus.Libraries;

namespace VSDiDoc.NghiepVu
{
    public class SearchCrieria
    {
        public string FieldCaption { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public FieldType type { get; set; }
        public Control Controls { get; set; }

        public static string BuildCondition(Condition_Operator operators)
        {
            string conditionFormat;
            switch (operators)
            {                 
                case Condition_Operator.EQUAL:
                    conditionFormat = "{0} = {1}";
                    break;
                case Condition_Operator.LARGER:
                    conditionFormat = "{0} > {1}";
                    break;
                case Condition_Operator.LARGEROREQUAL:
                    conditionFormat = "{0} >= {1}";
                    break;
                case Condition_Operator.LIKE:
                    conditionFormat = "{0} LIKE '%{1}%'";
                    break;
                case Condition_Operator.NOTLIKE:
                    conditionFormat = "{0} NOT LIKE '%{1}%'";
                    break;
                case Condition_Operator.SMALLER:
                    conditionFormat = "{0} < {1}";
                    break;
                case Condition_Operator.SMALLEROREQUAL:
                    conditionFormat = "{0} <= {1}";
                    break;
                default:
                    conditionFormat = "{0} = {1}";
                    break;
            }
            return conditionFormat;
        }
    }
    public class SearchCondition
    {
        public string Caption { get; set; }
        public string Value { get; set; }
        public FieldType Type { get; set; }

        public static List<SearchCondition> GetAllCondition()
        {
            List<SearchCondition> list = new List<SearchCondition>();
            list.Add(new SearchCondition() { Caption = "LIKE", Value = "{0} LIKE '%{1}%'", Type = FieldType.STRING });
            //list.Add(new SearchCondition() { Caption = "NOT LIKE", Value = "{0} NOT LIKE '%{1}%'", Type = FieldType.STRING });
            list.Add(new SearchCondition() { Caption = "=", Value = "{0} = '{1}'", Type = FieldType.STRING });
            list.Add(new SearchCondition() { Caption = "=", Value = "{0} = '{1}'", Type = FieldType.DEFAULT });
            list.Add(new SearchCondition() { Caption = "=", Value = "{0} = '{1}'", Type = FieldType.DATE });
            list.Add(new SearchCondition() { Caption = "<", Value = "{0} < '{1}'", Type = FieldType.DATE });
            list.Add(new SearchCondition() { Caption = "<=", Value = "{0} <= '{1}'", Type = FieldType.DATE });
            list.Add(new SearchCondition() { Caption = ">", Value = "{0} > '{1}'", Type = FieldType.DATE });
            list.Add(new SearchCondition() { Caption = ">=", Value = "{0} >= '{1}'", Type = FieldType.DATE });
            list.Add(new SearchCondition() { Caption = "=", Value = "{0} = {1}", Type = FieldType.NUMBER });
            list.Add(new SearchCondition() { Caption = "<", Value = "{0} < {1}", Type = FieldType.NUMBER });
            list.Add(new SearchCondition() { Caption = "<=", Value = "{0} <= {1}", Type = FieldType.NUMBER });
            list.Add(new SearchCondition() { Caption = ">", Value = "{0} > {1}", Type = FieldType.NUMBER });
            list.Add(new SearchCondition() { Caption = ">=", Value = "{0} >= {1}", Type = FieldType.NUMBER });
            return list;
        }
        public static List<SearchCondition> GetConditionBy(List<SearchCondition> lst,FieldType type)
        {
            List<SearchCondition> list = lst.Where(t=>t.Type == type).ToList();
            return list;           
        }
    }
}
