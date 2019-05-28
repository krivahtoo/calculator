using System;
using System.Configuration;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Sources
{
    public class CalculatorSetings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("white")]
        public Color BackgroundColour
        {
            get
            {
                return ((Color)this["BackgroundColour"]);
            }
            set
            {
                this["BagroundColour"] = (Color)value;
            }
        }
        public Color ButtonBackColour
        {
            get
            {
                return ((Color)this["ButtonBackColour"]);
            }
            set
            {
                this["ButtonBackColour"] = (Color)value;
            }
        }
        public Color ButtonTextColour
        {
            get
            {
                return ((Color)this["ButtonTextColour"]);
            }
            set
            {
                this["ButtonTextColour"] = (Color)value;
            }
        }
        public Font ButtonFont
        {
            get
            {
                return ((Font)this["ButtonFont"]);
            }
            set
            {
                this["ButtonFont"] = (Font)value;
            }
        }
        public Color OperatorTextColour
        {
            get
            {
                return ((Color)this["OperatorTextColour"]);
            }
            set
            {
                this["OperatorTextColour"] = (Color)value;
            }
        }
        public Color OperatorBackColour
        {
            get
            {
                return ((Color)this["OperatorBackColour"]);
            }
            set
            {
                this["OperatorBackColour"] = (Color)value;
            }
        }
        public Font AnswerFont
        {
            get
            {
                return ((Font)this["AnswerFont"]);
            }
            set
            {
                this["AnswerFont"] = (Font)value;
            }
        }
        public Color AnswerTextColour
        {
            get
            {
                return ((Color)this["AnswerTextColour"]);
            }
            set
            {
                this["AnswerTextColour"] = (Color)value;
            }
        }
        public Color AnswerBackColour
        {
            get
            {
                return ((Color)this["AnswerBackColour"]);
            }
            set
            {
                this["AnswerBackColour"] = (Color)value;
            }
        }
    }
}
