using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusControles
{
    public class PurpleLabel : Label
    {
        public PurpleLabel()
        {
            this.ForeColor = Color.FromArgb(149, 88, 225);
            this.Font = new Font("Consolas", 14F, FontStyle.Bold);
        }
    }
}
