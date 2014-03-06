using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ms.Entity
{
    public class User
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// User identity
        /// </summary>
        public string UserIdentity { get; set; }
        /// <summary>
        /// Created
        /// </summary>
        public DateTime Created { get; set; }
        /// <summary>
        /// Modified
        /// </summary>
        public DateTime Modified { get; set; }
        /// <summary>
        /// Deleted
        /// </summary>
        public bool Deleted { get; set; }
    }
}
