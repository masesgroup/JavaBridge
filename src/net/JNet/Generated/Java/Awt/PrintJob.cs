/*
*  Copyright 2023 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region PrintJob
    public partial class PrintJob
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/PrintJob.html#getGraphics()"/> 
        /// </summary>
        public Java.Awt.Graphics Graphics
        {
            get { return IExecute<Java.Awt.Graphics>("getGraphics"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/PrintJob.html#getPageDimension()"/> 
        /// </summary>
        public Java.Awt.Dimension PageDimension
        {
            get { return IExecute<Java.Awt.Dimension>("getPageDimension"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/PrintJob.html#getPageResolution()"/> 
        /// </summary>
        public int PageResolution
        {
            get { return IExecute<int>("getPageResolution"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/PrintJob.html#lastPageFirst()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool LastPageFirst()
        {
            return IExecute<bool>("lastPageFirst");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/PrintJob.html#end()"/>
        /// </summary>
        public void End()
        {
            IExecute("end");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}