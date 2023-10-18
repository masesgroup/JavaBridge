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

namespace Javax.Print
{
    #region SimpleDoc
    public partial class SimpleDoc
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/SimpleDoc.html#%3Cinit%3E(java.lang.Object,javax.print.DocFlavor,javax.print.attribute.DocAttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg2"><see cref="Javax.Print.Attribute.DocAttributeSet"/></param>
        public SimpleDoc(object arg0, Javax.Print.DocFlavor arg1, Javax.Print.Attribute.DocAttributeSet arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/SimpleDoc.html#getAttributes()"/> 
        /// </summary>
        public Javax.Print.Attribute.DocAttributeSet Attributes
        {
            get { return IExecute<Javax.Print.Attribute.DocAttributeSet>("getAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/SimpleDoc.html#getDocFlavor()"/> 
        /// </summary>
        public Javax.Print.DocFlavor DocFlavor
        {
            get { return IExecute<Javax.Print.DocFlavor>("getDocFlavor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/SimpleDoc.html#getPrintData()"/> 
        /// </summary>
        public object PrintData
        {
            get { return IExecute("getPrintData"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/SimpleDoc.html#getReaderForText()"/> 
        /// </summary>
        public Java.Io.Reader ReaderForText
        {
            get { return IExecute<Java.Io.Reader>("getReaderForText"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/SimpleDoc.html#getStreamForBytes()"/> 
        /// </summary>
        public Java.Io.InputStream StreamForBytes
        {
            get { return IExecute<Java.Io.InputStream>("getStreamForBytes"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}