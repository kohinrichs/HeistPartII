using System;

namespace HeistPartII
{
    public class Bank
    {
        public int CashOnHand { get; set; }

        public int AlarmScore { get; set; }

        public int VaultScore { get; set; }

        public int SecurityGuardScore { get; set; }

        private bool _isSecure;

        public bool IsSecure
        {
            get
            {
                return _isSecure;
            }
            set
            {
                if (AlarmScore <= 0 && VaultScore <= 0 && SecurityGuardScore <= 0)
                {
                    _isSecure = false;
                }
                else
                {
                    _isSecure = true;
                }
            }
        }
    }
}