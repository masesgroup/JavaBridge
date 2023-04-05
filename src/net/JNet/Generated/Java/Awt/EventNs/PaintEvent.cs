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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region PaintEvent
    public partial class PaintEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/PaintEvent.html#%3Cinit%3E(java.awt.Component,int,java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Rectangle"/></param>
        public PaintEvent(Java.Awt.Component arg0, int arg1, Java.Awt.Rectangle arg2)
            : base(arg0, arg1, arg2)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/PaintEvent.html#PAINT"/>
        /// </summary>
        public static int PAINT => Clazz.GetField<int>("PAINT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/PaintEvent.html#PAINT_FIRST"/>
        /// </summary>
        public static int PAINT_FIRST => Clazz.GetField<int>("PAINT_FIRST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/PaintEvent.html#PAINT_LAST"/>
        /// </summary>
        public static int PAINT_LAST => Clazz.GetField<int>("PAINT_LAST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/PaintEvent.html#UPDATE"/>
        /// </summary>
        public static int UPDATE => Clazz.GetField<int>("UPDATE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/PaintEvent.html#getUpdateRect()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/PaintEvent.html#setUpdateRect(java.awt.Rectangle)"/>
        /// </summary>
        public Java.Awt.Rectangle UpdateRect
        {
            get { return IExecute<Java.Awt.Rectangle>("getUpdateRect"); } set { IExecute("setUpdateRect", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}