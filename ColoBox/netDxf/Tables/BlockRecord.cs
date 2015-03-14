﻿#region netDxf, Copyright(C) 2013 Daniel Carvajal, Licensed under LGPL.

//                        netDxf library
// Copyright (C) 2013 Daniel Carvajal (haplokuon@gmail.com)
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE. 

#endregion

namespace netDxf.Tables
{
    /// <summary>
    /// Represent the record of a block in the tables section.
    /// </summary>
    internal class BlockRecord :
        TableObject
    {

        #region private fields

        private DrawingUnits units;

        #endregion

        #region constructors

        /// <summary>
        /// Initializes a new instance of the <c>BlockRecord</c> class.
        /// </summary>
        /// <param name="name">Block definition name.</param>
        public BlockRecord(string name)
            : base(name, DxfObjectCode.BlockRecord)
        {
            this.units = DrawingUnits.Unitless;
        }

        #endregion

        #region public properties

        /// <summary>
        /// Block insertion units.
        /// </summary>
        public DrawingUnits Units
        {
            get { return units; }
            set { units = value; }
        }

        #endregion

    }
}