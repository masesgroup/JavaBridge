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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Ls
{
    #region LSSerializer
    public partial class LSSerializer
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSSerializer.html#getDomConfig()"/> 
        /// </summary>
        public Org.W3c.Dom.DOMConfiguration DomConfig
        {
            get { return IExecute<Org.W3c.Dom.DOMConfiguration>("getDomConfig"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSSerializer.html#getFilter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSSerializer.html#setFilter(org.w3c.dom.ls.LSSerializerFilter)"/>
        /// </summary>
        public Org.W3c.Dom.Ls.LSSerializerFilter Filter
        {
            get { return IExecute<Org.W3c.Dom.Ls.LSSerializerFilter>("getFilter"); } set { IExecute("setFilter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSSerializer.html#getNewLine()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSSerializer.html#setNewLine(java.lang.String)"/>
        /// </summary>
        public string NewLine
        {
            get { return IExecute<string>("getNewLine"); } set { IExecute("setNewLine", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSSerializer.html#write(org.w3c.dom.Node,org.w3c.dom.ls.LSOutput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Ls.LSOutput"/></param>
        /// <returns><see langword="bool"/></returns>
        /// <exception cref="Org.W3c.Dom.Ls.LSException"/>
        public bool Write(Org.W3c.Dom.Node arg0, Org.W3c.Dom.Ls.LSOutput arg1)
        {
            return IExecute<bool>("write", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSSerializer.html#writeToURI(org.w3c.dom.Node,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see langword="string"/></param>
        /// <returns><see langword="bool"/></returns>
        /// <exception cref="Org.W3c.Dom.Ls.LSException"/>
        public bool WriteToURI(Org.W3c.Dom.Node arg0, string arg1)
        {
            return IExecute<bool>("writeToURI", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ls/LSSerializer.html#writeToString(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see langword="string"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ls.LSException"/>
        public string WriteToString(Org.W3c.Dom.Node arg0)
        {
            return IExecute<string>("writeToString", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}