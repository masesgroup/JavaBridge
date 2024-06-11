/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print
{
    #region IMultiDoc
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMultiDoc
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/MultiDoc.html#getDoc()"/> 
        /// </summary>
        Javax.Print.Doc Doc { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/MultiDoc.html#next()"/>
        /// </summary>
        /// <returns><see cref="Javax.Print.MultiDoc"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Javax.Print.MultiDoc Next();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MultiDoc
    public partial class MultiDoc : Javax.Print.IMultiDoc
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/MultiDoc.html#getDoc()"/> 
        /// </summary>
        public Javax.Print.Doc Doc
        {
            get { return IExecuteWithSignature<Javax.Print.Doc>("getDoc", "()Ljavax/print/Doc;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/MultiDoc.html#next()"/>
        /// </summary>
        /// <returns><see cref="Javax.Print.MultiDoc"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Print.MultiDoc Next()
        {
            return IExecuteWithSignature<Javax.Print.MultiDoc>("next", "()Ljavax/print/MultiDoc;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}