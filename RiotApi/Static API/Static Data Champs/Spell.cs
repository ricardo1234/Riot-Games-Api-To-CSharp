using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi.Static_Data_Champs
{
    public class Spell
    {
        //Simple Data
        public string name { get; set; }
        public string description { get; set; }
        public string stringdescription { get; set; }
        public string sanitizedDescription { get; set; }
        public string tooltip { get; set; }
        public string sanitizedTooltip { get; set; }
        public string resource { get; set; }
        public int maxrank { get; set; }
        public string costBurn { get; set; }
        public string cooldownBurn { get; set; }
        public string rangeBurn { get; set; }
        public string key { get; set; }
        //Complex Data
        public /*CostType*/ string costType { get; set; }
        public List<int> cost { get; set; }
        public List<List<int>> effect { get; set; }
        public List<string> effectBurn { get; set; }
        public List<int> range { get; set; }
        public List<int> cooldown { get; set; }
        public LevelTip levelTip { get; set; }
        public Image Image { get; set; }
        public List<Var> vars { get; set; }

        /// <summary>
        /// FormatSanitizedTooltip
        /// No Parameters
        /// </summary>
        /// <returns>SanitizedTooltip whith the correct dynamic data</returns>
        public string FormatSanitizedTooltip()
        {
            string dados = sanitizedTooltip;
            if (vars == null)
                goto Effects;

            foreach (var item in vars)
            {
                dados = dados.Replace($"{{{{ {item.key} }}}}", (item.coeff[0]*100).ToString() + "%");
            }
            Effects:
            {
                int increment = 0;
                foreach (var item in effectBurn)
                {
                   dados = dados.Replace($"{{{{ e{increment} }}}}", item);

                    increment++;
                }
            }
            return dados;

        }
    }
}
