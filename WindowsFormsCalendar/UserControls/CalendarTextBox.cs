/*
	Copyright 2012 Justin LeCheminant

	This file is part of WindowsFormsCalendar.

    indowsFormsCalendar is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    indowsFormsCalendar is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with indowsFormsCalendar.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsCalendar
{
    public class CalendarTextBox
        : TextBox
    {
        #region Fields
        private Calendar _calendar;
        #endregion

        #region Ctor

        /// <summary>
        /// Creates a new <see cref="CalendarTextBox"/> for the specified <see cref="Calendar"/>
        /// </summary>
        /// <param name="calendar">Calendar where this control lives</param>
        public CalendarTextBox(Calendar calendar)
        {
            _calendar = calendar;
        }

        #endregion

        #region Props

        /// <summary>
        /// Gets the calendar where this control lives
        /// </summary>
        public Calendar Calendar
        {
            get { return _calendar; }
        }


        #endregion

        #region Methods

        

        #endregion
    }
}
