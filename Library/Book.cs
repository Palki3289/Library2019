using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Book
    {
        #region Properties
        /// <summary>
        /// Defines title of book
        /// </summary>
        public string Title { get; set; }
       
        /// <summary>
        /// defines the pagecount of book
        /// </summary>
        public int PageCount { get; set; }
       
        /// <summary>
        /// whether book is checkedout or not
        /// </summary>
        public bool Checkout { get; set; }
        #endregion

        #region Methods

        #endregion
    }
}
